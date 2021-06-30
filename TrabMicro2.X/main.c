/*
 * File:   main.c
 * Author: mcdto
 *
 * Created on 17 de Março de 2021, 23:37
 */

#define _XTAL_FREQ 8000000
#include <xc.h>
#include "configbits.h"
#include "teclado.h"
#include "flexlcd.h"
#include "atraso.h"
#include "itoa.h"
#include "adc.h"
#include <stdio.h>
#include "txtTelas.h"
#include "pwm.h"
#include "serial.h"

//Variables
char buffer_tx[22], buffer_rx[22];
unsigned char dado;
void leituraCXI();
void leituraCXS();
void testeMin();
void maketela(unsigned int estados0);
void atualizatela(unsigned int estados[3]);
unsigned int states[] = {0,0,0}; //screen,mode,state
char str[4];
unsigned int count,count2, flag_safe = 0;
unsigned int minCXI,minCXS,nivelCXI,nivelCXS;
float tensaoCXI,tensaoCXS = 0;

unsigned char tecla;
char key = ' ';

void main()
{ 
    ADCON0 = 0b00000000;
    ADCON1 = 0x00; 
    INTCON2bits.RBPU = 1; 
    T1CON = 0b10000011; 
    TMR1L = 0; 
    TMR1H = 0;
    PWM1_Init(1000);  
    PWM1_Start(); 
    INTCON = 0b11100000;   
    INTCON2 = 0b10000000; 
    TRISA = 0b11111111; //0 saida    1 entrada
    TRISB = 0b00000000; 
    TRISC = 0b10000000;
    TRISD = 0b00001111; 
    TRISE = 0b00000001;
    // Clear ports
    PORTA = 0;
    LATA = 0;
    PORTB = 0xFF;
    LATB = 0xFF;
    PORTC = 0; 
    LATC = 0;
    PORTD = 0x0F; 
    LATD = 0x0F;
    PORTE = 0; 
    LATE = 0;
    INTCON2bits.INTEDG0 = 0;
    INTCONbits.INT0IF = 0;
    INTCONbits.INT0IE = 1;
    INTCONbits.TMR0IF = 0;
    INTCONbits.TMR0IE = 1;

    //Timer 0 config
    T0CON = 0b11000101; // 8bit and 1:64 Prescale
    TMR0 = 131;
    ei(); // Enable global interrupt
    
    adc_init();
    Lcd_Init();
    serial_init();
    states[0] = 2;
    maketela(states[0]);
    atualizatela(states);
    int dado;
    while(1) 
    {
        CLRWDT();
        dado = serial_rx('\n');
        sprintf(str, "%03d\n", dado);
        leituraCXI();            
        leituraCXS();
        testeMin();        
        tecla = tc_tecla(1500)+0x30;  
        if ((tecla == '1')|(dado == '1'))   // config <--
        {
            states[0] = 1;
            maketela(states[0]);
            atualizatela(states);
        }
        if ((tecla == '2')|(dado == '2'))   // menu principal <-->
        {
            states[0] = 2;
            maketela(states[0]);
            atualizatela(states);
        }
        else if ((tecla == '3')|(dado == '3'))  // niveis -->
        {
            states[0] = 3;
            maketela(states[0]);
            atualizatela(states);
        }        
        else if ((tecla == '4')|(dado == '4'))  // set nivel minimo cx inf
        {            
            minCXI = minCXI + 10;
            if (minCXI > 100)
            {
                minCXI = 0;
            }
            states[0] = 1;
            maketela(states[0]);
            atualizatela(states);
        }        
        else if ((tecla == '5')|(dado == '5'))  // set nivel minimo cx sup
        {            
            minCXS = minCXS + 10;
            if (minCXS > 100)
            {
                minCXS = 0;
            }
            states[0] = 1;
            maketela(states[0]);
            atualizatela(states);
        }     
        else if ((tecla == '9')|(dado == '9'))  // trocar modo
        {
            states[1] = states[1] + 1;
            if (states[1] > 1)
            {
                states[1] = 0;
                states[0] = 2;
                maketela(states[0]);
                atualizatela(states);
            }
        }
        
        if (states[1] == 0)  // modo automatico
        {
            if ((tensaoCXI >= 1.4 && tensaoCXS <= 3.0) && (states[2]==0)) // caixa inf acima de 10% e caixa sup inferior a 50%
            {
                PORTCbits.RC0 = 0x01;
                states[2] = 1;
            }
            else if ((tensaoCXI <= 1.0 || tensaoCXS <= 4.6) && (states[2]==1)) // caixa inf vazia ou caixa sup a 90%
            {
                PORTCbits.RC0 = 0x01;
            }
            else
            {
                PORTCbits.RC0 = 0x00;
                states[2] = 0;
            }
        }
        if (states[1] == 1)  // modo manual
        {
            tecla = tc_tecla(1500)+0x30; 
            if ((tecla == '6')|(dado == '6'))
            {
                PORTCbits.RC0 =! PORTCbits.RC0;
                if (PORTCbits.RC0 == 0)
                {
                    states[2]=0;
                }
                else if (PORTCbits.RC0 == 1)
                {
                    states[2]=1;
                }
            }
        }
        
        if (states[1] == 2)  // modo erro 
        {
            leituraCXI();
            leituraCXS();
            testeMin();
            PORTCbits.RC0 = 0;
            if (flag_safe == 1)
            {
                states[1] = 1;
                states[2] = 0;
                flag_safe = 0;
                maketela(2);
                //__delay_ms(10);
            }
        }        
    }
}

void leituraCXI()
{
    nivelCXI = (adc_amostra(0));
    tensaoCXI = (nivelCXI*5.0)/1023;
}
void leituraCXS()
{
    nivelCXS = (adc_amostra(1));
    tensaoCXS = (nivelCXS*5.0)/1023;
}
void testeMin()
{
    if (tensaoCXI < 1.0 | tensaoCXS < 1.0)
    {
        states[1] = 2;
    }
    else 
    {
        flag_safe = 1;
    }
}

void maketela(unsigned int estados0)
{
    Lcd_Cmd(LCD_CLEAR);
    Lcd_Cmd(LCD_CURSOR_OFF);    
    if (estados0 == 2)
    {
        Lcd_Out(1, 0, txt11);
        Lcd_Out(2, 0, txt21);        
        Lcd_Out(3, 0, txt31);
        Lcd_Out(4, 0, txt41);
    }
    else if (estados0 == 1)
    {
        Lcd_Out(1, 0, txt12);
        Lcd_Out(2, 0, txt22);        
        Lcd_Out(3, 0, txt32);        
        Lcd_Out(4, 0, txt42);
    }
    else if (estados0 == 3)
    {   
        Lcd_Out(1, 0, txt13);    
        Lcd_Out(2, 0, txt23);
        Lcd_Out(3, 0, txt33);
        Lcd_Out(4, 0, txt43);
    }
    __delay_ms(25);
}

void atualizatela(unsigned int estados[3]) //screen,mode,state
{
    if (estados[1] == 2)
    {
        Lcd_Out(1, 0, txt0);
        Lcd_Out(2, 0, txt2e);
        Lcd_Out(3, 0, txt3e);
        Lcd_Out(4, 0, txt0);
    }
    if ((estados[0] == 2) && (estados[1] != 2))
    {
        if (estados[1] == 0)
        {
            Lcd_Out(2, 6, "AUTO  ");
        }
        else if (estados[1] == 1)
        {
            Lcd_Out(2, 6, "MANUAL    ");
        }
        if (estados[2] == 0)
        {
            Lcd_Out(3, 8, "DESL    ");
        }
        else if (estados[2] == 1)
        {
            Lcd_Out(3, 8, "LIG     ");
        }
    }
    else if (estados[0] == 1 && (estados[1] != 2))
    {   
        sprintf(str, "%02d", minCXI);
        Lcd_Out(2, 12, str);  
        sprintf(str, "%02d", minCXS);
        Lcd_Out(3, 12, str);
    }
    else if (estados[0] == 3 && (estados[1] != 2))
    {
        leituraCXI();
        leituraCXS();
        sprintf(str, "%04.2f", (tensaoCXI*100.0)/5.0);
        Lcd_Out(2, 11, str); 
        sprintf(str, "%04.2f", (tensaoCXS*100.0)/5.0);   
        Lcd_Out(3, 11, str);
    }
    __delay_ms(25);
}

void transmitedados()
{
    sprintf(buffer_tx, "/*%04d", adc_amostra(0)); // nivelCXI        
    serial_tx_str(buffer_tx); 
    sprintf(buffer_tx, "/%04d", adc_amostra(1)); // nivelCXS     
    serial_tx_str(buffer_tx);
    sprintf(buffer_tx, "/%02d", states[1]); // AUT, MANUAL ou ERRO         
    serial_tx_str(buffer_tx);
    sprintf(buffer_tx, "%02d", states[2]); // DESL ou LIG        
    serial_tx_str(buffer_tx);
    sprintf(buffer_tx, "/%02d", minCXI); // nivel maximo CXI
    serial_tx_str(buffer_tx);
    sprintf(buffer_tx, "%02d\n", minCXS); // nivel maximo CXS
    serial_tx_str(buffer_tx);
}
void interrupt isr(void)
{
    if (INTCONbits.INT0F == 1)
    {
        INTCONbits.INT0F = 0; // Clear interrupt flag
    }
    if (INTCONbits.TMR0IF == 1)
    {
        INTCONbits.TMR0IF = 0; // Clear interrupt flag
        TMR0 = 131;
        count ++;
        if (count == 250) // 1s
        {
            count = 0;
            atualizatela(states);
            transmitedados(); 
        }
        
    }
}
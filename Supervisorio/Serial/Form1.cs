using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports; //deve-se acrescentar este namespace
using System.Data.SqlClient;
using System.IO;
using StatDescriptive;
using NUnit;
using System.Collections;
// IDIOMAS
using System.Globalization;
using System.Resources;

namespace Serial
{    
    public partial class Form1 : Form
    {
        
        //VARIÁVEIS
        string InputData = String.Empty;
        int[] Hleitura0 = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        int[] Hleitura1 = new int[7] { 0, 0, 0, 0, 0, 0, 0 }; // vetores com históricos das leituras 
        //flags dos botões
        Boolean Modbus = false; //*****************************

        byte[] bufferBytes = new byte[300];

        int m = 0;
        ArrayList bytes = new ArrayList();


        public Form1()
        {
            InitializeComponent();
            

            //obter as portas COM disponíveis
            String[] ports = SerialPort.GetPortNames();
            // adicionar as portas ao combobox
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            
            // try to open the selected port:
            try
            {
                serialPort1.Open();
            }
            // give a message, if the port is not available:
            catch
            {
                MessageBox.Show("A porta serial " + serialPort1.PortName +
                   " não pode ser aberta", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.SelectedText = "";                
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (!Modbus)
                {
                    serialPort1.WriteLine(textBoxSaida.Text);
                }
                else
                {
                    String[] envia = textBoxSaida.Text.Split(' ');
                    byte[] enviabyte = new byte[30];
                    for (int i=0; i < envia.Length; i++)
                    {
                        enviabyte[i] =  Convert.ToByte(envia[i], 16);
                    }
                    serialPort1.Write(enviabyte, 0, 8);
                }             
            }
            else MessageBox.Show("A porta serial está fechada!",
                                 "Erro",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            textBoxSaida.Clear();

        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEntrada.Clear();
        }
        //o evento deve ser subescrito no arquivo .Designer.cs. Ex.: serialPort1.DataReceived += serialPort1_DataReceived;
        /*O += é também usado para especificar um método que será chamado em resposta a um evento; 
         * Esses métodos são chamados de manipuladores de eventos.O uso da += operador nesse contexto 
         * é conhecido como Assinando um evento
         *mais em http://msdn.microsoft.com/pt-br/library/vstudio/ms366768.aspx
         */
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //RECEBE STRING
            if (!Modbus)
            {

                InputData = serialPort1.ReadLine(); //para ReadExisting(), configurar ReadBytesTreshhold = 7 (PICSimLab 0.8.5 não está estável)
                this.Invoke(new EventHandler(DisplayText));
            }
            else
            {//MODBUS RTU - RECEBE ARRAY DE BYTES
                m = serialPort1.BytesToRead;
                serialPort1.Read(bufferBytes, 0, m);
                this.Invoke(new EventHandler(DisplayText));
            }
        }
        private void DisplayText(object sender, EventArgs e)
        {            
            if (!Modbus)
            {
                string input, adc0, adc1, mode, state,nvCXS, nvCXI;
                int leitura0, leitura1;                
                int i = 0;
                //textBoxEntrada.Clear();
                textBoxEntrada.AppendText(InputData);
                input = InputData.ToString();
                //configurações de propriedades do gauge 1 via código
                /*aGauge1.MaxValue = 100;
                aGauge1.Range_Idx = 0;
                aGauge1.RangesEndValue = 90.0;*/
                //configurações de propriedades do gráfico 1 via código
                aChart1.Series["Nível - Caixa Superior"].BorderWidth = 3; //espessura da linha
                aChart1.Series["Nível - Caixa Superior"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline; // tipo da linha
                {
                    try
                    {
                        // Trata dados da string recebida /*0000/
                        if (input != string.Empty)
                        {
                            // Formato da mensagem: /*ADC0/ADC1/0Mode0State/NvCXINvCXS
                            i = input.IndexOf("*"); //Obtem índice onde aparece *
                            adc0 = input.Substring(i + 1, 4); // captura 4 bytes após * (0000)
                            label1.Text = adc0; // passa valor para o label1
                            adc1 = input.Substring(i + 6, 4);
                            label2.Text = adc1; // passa valor para o label2
                            mode = input.Substring(i + 12, 1);
                            state = input.Substring(i + 14, 1);
                            nvCXI = input.Substring(i + 16, 2);
                            label13.Text = nvCXI;
                            nvCXS = input.Substring(i + 18, 2);
                            label12.Text = nvCXS;
                            leitura0 = Convert.ToInt32(adc0);
                            leitura1 = Convert.ToInt32(adc1);
                            for (int k=6;k>0;k--) // atualização do historico de leituras
                            {
                                Hleitura0[k] = Hleitura0[k-1];
                                Hleitura1[k] = Hleitura1[k-1];
                            }
                            Hleitura0[0] = leitura0;
                            Hleitura1[0] = leitura1;
                            if (Convert.ToChar(mode) == '0')
                            {
                                label3.Text = ("AUTOM"); // passa valor para o label3
                                labelModo.Text = ("AUTOMATICO"); // passa o valor para o labelModo (tela de comandos)
                            }
                            else if (Convert.ToChar(mode) == '1')
                            {
                                label3.Text = ("MANUAL");
                                labelModo.Text = ("MANUAL");
                            }
                            else if (Convert.ToChar(mode) == '2')
                            {
                                label3.Text = ("ERRO");
                                labelModo.Text = ("ERRO TENSAO BAIXA");
                            }
                            if (Convert.ToChar(state) == '0')
                            {
                                label8.Text = "DESLIG"; // passa valor para o label8
                                labelEstado.Text = "DESLIGADO"; // passa o valor para o labelEstado (tela de comandos)
                            }
                            else if (Convert.ToChar(state) == '1')
                            {
                                label8.Text = "LIGADO";
                                labelEstado.Text = "LIGADO";
                            }
                            
                            // Escreve nos gráficos
                            aChart1.Series["Nível - Caixa Superior"].Points.AddY((leitura1 * 100) / 1023);
                            aChart2.Series["Nível - Caixa Inferior"].Points.AddY((leitura0 * 100) / 1023);
                            
                            // Escreve nos gauges
                            aGauge1.Value = (leitura1 * 100) / 1023;
                            aGauge2.Value = (leitura0 * 100) / 1023;

                            //Escreve o histórico
                            labelMed1.Text = Convert.ToString(Hleitura0[0] * 100 / 1023) + "%";
                            labelMed2.Text = Convert.ToString(Hleitura0[1] * 100 / 1023) + "%";
                            labelMed3.Text = Convert.ToString(Hleitura0[2] * 100 / 1023) + "%";
                            labelMed4.Text = Convert.ToString(Hleitura0[3] * 100 / 1023) + "%";
                            labelMed5.Text = Convert.ToString(Hleitura0[4] * 100 / 1023) + "%";
                            labelMed6.Text = Convert.ToString(Hleitura0[5] * 100 / 1023) + "%";
                            labelMed7.Text = Convert.ToString(Hleitura0[6] * 100 / 1023) + "%";

                            labelMed8.Text = Convert.ToString(Hleitura1[0] * 100 / 1023) + "%";
                            labelMed9.Text = Convert.ToString(Hleitura1[1] * 100 / 1023) + "%";
                            labelMed10.Text = Convert.ToString(Hleitura1[2] * 100 / 1023) + "%";
                            labelMed11.Text = Convert.ToString(Hleitura1[3] * 100 / 1023) + "%";
                            labelMed12.Text = Convert.ToString(Hleitura1[4] * 100 / 1023) + "%";
                            labelMed13.Text = Convert.ToString(Hleitura1[5] * 100 / 1023) + "%";
                            labelMed14.Text = Convert.ToString(Hleitura1[6] * 100 / 1023) + "%";

                            // Escreve os dados na tela de comandos
                            // labelModo e labelEstado já atualizados nos ifs acima
                            labelnvCXI.Text = nvCXI + "%";
                            labelnvCXS.Text = nvCXS + "%";
                            // Escreve na tabela do DataGridView
                            var row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = Convert.ToDouble(adc0)
                            });
                            dataGridViewSensor.Rows.Add(row);
                        }
                    }
                    catch { }
                }               

            }
            else // MODO MODBUS RTU
            {
                for (int i = 0; i < m; i++)
                {
                    //Mostra dados que chegaram na porta serial no textbox em formado hexadecimal de dois dígitos
                    textBoxEntrada.AppendText(bufferBytes[i].ToString("X2")+" "); //hex 2 digit
                    //Adiciona os dados que chegaram na porta serial no vetor "bytes"
                    bytes.Add(bufferBytes[i]); // INSERIR BREAKPOINT AQUI E VISUALIZAR O QUE FOI RECEBIDO
                }

                if (bytes.Count > 4)
                {
                    // Percorre o ArrayList dos bytes para procurar posição incorreta do byte de controle "2" e remove
                    // os bytes que estão perdidos sem o controle do começo.
                    // Este problema pode ocorrer dependendo do momento em que o SCADA começou a coletar os dados
                    // da porta serial.
                    for (int i = 1; i < 5; i++)
                    {
                        if (Convert.ToInt32(bytes[i]) == 1)
                        {
                            bytes.RemoveRange(0, i);
                            break;
                        }
                    }

                    // Percorre o ArrayList dos bytes à procura do byte de controle "1", depois extrai os 8 bytes seguintes
                    // para identificar o pacote
                    int aux = 0;
                    while (bytes.Count > 4)
                    {
                        if (Convert.ToInt32(bytes[aux]) == 1)
                        {
                            // Calcula a temperatura com base nos 4 bytes (float)
                            //indicacao = System.BitConverter.ToSingle((byte[])bytes.GetRange(aux + 3, 4).ToArray(typeof(byte)), 0);
                            
                            // passar informação de 16 bits ao Label
                            int reg16;
                            reg16 = Convert.ToByte(bytes[aux + 4]);
                            reg16 += Convert.ToByte(bytes[aux + 3]) << 8;
                            
                            label1.Text = reg16.ToString();
                            
                            // Insere a temperatura no gráfico superior
                           
                            // Atualiza o label com o valor da temperatura
                            
                            // Adiciona a nova temperatura na lista das últimas 5 temperaturas para cálculo da média móvel
                            
                            // Calcula a média móvel somente se houverem mais que 5 medições na lista de temperaturas.
                            // Remove o 1o elemento da lista, que é a temperatura mais antiga.
                            
                            bytes.Clear();
                            aux = 0;
                        }
                        else
                            aux++;
                            
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //obter as portas COM disponíveis
            String[] ports = SerialPort.GetPortNames();
            // adicionar as portas ao combobox
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }       
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sobre = new Form2();
            sobre.Show();
        }
          
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            //aChart1.Series["Nível - Caixa Supeior"].Points.AddY(indicacao);
        }
    
        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            timerChart1.Enabled = true;
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void aChart2_Click(object sender, EventArgs e)
        {

        }

        private void buttonModo_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(Convert.ToString('9'));
        }

        private void buttonnvCXS_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(Convert.ToString('5'));
        }

        private void buttonnvCXI_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(Convert.ToString('4'));
        }

        private void buttonBomba_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(Convert.ToString('6'));
        }
    }
}

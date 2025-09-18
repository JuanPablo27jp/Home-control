using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace Par
{
    public partial class Form2 : Form
    {
        private SpeechRecognitionEngine Voz = new SpeechRecognitionEngine();
        public Form2()
        {
            InitializeComponent();
            serialPort1.PortName = "COM6";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void TBluz_Scroll(object sender, EventArgs e)
        {
            if (TBluz.Value == 0)
            {

                ven1.FillColor = Color.PaleTurquoise;
                ven2.FillColor = Color.PaleTurquoise;
                serialPort1.Write("0");
            }
            else
            {
                ven1.FillColor = Color.Yellow;
                ven2.FillColor = Color.Yellow;
                serialPort1.Write("1");
            }
            
        }

        private void TBpuer_Scroll(object sender, EventArgs e)
        {
            if (TBpuer.Value == 0)
            {
                puer.FillColor = Color.Sienna;
                serialPort1.Write("2");
            }
            else
            {
                puer.FillColor = Color.Black;
                serialPort1.Write("3");
            }
            
        }

        private void TBcoch_Scroll(object sender, EventArgs e)
        {
            if (TBcoch.Value == 0)
            {
                coch.FillColor = Color.Gray;
                serialPort1.Write("4");
            }
            else
            {
                coch.FillColor = Color.Black;
                serialPort1.Write("8");
            }
        }

        private void Escuchar_Click(object sender, EventArgs e)
        {
            try
            {
                Voz.SetInputToDefaultAudioDevice();
                Voz.LoadGrammar(new DictationGrammar());
                Voz.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(lector);
                Voz.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No se puede ejecutar al mismo tiempo");
            }
        }

        public void lector(object sender, SpeechRecognizedEventArgs e)
        {
            foreach (RecognizedWordUnit palabra in e.Result.Words)
            {
                Lmen.Text = palabra.Text;

                if (palabra.Text == "cero")
                {
                    serialPort1.Write("0");
                }
                else if (palabra.Text == "uno")
                {
                    serialPort1.Write("1");
                }
                else if (palabra.Text == "dos")
                {
                    serialPort1.Write("2");
                }
                else if (palabra.Text == "tres")
                {
                    serialPort1.Write("3");
                }
                else if (palabra.Text == "cuatro")
                {
                    serialPort1.Write("4");
                }
                else if (palabra.Text == "cinco")
                {
                    serialPort1.Write("8");
                }
            }
        }
        private void RScochera_Click(object sender, EventArgs e)
        {

        }

        private void RBvoz_CheckedChanged(object sender, EventArgs e)
        {
            GBvoz.Show();
        }
    }
}

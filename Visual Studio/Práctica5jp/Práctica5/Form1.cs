using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Par
{
    public partial class Form1 : Form
    {
        //Declaro un Objeto que es la Forma 2 y le llamo fprin
        Form2 fprin=new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void TBusu_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBusu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==13)//Valor ascii del Enter
            {
                if((LBusu.SelectedIndex== 0) && (TBusu.Text=="1234"))
                {
                    //Entro un adulto
                    fprin.TBpuer.Enabled = true;
                    fprin.TBcoch.Enabled = true;
                    fprin.Show();

                }else if ((LBusu.SelectedIndex == 1) && (TBusu.Text == "5678"))
                {
                    //Entro un menor
                    fprin.TBpuer.Enabled = false;
                    fprin.TBcoch.Enabled = false;
                    fprin.Show();

                }else
                {
                    MessageBox.Show("Contraseña no valida","Error de registro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    TBusu.Clear();
                    TBusu.Focus();
                }
            }
        }
    }
}

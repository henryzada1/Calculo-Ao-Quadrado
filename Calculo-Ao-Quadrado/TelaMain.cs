using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Ao_Quadrado
{
    public partial class TelaMain : Form
    {
        public TelaMain()
        {
            InitializeComponent();
        }


        private void btnCalculo_Click(object sender, EventArgs e)
        {

            if (tbNumero.Text == "")
            {
                MessageBox.Show("Digite um número");
            }
            else
            { 

                int numero = 0;
            int quadrado = 0;

            numero = Convert.ToInt32(tbNumero.Text);

            quadrado = numero * numero;

            lblResultado.Text = "O número " + numero + " ao quadrado, é " + quadrado;

            tbNumero.Focus();

            tbNumero.SelectAll();

           }
        }

        private void TelaMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;

            }

            if (e.KeyChar == 13)
            {
                btnCalculo.PerformClick();
            }
        }
    }
}

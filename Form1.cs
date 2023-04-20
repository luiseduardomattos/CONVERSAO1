using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONVERSAO1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void txtValor2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                   
        }

        private void btnConversao_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);

                txtResultado.Text = Convert.ToString(valor1 * valor2, CultureInfo.InvariantCulture);
        }
    }
}
        
    


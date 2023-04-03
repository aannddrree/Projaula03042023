using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projaula03042023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtValorA.Text);
            int b = int.Parse(txtValorB.Text);

            MessageBox.Show("A Soma é: " + (a + b));

        }
    }
}

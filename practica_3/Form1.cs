using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bValidar_Click(object sender, EventArgs e)
        {
            string numero = txtNumero.Text;
            string letra = txtLetra.Text;

            if (string.IsNullOrEmpty(letra) ||
                string.IsNullOrEmpty(letra))
            {
                MessageBox.Show("Escriba un texto");
            }

            if (int.TryParse(numero, out int n))
            {
                MessageBox.Show("Es un numero");
            }

            else
            {
                MessageBox.Show("No es un numero");
            }
        }
    }
}

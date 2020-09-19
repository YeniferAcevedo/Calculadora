using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Suma suma = new Suma();
        Resta resta = new Resta();
        Multiplicacion multiplicacion = new Multiplicacion();
        Division division = new Division();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            suma.setNumero1(double.Parse(txtNumero1.Text));
            suma.setNumero2(double.Parse(txtNumero2.Text));
            lblResultado.Visible = true;
            lblResultado.Text = Convert.ToString(suma.sumar());
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            resta.setNumero1(double.Parse(txtNumero1.Text));
            resta.setNumero2(double.Parse(txtNumero2.Text));
            lblResultado.Visible = true;
            lblResultado.Text = Convert.ToString(resta.restar());
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            multiplicacion.setNumero1(double.Parse(txtNumero1.Text));
            multiplicacion.setNumero2(double.Parse(txtNumero2.Text));
            lblResultado.Visible = true;
            lblResultado.Text = Convert.ToString(multiplicacion.multiplicar());
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            division.setNumero1(double.Parse(txtNumero1.Text));
            division.setNumero2(double.Parse(txtNumero2.Text));
            lblResultado.Visible = true;
            lblResultado.Text = Convert.ToString(division.dividir());
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            lblResultado.Text = string.Empty;
            lblResultado.Visible = false;
            txtNumero1.Focus();
        }
    }
}

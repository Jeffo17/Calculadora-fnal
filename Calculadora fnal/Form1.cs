using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_fnal
{
    public partial class Form1 : Form
    {
        string numero = string.Empty;
        string operadores;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {

            Operaciones operaciones = new Operaciones();

            numero = numero + "+";
            string[] num = numero.Split('+');
            lblCabecera1.Text = numero;
            lblCabecera2.Text = operaciones.suma(num).ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            numero = numero + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numero = numero + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numero = numero + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numero = numero + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numero = numero + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numero = numero + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numero = numero + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numero = numero + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numero = numero + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numero = numero + "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCabecera1.Text = "";
            lblCabecera2.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();

            string[] num = numero.Split('+');


            lblCabecera1.Text = numero;
            lblCabecera2.Text =Convert.ToString( operaciones.suma(num));
            
            lblCabecera1.Text = numero;
            lblCabecera2.Text = Convert.ToString(operaciones.resta(num));

            //lblCabecera1.Text = numero;
            //lblCabecera2.Text = Convert.ToString(operaciones.Multiplicacion(num));


            //lblCabecera1.Text = numero;
            //lblCabecera2.Text = Convert.ToString(operaciones.Division(num));

        }

        private void btnC_Click(object sender, EventArgs e)
        {

            numero = string.Empty;
            lblCabecera1.Text = "";
            lblCabecera2.Text = "";


        }

        private void btnresta_Click(object sender, EventArgs e)
        {

            Operaciones operaciones = new Operaciones();


            numero = numero + "-";
            string[] num = numero.Split('-');
            lblCabecera1.Text = numero;
            lblCabecera2.Text = Convert.ToString(operaciones.resta(num));
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();

            numero = numero + "*";
            string[] num = numero.Split('*');

            lblCabecera1.Text = numero;
            lblCabecera2.Text = Convert.ToString(operaciones.Multiplicacion(num));
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            numero = numero + "/";
            string[] num = numero.Split('/');
            lblCabecera1.Text = numero;
            lblCabecera2.Text = Convert.ToString(operaciones.Division(num));



        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(lblCabecera2.Text);
            num = (num * num);
            lblCabecera2.Text = num.ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(lblCabecera2.Text);
            num = Math.Sqrt(num);
            lblCabecera2.Text = num.ToString();

        }

        private void btnmasmenos_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(lblCabecera2.Text);
            a = ((a) * (-1));
            lblCabecera2.Text = a.ToString();
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            decimal num = Convert.ToDecimal(lblCabecera2.Text);
            num = (1 / num);
            lblCabecera2.Text = num.ToString();
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            decimal num = Convert.ToDecimal(lblCabecera2.Text);
            num = (num * num) / 100;
            lblCabecera2.Text = num.ToString();
        }

        private void btbCE_Click(object sender, EventArgs e)
        {
            if (lblCabecera2.Text.Length > 0)
            {
                lblCabecera2.Text = lblCabecera2.Text.Remove(lblCabecera2.Text.Length - 1);
            }
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            lblCabecera2.Text = lblCabecera2.Text + ".";
            operadores = operadores + ".";
            btnpunto.Enabled = false;
        }
    }
}


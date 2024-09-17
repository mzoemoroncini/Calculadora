using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion3
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        //variables necesarias
        string operador = "";
        double num1;
        double num2;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btborrar_Click(object sender, EventArgs e)
        {
            if (txbcargar.TextLength ==1) txbcargar.Text = "0";
            else txbcargar.Text = txbcargar.Text.Substring (0, txbcargar.TextLength - 1);
        }

        private void btborrartodo_Click(object sender, EventArgs e)
        {
            txbcargar.Text = "0";
            num1 = 0;   
            num2 = 0;
            operador = "";

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (txbcargar.Text == "0") txbcargar.Text = "";
            txbcargar.Text = txbcargar.Text + "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (txbcargar.Text == "0") txbcargar.Text = "";
            txbcargar.Text = txbcargar.Text + "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (txbcargar.Text == "0") txbcargar.Text = "";
            txbcargar.Text = txbcargar.Text + "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (txbcargar.Text == "0") txbcargar.Text = "";
            txbcargar.Text = txbcargar.Text + "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (txbcargar.Text == "0") txbcargar.Text = "";
            txbcargar.Text = txbcargar.Text + "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (txbcargar.Text == "0") txbcargar.Text = "";
            txbcargar.Text = txbcargar.Text + "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (txbcargar.Text == "0") txbcargar.Text = "";
            txbcargar.Text = txbcargar.Text + "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (txbcargar.Text == "0") txbcargar.Text = "";
            txbcargar.Text = txbcargar.Text + "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (txbcargar.Text == "0") txbcargar.Text = "";
            txbcargar.Text = txbcargar.Text + "9";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txbcargar.Text = txbcargar.Text + "0";
        }

        private void btcoma_Click(object sender, EventArgs e)
        {
            txbcargar.Text = txbcargar.Text + ",";
        }

        private void btsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1= Convert.ToDouble(txbcargar.Text);
            txbcargar.Text = "0";

        }

        private void btresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(txbcargar.Text);
            txbcargar.Text = "0";
        }

        private void btdividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(txbcargar.Text);
            txbcargar.Text = "0";
        }

        private void btmultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(txbcargar.Text);
            txbcargar.Text = "0";
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            num2=Convert.ToDouble(txbcargar.Text);

             switch (operador)
             {
                case "+":
                    txbcargar.Text = $"{num1 + num2}";
                break;

                case "-":
                    txbcargar.Text = $"{num1 - num2}";
                    break;

                case "/":
                    txbcargar.Text = $"{num1 / num2}";
                    break;

                case "*":
                    txbcargar.Text = $"{num1 * num2}";
                    break;
            }
        }
    }
}

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
    public partial class Form1 : Form {

        //Global variables
        double numOne = 0, numTwo = 0, tot = 100;
        
        char operation; //Suport char apenas um caracter

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*
        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            //can't type
            e.Handled = true;
        }
        */


        //Screen iniciation ZERO
        //Create a variable to receive data and show it in the Result
        private void addNumbers(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if  (txtResult.Text == "0")
                txtResult.Text = "";

            txtResult.Text += boton.Text;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 1)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            else
            {
                txtResult.Text = "0";
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            numOne = 0;
            numTwo = 0;
            operation = '\0';
            txtResult.Text = "0";
        }

        private void btnOffOn_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void brnVirg_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains(","))
            {
                txtResult.Text+= ",";
            }
        }

        private void btnEgual_Click(object sender, EventArgs e)
        {
            
            numTwo = Convert.ToDouble(txtResult.Text);
            if ( operation == '+')
            {
                txtResult.Text = (numOne + numTwo).ToString();
                numOne = Convert.ToDouble(txtResult.Text);
            }
            else if (operation == '-')
            {
                txtResult.Text = (numOne - numTwo).ToString();
                numOne = Convert.ToDouble(txtResult.Text);
            }
            else if (operation == '*')
            {
                txtResult.Text = (numOne * numTwo).ToString();
                numOne = Convert.ToDouble(txtResult.Text);
            }
            else if (operation == '/')
            {
                if(txtResult.Text != "0"){
                    txtResult.Text = (numOne / numTwo).ToString();
                    numOne = Convert.ToDouble(txtResult.Text);
                }
                else
                {
                    lblMsg.Text = "Não é possível a divisão por 0.";
                    lblMsg.Visible = true;

                }
            }
            
        }

        private void signals(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            numOne = Convert.ToDouble(txtResult.Text);
            operation = Convert.ToChar(boton.Tag);

            if (operation == '√') 
            {
                numOne = Math.Sqrt(numOne);
                txtResult.Text = numOne.ToString();
            }
            else if (operation == '²') 
            {
                numOne = Math.Pow(numOne, 2);
                txtResult.Text = numOne.ToString();
            }
            else if (operation == '%')
            {
                numOne = ((numOne / tot) * tot);
                txtResult.Text = numOne.ToString();
            }
            else
            {
                
                txtResult.Text = "0";
            }
        }

    }
}

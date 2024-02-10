using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp69
{
    public partial class Form1 : Form
    {
      
            Button[] numericButtons = new Button[10];
            public Form1()
            {
                InitializeComponent();
                int counter = 0;
                for (int i = 0; i < numericButtons.Length; i++)
                {
                    numericButtons[i] = new Button();

                    numericButtons[i].Location = new Point(28 + (counter % 3) * 75, 308 - 70 * (counter / 3));
                    numericButtons[i].Name = "numericButton" + i;
                    numericButtons[i].Size = (i == 0) ? new Size(200, 50) : new Size(50, 50);
                    numericButtons[i].TabIndex = i + 1;
                    numericButtons[i].Text = i.ToString();
                    numericButtons[i].UseVisualStyleBackColor = true;
                    numericButtons[i].Click += new EventHandler(numericButtons_Click);
                    Controls.Add(numericButtons[i]);
                    counter = (i == 0) ? counter + 3 : counter + 1;
                }
            }

        private void numericButtons_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        int result = 0;
        bool isOperator = false;
        string operatorSign;
        private void button10_Click(object sender, EventArgs e)
        {
            if (isOperator)
            {
                isOperator = false;
                textBox1.Text = "";
            }
            textBox1.Text += (sender as Button).Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
       
            int tmp = int.Parse(textBox1.Text);
            isOperator = true;

            switch(operatorSign)
            {
                case "+":
                    result += tmp;
                    break;
                case "-":
                    result -= tmp;
                    break;
                case "*":
                    result *= tmp;
                    break;
                case "/":
                    result /= tmp;
                    break;
                default:
                    result += tmp;
                    break;

                    /* case "^":
                   result = Math.Pow(num1, num2);
                   break;
               case "sqrt":
                   result = Math.Sqrt(num1);
                   break;
               case "sin":
                   result = Math.Sin(num1);
                   break;
               case "cos":
                   result = Math.Cos(num1);
                   break;
               case "tan":
                   result = Math.Tan(num1);
                   break;
               case "log":
                   result = Math.Log(num1);
                   break;
                   */




            }
            operatorSign = (sender as Button).Text;
            textBox1.Text = result.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(textBox1.Text);
            double radians = angle * Math.PI / 180;
            double result = Math.Sin(radians);
            textBox1.Text = result.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(textBox1.Text);
            double radians = angle * Math.PI / 180;
            double result = Math.Cos(radians);
            textBox1.Text = result.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Log(number);
            textBox1.Text = result.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Sqrt(number);
            textBox1.Text = result.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Pow(number, 2);
            textBox1.Text = result.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            textBox1.Text = pi.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(textBox1.Text);
            double radians = angle * Math.PI / 180.0; // Açı derecesinden radyan cinsinden açı hesaplanır
            double result = Math.Tan(radians);
            textBox1.Text = result.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Sinh(number);
            textBox1.Text = result.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Cosh(number);
            textBox1.Text = result.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Tanh(number);
            textBox1.Text = result.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            string hex = number.ToString("X");
            textBox1.Text = hex;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double ln = Math.Log(number);
            textBox1.Text = ln.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            string bin = Convert.ToString(number, 2);
            textBox1.Text = bin;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            string bin = Convert.ToString(number, 2);
            textBox1.Text = bin;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double reciprocal = 1 / number;
            textBox1.Text = reciprocal.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double cube = number * number * number;
            textBox1.Text = cube.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";  // TextBox'ı boşalt
        }
    }
}

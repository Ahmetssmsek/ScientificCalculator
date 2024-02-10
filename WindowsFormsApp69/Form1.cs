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
      
            Button[] sayıbutonları = new Button[10];
            public Form1()
            {
                InitializeComponent();
                int counter = 0;
                for (int i = 0; i < sayıbutonları.Length; i++)
                {
                sayıbutonları[i] = new Button();

                sayıbutonları[i].Location = new Point(28 + (counter % 3) * 75, 308 - 70 * (counter / 3));
                sayıbutonları[i].Name = "numbers of button" + i;
                sayıbutonları[i].Size = (i == 0) ? new Size(200, 50) : new Size(50, 50);
                sayıbutonları[i].TabIndex = i + 1;
                sayıbutonları[i].Text = i.ToString();
                sayıbutonları[i].UseVisualStyleBackColor = true;
                sayıbutonları[i].Click += new EventHandler(numericButtons_Click);
                    Controls.Add(sayıbutonları[i]);
                    counter = (i == 0) ? counter + 3 : counter + 1;


                string[] functionNames = { "1","2","3","4","5","6","7","8","9","0","-","ln","sin", "cos", "tan", "log","C", "n!", "x^2", "sqrt","=" };
                int buttonWidth = 50;
                int buttonHeight = 50;
                int margin = 5;

                for (int a = 0; a < functionNames.Length; a++)
                {
                    Button functionButton = new Button();
                    functionButton.Text = functionNames[a];
                    functionButton.Name = "button" + functionNames[a];
                    functionButton.Click += new EventHandler(numericButtons_Click);
                    functionButton.Location = new Point(margin + (a % 4) * (buttonWidth + margin), margin + (a / 4 + 4) * (buttonHeight + margin));
                    functionButton.Size = new Size(buttonWidth, buttonHeight);
                    Controls.Add(functionButton);
                }

            }
        }

        private void numericButtons_Click(object sender, EventArgs e)
        {
           
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
                case "sin":
                    result = (int)Math.Sin(tmp);
                    break;

               case "x²":
                   result = (int)Math.Pow(tmp, 2);
                   break;
                case "x³":
                    result = (int)Math.Pow(tmp, 3);
                    break;
                case "Sqrt":
                   result = (int)Math.Sqrt(tmp);
                   break;
           
               case "cos":
                   result = (int)Math.Cos(tmp);
                   break;
               case "tan":
                   result = (int)Math.Tan(tmp);
                   break;
               case "log":
                   result = (int)Math.Log(tmp);
                   break;
                case "Sinh":
                    result = (int)Math.Sinh(tmp);
                    break;
                case "Cosh":
                    result = (int)Math.Cosh(tmp);
                    break;
                case "Tanh":
                    result = (int)Math.Tanh(tmp);
                    break;
                case "lnx":
                    result = (int)Math.Log(tmp);
                    break;




            }
            operatorSign = (sender as Button).Text;
            textBox1.Text = result.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int tmp = int.Parse(textBox1.Text);
            isOperator = true;
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

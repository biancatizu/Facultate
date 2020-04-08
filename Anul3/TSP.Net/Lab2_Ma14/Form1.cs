
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab2
{
    
    public partial class Form1 : Form
    {
 
        static string operation = "+";

        public Form1()
        {
            
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Form1_KeyPress);
        
    }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'e')
            {
               this.button9_Click(null, null);
            }
            if (e.KeyChar == '0')
            {
                this.button14_Click(null, null);
            }
            if (e.KeyChar == '3')
            {
                this.button1_Click(null, null);
            }
            if (e.KeyChar == '6')
            {
                this.button2_Click(null, null);
            }
            if (e.KeyChar == '2')
            {
                this.button3_Click(null, null);
            }
            if (e.KeyChar == '1')
            {
                this.button4_Click(null, null);
            }
            if (e.KeyChar == '5')
            {
                this.button5_Click(null, null);
            }
            if (e.KeyChar == '4')
            {
                this.button6_Click(null, null);
            }
            if (e.KeyChar == '9')
            {
                this.button7_Click(null, null);
            }
            if (e.KeyChar == '8')
            {
                this.button8_Click(null, null);
            }
            if (e.KeyChar == '7')
            {
                this.button10_Click(null, null);
            }
            if (e.KeyChar == '+')
            {
                this.button11_Click(null, null);
            }
            if (e.KeyChar == '-')
            {
                this.button12_Click(null, null);
            }
            if (e.KeyChar == 'c')
            {
                this.button13_Click(null, null);
            }
            if (e.KeyChar == '*')
            {
                this.button15_Click(null, null);
            }
            if (e.KeyChar == '/')
            {
                this.button16_Click(null, null);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label2.Text += "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.label2.Text = "";
            this.label1.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!this.label2.Text.Equals(""))
                this.label2.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(operation == "+")
            {
                this.label1.Text = (Int32.Parse(this.label2.Text) + Int32.Parse(label1.Text)).ToString();
                this.label2.Text = "";
            }
            if(operation == "-")
            {
                this.label1.Text = (Int32.Parse(this.label1.Text) - Int32.Parse(label2.Text)).ToString();
                this.label2.Text = "";
            }
            if (operation == "*")
            {
                this.label1.Text = (Int32.Parse(this.label1.Text) * Int32.Parse(label2.Text)).ToString();
                this.label2.Text = "";
            }
            if (operation == "/")
            {
                this.label1.Text = (Int32.Parse(this.label1.Text) / Int32.Parse(label2.Text)).ToString();
                this.label2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label2.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label2.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label2.Text += "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label2.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.label2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label2.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label2.Text += "9";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button12_Click(object sender, EventArgs e)
        {
            operation = "-";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operation = "+";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            operation = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operation = "/";
        }

    }
}

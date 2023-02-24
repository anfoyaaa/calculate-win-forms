using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate
{
    public partial class Form1 : Form
    {
        public bool flag;
        public string tempParametr;
        public string act;

        public Form1()
        {
            InitializeComponent();
        }

 
  

        

        private void panel1_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, EventArgs e)
        {

        }
        

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonTOCHKA_Click(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            int tempNumber;
            bool numb = int.TryParse(button1.Text, out tempNumber);

            if (TextBox.Text == "0" && numb)
            {
                TextBox.Text = button1.Text;
            }
            else
            {
                if (!button1.Text.Contains(","))
                {
                    TextBox.Text = TextBox.Text + button1.Text;


                }

                else
                {
                    TextBox.Text = TextBox.Text + button1.Text;
                }
            }

        }
        private void buttonc_Click(object sender, EventArgs e)
        {
            
                TextBox.Text = "0";
            
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Button ButtonAct = (Button)sender;
            act = ButtonAct.Text;
            tempParametr = TextBox.Text;
            flag = true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            double firstVar, secondVar, result = 0;
            Double.TryParse(tempParametr, out firstVar);
            Double.TryParse(TextBox.Text, out secondVar);

            if (act == "-")
            {
                result = firstVar - secondVar;
            }
            TextBox.Text = result.ToString();
            flag = true;    

            if (act == "+")
            {
                result = firstVar + secondVar;
            }
            TextBox.Text = result.ToString();
            flag = true;

            if (act == "x")
            {
                result = firstVar * secondVar;
            }
            TextBox.Text = result.ToString();
            flag = true;

            if (act == "/")
            {
                result = firstVar / secondVar;
            }
            TextBox.Text = result.ToString();
            flag = true;


            if (act == "*2")
            {
                result = firstVar * firstVar;
            }
            TextBox.Text = result.ToString();
            flag = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
    
    
}

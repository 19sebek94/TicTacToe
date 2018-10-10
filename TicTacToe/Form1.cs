using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
   

    public partial class Form1 : Form
    {
        int digit = 1;
       
        string mark = "O";

        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }
        

        private void Check_Win()
        {
            object[] polelist = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            var Winner = false;
            var Draw = false;



            if ((button1.Text==button2.Text&& button2.Text == button3.Text&& (button3.Text=="X"|| button3.Text == "O"))|| (button6.Text == button5.Text && button5.Text == button4.Text && (button4.Text == "X" || button4.Text == "O")) || (button9.Text == button8.Text && button8.Text == button7.Text && (button7.Text == "X" || button7.Text == "O")) || (button1.Text == button6.Text && button6.Text == button9.Text && (button9.Text == "X" || button9.Text == "O")) || (button2.Text == button5.Text && button5.Text == button8.Text && (button8.Text == "X" || button8.Text == "O")) || (button3.Text == button4.Text && button4.Text == button7.Text && (button7.Text == "X" || button7.Text == "O")) || (button1.Text == button5.Text && button5.Text == button7.Text && (button7.Text == "X" || button7.Text == "O")) || (button9.Text == button5.Text && button5.Text == button3.Text && (button3.Text == "X" || button3.Text == "O")))
            {
                if (button1.Text == button2.Text && button2.Text == button3.Text && (button3.Text == "X" || button3.Text == "O"))
                {
                    button1.BackColor = Color.LightGreen;
                    button2.BackColor = Color.LightGreen;
                    button3.BackColor = Color.LightGreen;
                }
                else if (button6.Text == button5.Text && button5.Text == button4.Text && (button4.Text == "X" || button4.Text == "O"))
                {
                    button6.BackColor = Color.LightGreen;
                    button5.BackColor = Color.LightGreen;
                    button4.BackColor = Color.LightGreen;
                }
                else if (button9.Text == button8.Text && button8.Text == button7.Text && (button7.Text == "X" || button7.Text == "O"))
                {
                    button9.BackColor = Color.LightGreen;
                    button8.BackColor = Color.LightGreen;
                    button7.BackColor = Color.LightGreen;
                }
                else if (button1.Text == button6.Text && button6.Text == button9.Text && (button9.Text == "X" || button9.Text == "O"))
                {
                    button1.BackColor = Color.LightGreen;
                    button6.BackColor = Color.LightGreen;
                    button9.BackColor = Color.LightGreen;
                }
                else if (button2.Text == button5.Text && button5.Text == button8.Text && (button8.Text == "X" || button8.Text == "O"))
                {
                    button2.BackColor = Color.LightGreen;
                    button5.BackColor = Color.LightGreen;
                    button8.BackColor = Color.LightGreen;
                }
                else if (button3.Text == button4.Text && button4.Text == button7.Text && (button7.Text == "X" || button7.Text == "O"))
                {
                    button3.BackColor = Color.LightGreen;
                    button4.BackColor = Color.LightGreen;
                    button7.BackColor = Color.LightGreen;
                }
                else if (button1.Text == button5.Text && button5.Text == button7.Text && (button7.Text == "X" || button7.Text == "O"))
                {
                    button1.BackColor = Color.LightGreen;
                    button5.BackColor = Color.LightGreen;
                    button7.BackColor = Color.LightGreen;
                }
                else if (button9.Text == button5.Text && button5.Text == button3.Text && (button3.Text == "X" || button3.Text == "O"))
                {
                    button9.BackColor = Color.LightGreen;
                    button5.BackColor = Color.LightGreen;
                    button3.BackColor = Color.LightGreen;
                }


                    foreach (Button c in polelist)
                {
                    c.Enabled = false;
                    Winner = true;

                }
                MessageBox.Show(mark+" Wins!!!");
               
            }
            else if(Winner==false && button1.Enabled==false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                Draw = true;
                label2.Visible = false;
                label3.Visible = false;
                MessageBox.Show("It's a draw!!!");
                
            }
       
            if (digit == 1 && Winner == false && Draw == false) { label2.Visible = false; label3.Visible = true; }
            else if (digit == 0 && Winner == false && Draw == false) { label3.Visible = false; label2.Visible = true; }
        }

        private int Swaper(int digit)
        {
            if (digit == 1) { digit = 0; }   
            else if (digit == 0) { digit = 1; }
            else { throw new Exception("Wrong digit"); }
            return digit;
        }

        private string Check_digit(int digit)
        {
            if (digit == 0) { mark = "O"; }
            else if (digit == 1) { mark = "X"; }
            else { throw new Exception("Wrong digit"); }
            return mark;
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            digit = Swaper(digit);
            button1.Text = Check_digit(digit);
            button1.Enabled = false;
            button1.BackColor = Color.White;
            Check_Win();


        }


        private void button3_Click(object sender, EventArgs e)
        {
            digit = Swaper(digit);
            button3.Text = Check_digit(digit);
            button3.Enabled = false;
            button3.BackColor = Color.White;
            Check_Win();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            digit = Swaper(digit);
            button6.Text = Check_digit(digit);
            button6.Enabled = false;
            button6.BackColor = Color.White;
            Check_Win();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            digit = Swaper(digit);
            button4.Text = Check_digit(digit);
            button4.Enabled = false;
            button4.BackColor = Color.White;
            Check_Win();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            digit = Swaper(digit);
            button9.Text = Check_digit(digit);
            button9.Enabled = false;
            button9.BackColor = Color.White;
            Check_Win();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            digit = Swaper(digit);
            button8.Text = Check_digit(digit);
            button8.Enabled = false;
            button8.BackColor = Color.White;
            Check_Win();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            digit = Swaper(digit);
            button7.Text = Check_digit(digit);
            button7.Enabled = false;
            button7.BackColor = Color.White;
            Check_Win();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            digit = Swaper(digit);
            button5.Text = Check_digit(digit);
            button5.Enabled = false;
            button5.BackColor = Color.White;
            Check_Win();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            digit = Swaper(digit);
            button2.Text = Check_digit(digit);
            button2.Enabled = false;
            button2.BackColor = Color.White;
            Check_Win();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            object[] polelist = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button control in polelist)
            {
                control.Enabled = true;
                control.Text = "";
                control.BackColor = default(Color);
            }
            mark = "O";
            digit = 1;
            label2.Visible = false;
            label3.Visible = true;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}

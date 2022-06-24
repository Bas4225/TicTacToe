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
        int[] board = new int[9];

        public Form1()
        {
            InitializeComponent();
        }

        private void getInput(int index)
        {
            board[index] = 1;
            label1.Focus();
            computerGuess();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            getInput(0);
            button0.Text = "X";
            button0.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getInput(1);
            button1.Text = "X";
            button1.Enabled = false;
        }
      
        private void button2_Click_1(object sender, EventArgs e)
        {
            getInput(2);
            button2.Text = "X";
            button2.Enabled = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            getInput(3);
            button3.Text = "X";
            button3.Enabled = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            getInput(4);
            button4.Text = "X";
            button4.Enabled = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            getInput(5);
            button5.Text = "X";
            button5.Enabled = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            getInput(6);
            button6.Text = "X";
            button6.Enabled = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            getInput(7);
            button7.Text = "X";
            button7.Enabled = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            getInput(8);
            button8.Text = "X";
            button8.Enabled = false;
        }

        private void newgameBTN_Click(object sender, EventArgs e)
        {
            board = new int[9];

            button0.Text = "";
            button0.Enabled = true;
            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
        }

        void computerGuess()
        {
            int[] possible = new int[0];

            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == 0)
                {
                    possible = possible.Append(i).ToArray();
                }
            }

            try
            {
                int index = possible[new Random().Next(possible.Length)];
                board[index] = 2;
                if (index == 0)
                {
                    button0.Text = "O";
                    button0.Enabled = false;
                }
                else if (index == 1)
                {
                    button1.Text = "O";
                    button1.Enabled = false;
                }
                else if (index == 2)
                {
                    button2.Text = "O";
                    button2.Enabled = false;
                }
                else if (index == 3)
                {
                    button3.Text = "O";
                    button3.Enabled = false;
                }
                else if (index == 4)
                {
                    button4.Text = "O";
                    button4.Enabled = false;
                }
                else if (index == 5)
                {
                    button5.Text = "O";
                    button5.Enabled = false;
                }
                else if (index == 6)
                {
                    button6.Text = "O";
                    button6.Enabled = false;
                }
                else if (index == 7)
                {
                    button7.Text = "O";
                    button7.Enabled = false;
                }
                else if (index == 8)
                {
                    button8.Text = "O";
                    button8.Enabled = false;
                }
            }
            catch
            {
                Console.WriteLine("All Spaces Filled!");
            }
        }
    }
}

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
        string[] positions = new string[] { "N", "N", "N", "N", "N", "N", "N", "N", "N" };
        Boolean playerTurn = false;
        int boxesPressed = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void checkWin()
        {
            //welcome to logic hell
            int win = 0;
            boxesPressed++;
            //checks for X win
            if((positions[0] == "X" && positions[1] == "X" && positions[2] == "X") || (positions[3] == "X" && positions[4] == "X" && positions[5] == "X") || (positions[6] == "X" && positions[7] == "X" && positions[8] == "X") || (positions[0] == "X" && positions[3] == "X" && positions[6] == "X") || (positions[1] == "X" && positions[4] == "X" && positions[7] == "X") || (positions[2] == "X" && positions[5] == "X" && positions[8] == "X") || (positions[0] == "X" && positions[4] == "X" && positions[8] == "X") || (positions[2] == "X" && positions[4] == "X" && positions[6] == "X"))
            {
                win = 1;
            }
            //checks for O win
            if((positions[0] == "O" && positions[1] == "O" && positions[2] == "O") || (positions[3] == "O" && positions[4] == "O" && positions[5] == "O") || (positions[6] == "O" && positions[7] == "O" && positions[8] == "O") || (positions[0] == "O" && positions[3] == "O" && positions[6] == "O") || (positions[1] == "O" && positions[4] == "O" && positions[7] == "O") || (positions[2] == "O" && positions[5] == "O" && positions[8] == "O") || (positions[0] == "O" && positions[4] == "O" && positions[8] == "O") || (positions[2] == "O" && positions[4] == "O" && positions[6] == "O"))
            {
                win = 2;
            }

            if(win == 1)
            {
                MessageBox.Show("X wins");
            } else if(win == 2)
            {
                MessageBox.Show("O wins");
            }
            else if(boxesPressed == 9)
            {
                MessageBox.Show("It's a tie!");
            }
            void reset(Button square)
            {
                square.Enabled = true;
                square.Text = "";
            }
            if(win != 0 || boxesPressed == 9)
            {
                reset(square1);
                reset(square2);
                reset(square3);
                reset(square4);
                reset(square5);
                reset(square6);
                reset(square7);
                reset(square8);
                reset(square9);
                positions = new string[] { "N", "N", "N", "N", "N", "N", "N", "N", "N" };
                boxesPressed = 0;
                playerTurn = false;
            }
            
        }
        private void square1_Click(object sender, EventArgs e)
        {
            if (playerTurn == false)
            {
                positions[0] = "X";
                square1.Text = "X";
                square1.Enabled = false;
                playerTurn = true;
            } else if(playerTurn == true)
            {
                positions[0] = "O";
                square1.Text = "O";
                square1.Enabled = false;
                playerTurn = false;
            }
            checkWin();
        }

        private void square2_Click(object sender, EventArgs e)
        {
            if (playerTurn == false)
            {
                positions[1] = "X";
                square2.Text = "X";
                square2.Enabled = false;
                playerTurn = true;
            }
            else if (playerTurn == true)
            {
                positions[1] = "O";
                square2.Text = "O";
                square2.Enabled = false;
                playerTurn = false;
            }
            checkWin();
        }

        private void square3_Click(object sender, EventArgs e)
        {
            if (playerTurn == false)
            {
                positions[2] = "X";
                square3.Text = "X";
                square3.Enabled = false;
                playerTurn = true;
            }
            else if (playerTurn == true)
            {
                positions[2] = "O";
                square3.Text = "O";
                square3.Enabled = false;
                playerTurn = false;
            }
            checkWin();
        }

        private void square4_Click(object sender, EventArgs e)
        {
            if (playerTurn == false)
            {
                positions[3] = "X";
                square4.Text = "X";
                square4.Enabled = false;
                playerTurn = true;
            }
            else if (playerTurn == true)
            {
                positions[3] = "O";
                square4.Text = "O";
                square4.Enabled = false;
                playerTurn = false;
            }
            checkWin();
        }

        private void square5_Click(object sender, EventArgs e)
        {
            if (playerTurn == false)
            {
                positions[4] = "X";
                square5.Text = "X";
                square5.Enabled = false;
                playerTurn = true;
            }
            else if (playerTurn == true)
            {
                positions[4] = "O";
                square5.Text = "O";
                square5.Enabled = false;
                playerTurn = false;
            }
            checkWin();
        }

        private void square6_Click(object sender, EventArgs e)
        {
            if (playerTurn == false)
            {
                positions[5] = "X";
                square6.Text = "X";
                square6.Enabled = false;
                playerTurn = true;
            }
            else if (playerTurn == true)
            {
                positions[5] = "O";
                square6.Text = "O";
                square6.Enabled = false;
                playerTurn = false;
            }
            checkWin();
        }

        private void square7_Click(object sender, EventArgs e)
        {
            if (playerTurn == false)
            {
                positions[6] = "X";
                square7.Text = "X";
                square7.Enabled = false;
                playerTurn = true;
            }
            else if (playerTurn == true)
            {
                positions[6] = "O";
                square7.Text = "O";
                square7.Enabled = false;
                playerTurn = false;
            }
            checkWin();
        }

        private void square8_Click(object sender, EventArgs e)
        {
            if (playerTurn == false)
            {
                positions[7] = "X";
                square8.Text = "X";
                square8.Enabled = false;
                playerTurn = true;
            }
            else if (playerTurn == true)
            {
                positions[7] = "O";
                square8.Text = "O";
                square8.Enabled = false;
                playerTurn = false;
            }
            checkWin();
        }

        private void square9_Click(object sender, EventArgs e)
        {
            if (playerTurn == false)
            {
                positions[8] = "X";
                square9.Text = "X";
                square9.Enabled = false;
                playerTurn = true;
            }
            else if (playerTurn == true)
            {
                positions[8] = "O";
                square9.Text = "O";
                square9.Enabled = false;
                playerTurn = false;
            }
            checkWin();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Luty
{
    public partial class Form1 : Form
    {
        enum Winner
        {
            xPlayer = -1,
            non = 0,
            oPlayer = 1
        }
        Winner winner = Winner.non;
        bool turn = false; //X = False, O = true
        bool gameFinished = false;
        int[,] board = new int[3, 3];
        int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Lukasz, TicTacToe2020", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to quit the game?", "TicTacToe", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes)
                Application.Exit();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (turn)
            {
                button.Text = "O";
            }
            else
            {
                button.Text = "X";
                int tagValue = int.Parse(button.Tag.ToString());
                tagValue *= -1;
                button.Tag = tagValue.ToString();

            }
            turn = !turn;
            button.Enabled = false;
            turnCount++;
            mapToTable(int.Parse(button.Tag.ToString()));

            if (turnCount > 4)
                checkWinner();

            if (turnCount == 9)
            {
                gameFinished = true;
            }

        }

        void checkWinner()
        {
            int sum_rows = 0;
            int sum_columns = 0;
            //rows check
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum_rows += board[i, j];
                    sum_columns += board[j, i];
                }
                if (sum_rows == 15 || sum_columns == 15)
                { 
                    winner = Winner.oPlayer;
                    gameFinished = true;
                }
                else if (sum_rows == -15 || sum_columns == -15)
                {
                    winner = Winner.xPlayer;
                    gameFinished = true;
                }
                sum_rows = 0;
                sum_columns = 0;
            }
            //diagonal check
            if (board[0, 0] + board[1, 1] + board[2, 2] == 15 || board[0, 2] + board[1, 1] + board[2, 0] == 15)
            {
                winner = Winner.oPlayer;
                gameFinished = true;
            }
            else if (board[0, 0] + board[1, 1] + board[2, 2] == -15 || board[0, 2] + board[1, 1] + board[2, 0] == -15)
            {
                winner = Winner.xPlayer;
                gameFinished = true;
            }

            if (gameFinished)
            {
                DialogResult d;
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.Enabled = false;
                }
                if (winner == Winner.xPlayer)
                {
                    d = MessageBox.Show("X won.\nDo you want to restart?", "Game finished", MessageBoxButtons.YesNo);
                }
                else if (winner == Winner.oPlayer)
                {
                    d = MessageBox.Show("O won.\nDo you want to restart?", "Game finished", MessageBoxButtons.YesNo);
                }
                else
                {
                    d = MessageBox.Show("Draw.\nDo you want to restart?", "Game finished", MessageBoxButtons.YesNo);
                }
                if (d == DialogResult.Yes)
                {
                    restart();
                }
            }

        }
        void restart()
        {
            gameFinished = false;
            turnCount = 0;
            winner = Winner.non;
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Text = "";
                button.Enabled = true;
                button.Tag = Math.Abs(int.Parse(button.Tag.ToString())).ToString();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }
        }
   

        void mapToTable(int tag)
        {
            switch (Math.Abs(tag))
            {
                case 1:
                    {
                        board[1, 2] = tag;
                        break;
                    }
                case 2:
                    {
                        board[0, 0] = tag;
                        break;
                    }
                case 3:
                    {
                        board[2, 1] = tag;
                        break;
                    }
                case 4:
                    {
                        board[2, 0] = tag;
                        break;
                    }
                case 5:
                    {
                        board[1, 1] = tag;
                        break;
                    }
                case 6:
                    {
                        board[0, 2] = tag;
                        break;
                    }
                case 7:
                    {
                        board[0, 1] = tag;
                        break;
                    }
                case 8:
                    {
                        board[2, 2] = tag;
                        break;

                    }
                case 9:
                    {
                        board[1, 0] = tag;
                        break;
                    }
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restart();
        }
    }
}

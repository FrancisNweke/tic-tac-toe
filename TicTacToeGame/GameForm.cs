using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class GameForm : Form
    {
        int count = 0;
        int playerOne = 0;
        int playerTwo = 0;

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            playerOneScore.Text = "0";
            playerTwoScore.Text = "0";
        }

        private void RestartGame()
        {
            DialogResult result = MessageBox.Show("Play Again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                count = 0;
                button1.Text = "";
                button1.BackColor = Color.WhiteSmoke;
                button2.Text = "";
                button2.BackColor = Color.WhiteSmoke;
                button3.Text = "";
                button3.BackColor = Color.WhiteSmoke;
                button4.Text = "";
                button4.BackColor = Color.WhiteSmoke;
                button5.Text = "";
                button5.BackColor = Color.WhiteSmoke;
                button6.Text = "";
                button6.BackColor = Color.WhiteSmoke;
                button7.Text = "";
                button7.BackColor = Color.WhiteSmoke;
                button8.Text = "";
                button8.BackColor = Color.WhiteSmoke;
                button9.Text = "";
                button9.BackColor = Color.WhiteSmoke;
            }
            else if (result == DialogResult.No)
            {
                btnExit.PerformClick();
            }
        }

        private void CheckDraw()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("No winner", "", MessageBoxButtons.RetryCancel);
                if (dialogResult == DialogResult.Retry)
                {
                    count = 0;
                    button1.Text = "";
                    button1.BackColor = Color.WhiteSmoke;
                    button2.Text = "";
                    button2.BackColor = Color.WhiteSmoke;
                    button3.Text = "";
                    button3.BackColor = Color.WhiteSmoke;
                    button4.Text = "";
                    button4.BackColor = Color.WhiteSmoke;
                    button5.Text = "";
                    button5.BackColor = Color.WhiteSmoke;
                    button6.Text = "";
                    button6.BackColor = Color.WhiteSmoke;
                    button7.Text = "";
                    button7.BackColor = Color.WhiteSmoke;
                    button8.Text = "";
                    button8.BackColor = Color.WhiteSmoke;
                    button9.Text = "";
                    button9.BackColor = Color.WhiteSmoke;
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    int totalGamePlayed = playerOne + playerTwo;
                    MessageBox.Show(totalGamePlayed + " wins, X won " + playerOne + " while O won " + playerTwo);
                }
            }           
        }

        private void CheckWinner(string symbol)
        {
            if (button1.Text == symbol && button2.Text == symbol && button3.Text == symbol)
            {
                button1.BackColor = Color.Chartreuse;
                button2.BackColor = Color.Chartreuse;
                button3.BackColor = Color.Chartreuse;
                if (symbol == "X")
                {
                    MessageBox.Show("Player 1 Won the Game");
                    playerOne++;
                    playerOneScore.Text = playerOne.ToString();
                }
                else if (symbol == "O")
                {
                    MessageBox.Show("Player 2 Won the Game");
                    playerTwo++;
                    playerTwoScore.Text = playerTwo.ToString();
                }
                RestartGame();
            }
            else if (button4.Text == symbol && button5.Text == symbol && button6.Text == symbol)
            {           
                button4.BackColor = Color.Chartreuse;
                button5.BackColor = Color.Chartreuse;
                button6.BackColor = Color.Chartreuse;
                if (symbol == "X")
                {
                    MessageBox.Show("Player 1 Won the Game");
                    playerOne++;
                    playerOneScore.Text = playerOne.ToString();
                }
                else if (symbol == "O")
                {
                    MessageBox.Show("Player 2 Won the Game");
                    playerTwo++;
                    playerTwoScore.Text = playerTwo.ToString();
                }
                RestartGame();
            }
            else if (button7.Text == symbol && button8.Text == symbol && button9.Text == symbol)
            {               
                button7.BackColor = Color.Chartreuse;
                button8.BackColor = Color.Chartreuse;
                button9.BackColor = Color.Chartreuse;
                if (symbol == "X")
                {
                    MessageBox.Show("Player 1 Won the Game");
                    playerOne++;
                    playerOneScore.Text = playerOne.ToString();
                }
                else if (symbol == "O")
                {
                    MessageBox.Show("Player 2 Won the Game");
                    playerTwo++;
                    playerTwoScore.Text = playerTwo.ToString();
                }
                RestartGame();
            }
            else if (button1.Text == symbol && button4.Text == symbol && button7.Text == symbol)
            {
                button1.BackColor = Color.Chartreuse;
                button4.BackColor = Color.Chartreuse;
                button7.BackColor = Color.Chartreuse;
                if (symbol == "X")
                {
                    MessageBox.Show("Player 1 Won the Game");
                    playerOne++;
                    playerOneScore.Text = playerOne.ToString();
                }
                else if (symbol == "O")
                {
                    MessageBox.Show("Player 2 Won the Game");
                    playerTwo++;
                    playerTwoScore.Text = playerTwo.ToString();
                }
                RestartGame();
            }
            else if (button2.Text == symbol && button5.Text == symbol && button8.Text == symbol)
            {                
                button2.BackColor = Color.Chartreuse;
                button5.BackColor = Color.Chartreuse;
                button8.BackColor = Color.Chartreuse;
                if (symbol == "X")
                {
                    MessageBox.Show("Player 1 Won the Game");
                    playerOne++;
                    playerOneScore.Text = playerOne.ToString();                   
                }
                else if (symbol == "O")
                {
                    MessageBox.Show("Player 2 Won the Game");
                    playerTwo++;
                    playerTwoScore.Text = playerTwo.ToString();
                }
                RestartGame();
            }
            else if (button3.Text == symbol && button6.Text == symbol && button9.Text == symbol)
            {
                button3.BackColor = Color.Chartreuse;
                button6.BackColor = Color.Chartreuse;
                button9.BackColor = Color.Chartreuse;
                if (symbol == "X")
                {
                    MessageBox.Show("Player 1 Won the Game");
                    playerOne++;
                    playerOneScore.Text = playerOne.ToString();
                }
                else if (symbol == "O")
                {
                    MessageBox.Show("Player 2 Won the Game");
                    playerTwo++;
                    playerTwoScore.Text = playerTwo.ToString();
                }
                RestartGame();
            }
            else if (button1.Text == symbol && button5.Text == symbol && button9.Text == symbol)
            {
                button1.BackColor = Color.Chartreuse;
                button5.BackColor = Color.Chartreuse;
                button9.BackColor = Color.Chartreuse;
                if (symbol == "X")
                {
                    MessageBox.Show("Player 1 Won the Game");
                    playerOne++;
                    playerOneScore.Text = playerOne.ToString();
                }
                else if (symbol == "O")
                {
                    MessageBox.Show("Player 2 Won the Game");
                    playerTwo++;
                    playerTwoScore.Text = playerTwo.ToString();
                }
                RestartGame();
            }
            else if (button3.Text == symbol && button5.Text == symbol && button7.Text == symbol)
            {
                button3.BackColor = Color.Chartreuse;
                button5.BackColor = Color.Chartreuse;
                button7.BackColor = Color.Chartreuse;
                if (symbol == "X")
                {
                    MessageBox.Show("Player 1 Won the Game");
                    playerOne++;
                    playerOneScore.Text = playerOne.ToString();
                }
                else if (symbol == "O")
                {
                    MessageBox.Show("Player 2 Won the Game");
                    playerTwo++;
                    playerTwoScore.Text = playerTwo.ToString();
                }
                RestartGame();
            }  
        }

        private void BtnPlayer(object senderObj)
        {
            string buttonTxt = ((Button)senderObj).Text;
            if (buttonTxt == "")
            {
                if (count % 2 == 0)
                {
                    ((Button)senderObj).ForeColor = Color.DarkBlue;
                    ((Button)senderObj).Text = "X";
                } else
                {
                    ((Button)senderObj).ForeColor = Color.Red;
                    ((Button)senderObj).Text = "O";
                }
                count++;
                CheckWinner("X");
                CheckWinner("O");
            }
            else
            {
                MessageBox.Show("Invalid Click", "",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnPlayer(sender);
            CheckDraw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtnPlayer(sender);
            CheckDraw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BtnPlayer(sender);
            CheckDraw();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BtnPlayer(sender);
            CheckDraw();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BtnPlayer(sender);
            CheckDraw();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BtnPlayer(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BtnPlayer(sender);
            CheckDraw();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BtnPlayer(sender);
            CheckDraw();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BtnPlayer(sender);
            CheckDraw();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.026;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you wish to reset game?", "", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                count = 0;
                button1.Text = "";
                playerOneScore.Text = "";
                playerTwoScore.Text = "";
                button1.BackColor = Color.WhiteSmoke;
                button2.Text = "";
                button2.BackColor = Color.WhiteSmoke;
                button3.Text = "";
                button3.BackColor = Color.WhiteSmoke;
                button4.Text = "";
                button4.BackColor = Color.WhiteSmoke;
                button5.Text = "";
                button5.BackColor = Color.WhiteSmoke;
                button6.Text = "";
                button6.BackColor = Color.WhiteSmoke;
                button7.Text = "";
                button7.BackColor = Color.WhiteSmoke;
                button8.Text = "";
                button8.BackColor = Color.WhiteSmoke;
                button9.Text = "";
                button9.BackColor = Color.WhiteSmoke;
            }            
        }       
    }
}

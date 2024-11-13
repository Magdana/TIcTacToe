using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace TIcTacToe
{
    public partial class TicTacToeForm : Form
    {
        public TicTacToeForm()
        {
            InitializeComponent();

            button2.Click += Btn_Click;
            button3.Click += Btn_Click;
            button4.Click += Btn_Click;
            button5.Click += Btn_Click;
            button6.Click += Btn_Click;
            button7.Click += Btn_Click;
            button8.Click += Btn_Click;
            button9.Click += Btn_Click;
            button10.Click += Btn_Click;

        }

        private bool isXTurn = true;
        private bool gameEnded = false;

        private void Btn_Click(object sender, EventArgs e)
        {
            if (gameEnded) return;
            Button clickedButton = sender as Button;

            if (clickedButton != null && string.IsNullOrEmpty(clickedButton.Text))
            {
                clickedButton.Text = isXTurn ? "X" : "O";
                isXTurn = !isXTurn;

                CheckForWinner();
            }
        }

        private void CheckForWinner()
        {
            string[,] box = new string[,]
   {
        { button2.Text, button3.Text, button4.Text },
        { button5.Text, button6.Text, button7.Text },
        { button8.Text, button9.Text, button10.Text }
   };

            if (CheckThree(box[0, 0], box[0, 1], box[0, 2]) ||
                CheckThree(box[1, 0], box[1, 1], box[1, 2]) ||
                CheckThree(box[2, 0], box[2, 1], box[2, 2]) ||
                CheckThree(box[0, 0], box[1, 0], box[2, 0]) ||
                CheckThree(box[0, 1], box[1, 1], box[2, 1]) ||
                CheckThree(box[0, 2], box[1, 2], box[2, 2]) ||
                CheckThree(box[0, 0], box[1, 1], box[2, 2]) ||
                CheckThree(box[0, 2], box[1, 1], box[2, 0]))
            {
                gameEnded = true;
                string winner = isXTurn ? "O" : "X";
                winnerLable.Text = $"The winner is: {winner}";
            }
            else if (AllCellsFilled(box))
            {
                winnerLable.Text = "There is not a winner";
            }
        }

        private bool AllCellsFilled(string[,] box)
        {
            foreach (string cell in box)
            {
                if (string.IsNullOrEmpty(cell))
                    return false;
            }
            return true;
        }
        private bool CheckThree(string a, string b, string c)
        {
            return !string.IsNullOrEmpty(a) && a == b && b == c;
        }


        private void ResetGame()
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control.Name.StartsWith("button"))
                {
                    control.Text = "";
                }
            }
            isXTurn = true;
            winnerLable.Text = "";
            gameEnded = false;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}

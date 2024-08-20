using System;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        private bool isPlayerXTurn;
        private Button[,] buttons;

        public Form1()
        {
            InitializeComponent();
            isPlayerXTurn = true;
            buttons = new Button[3, 3]
            {
                { btn00, btn01, btn02 },
                { btn10, btn11, btn12 },
                { btn20, btn21, btn22 }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập trạng thái ban đầu khi Form được tải
            lblStatus.Text = "Player X's Turn";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text == "")
            {
                if (isPlayerXTurn)
                {
                    button.Text = "X";
                    lblStatus.Text = "Player O's Turn";
                }
                else
                {
                    button.Text = "O";
                    lblStatus.Text = "Player X's Turn";
                }

                isPlayerXTurn = !isPlayerXTurn;
                CheckForWinner();
            }
        }

        private void CheckForWinner()
        {
            string winner = "";
            // Kiểm tra hàng
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i, 0].Text != "" &&
                    buttons[i, 0].Text == buttons[i, 1].Text &&
                    buttons[i, 1].Text == buttons[i, 2].Text)
                {
                    winner = buttons[i, 0].Text;
                    break;
                }
            }

            // Kiểm tra cột
            for (int i = 0; i < 3; i++)
            {
                if (buttons[0, i].Text != "" &&
                    buttons[0, i].Text == buttons[1, i].Text &&
                    buttons[1, i].Text == buttons[2, i].Text)
                {
                    winner = buttons[0, i].Text;
                    break;
                }
            }

            // Kiểm tra đường chéo
            if (buttons[0, 0].Text != "" &&
                buttons[0, 0].Text == buttons[1, 1].Text &&
                buttons[1, 1].Text == buttons[2, 2].Text)
            {
                winner = buttons[0, 0].Text;
            }

            if (buttons[0, 2].Text != "" &&
                buttons[0, 2].Text == buttons[1, 1].Text &&
                buttons[1, 1].Text == buttons[2, 0].Text)
            {
                winner = buttons[0, 2].Text;
            }

            if (winner != "")
            {
                lblStatus.Text = $"Player {winner} Wins!";
                DisableButtons();
                return;
            }

            // Kiểm tra hòa
            bool isDraw = true;
            foreach (Button button in buttons)
            {
                if (button.Text == "")
                {
                    isDraw = false;
                    break;
                }
            }

            if (isDraw)
            {
                lblStatus.Text = "It's a Draw!";
            }
        }

        private void DisableButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Reset game
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }
            isPlayerXTurn = true;
            lblStatus.Text = "Player X's Turn";
        }
    }
}
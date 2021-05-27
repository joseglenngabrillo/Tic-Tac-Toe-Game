using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        bool turn = true; // where False = Y turn; True = X turn
        int turn_count = 0; // count the number to turn

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            LineCheckPlayerWinner();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            btnC1R1.Enabled = true;
            btnC2R1.Enabled = true;
            btnC3R1.Enabled = true;
            btnC1R2.Enabled = true;
            btnC2R2.Enabled = true;
            btnC3R2.Enabled = true;
            btnC1R3.Enabled = true;
            btnC2R3.Enabled = true;
            btnC3R3.Enabled = true;

            btnC1R1.Text = "";
            btnC2R1.Text = "";
            btnC3R1.Text = "";
            btnC1R2.Text = "";
            btnC2R2.Text = "";
            btnC3R2.Text = "";
            btnC1R3.Text = "";
            btnC2R3.Text = "";
            btnC3R3.Text = "";
        }
        private void LineCheckPlayerWinner()
        {
            bool PlayerWinner = false;

            // Player Winner with horizontal line checks
            // First horizontal line check from column 1 to 3 in Row 1
            if ((btnC1R1.Text == btnC2R1.Text) && (btnC2R1.Text == btnC3R1.Text) && (!btnC1R1.Enabled))
                PlayerWinner = true;
            // Second horizontal line check from column 1 to 3 in Row 2
            else if ((btnC1R2.Text == btnC2R2.Text) && (btnC2R2.Text == btnC3R2.Text) && (!btnC1R2.Enabled))
                PlayerWinner = true;
            // Third horizontal line check from column 1 to 3 in Row 3
            else if ((btnC1R3.Text == btnC2R3.Text) && (btnC2R3.Text == btnC3R3.Text) && (!btnC1R3.Enabled))
                PlayerWinner = true;

            // Player Winner with vertical line checks
            // First vertical line check from row 1 to 3 in column 1
            else if ((btnC1R1.Text == btnC1R2.Text) && (btnC1R2.Text == btnC1R3.Text) && (!btnC1R1.Enabled))
                PlayerWinner = true;
            // Second vertical line check from row 1 to 3 in column 2
            else if ((btnC2R1.Text == btnC2R2.Text) && (btnC2R2.Text == btnC2R3.Text) && (!btnC2R1.Enabled))
                PlayerWinner = true;
            // Third vertical line check from row 1 to 3 in column 3
            else if ((btnC3R1.Text == btnC3R2.Text) && (btnC3R2.Text == btnC3R3.Text) && (!btnC3R1.Enabled))
                PlayerWinner = true;

            // Player Winner with diagonal line checks
            // First diagonal line check from column 1 row 1, column 2 row 2 and column 3 row 3
            else if ((btnC1R1.Text == btnC2R2.Text) && (btnC2R2.Text == btnC3R3.Text) && (!btnC1R1.Enabled))
                PlayerWinner = true;
            // Second diagonal line check from column 3 row 1, column 2 row 2 and column 1 row 3
            else if ((btnC3R1.Text == btnC2R2.Text) && (btnC2R2.Text == btnC1R3.Text) && (!btnC3R1.Enabled))
                PlayerWinner = true;

            if (PlayerWinner)
            {
                string winner = "";
            }
            }
        }
}


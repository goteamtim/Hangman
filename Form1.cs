/*
 * Written by Tim Harshman
 * 1-23-14
 * This is a hangman game.  The object of the game is to guess all of the letters of the word before the man gets hung.
 * Each incorrect guess generates another piece of the man.  If you guess the word before all of the man is complete
 * then you win the game.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Random;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Hide all of the hanging man
            left_Arm.Visible = false;
            right_Arm.Visible = false;
            left_leg.Visible = false;
            right_leg.Visible = false;
            body.Visible = false;
            head.Visible = false;
            Random choice = new Random();

            string[] wordBank = { "Packmule", "Pie", "Marathon","Internet","Pumpkin","Christmas","Bicycle","Teacher" };
            string winningWord = wordBank[choice.Next(0, wordBank.Length)];//Pick a random word from the word bank
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            btn_B.Enabled = false;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            btn_C.Enabled = false;
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            btn_D.Enabled = false;
             
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            btn_E.Enabled = false;
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            btn_F.Enabled = false;
        }

        private void btn_G_Click(object sender, EventArgs e)
        {
            btn_G.Enabled = false;
        }

        private void btn_H_Click(object sender, EventArgs e)
        {
            btn_H.Enabled = false;
        }

        private void btn_I_Click(object sender, EventArgs e)
        {
            btn_I.Enabled = false;
        }

        private void btn_J_Click(object sender, EventArgs e)
        {
            btn_J.Enabled = false;
        }

        private void btn_K_Click(object sender, EventArgs e)
        {
            btn_K.Enabled = false;
        }

        private void btn_L_Click(object sender, EventArgs e)
        {
            btn_L.Enabled = false;
        }

        private void btn_M_Click(object sender, EventArgs e)
        {
            btn_M.Enabled = false;
        }

        private void btn_N_Click(object sender, EventArgs e)
        {
            btn_N.Enabled = false;
        }

        private void btn_O_Click(object sender, EventArgs e)
        {
            btn_O.Enabled = false;
        }

        private void btn_P_Click(object sender, EventArgs e)
        {
            btn_P.Enabled = false;
        }

        private void btn_Q_Click(object sender, EventArgs e)
        {
            btn_Q.Enabled = false;
        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            btn_R.Enabled = false;
        }

        private void btn_S_Click(object sender, EventArgs e)
        {
            btn_S.Enabled = false;
        }

        private void btn_T_Click(object sender, EventArgs e)
        {
            btn_T.Enabled = false;
        }

        private void btn_U_Click(object sender, EventArgs e)
        {
            btn_U.Enabled = false;
        }

        private void btn_V_Click(object sender, EventArgs e)
        {
            btn_V.Enabled = false;
        }

        private void btn_W_Click(object sender, EventArgs e)
        {
            btn_W.Enabled = false;
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            btn_X.Enabled = false;
        }

        private void btn_Y_Click(object sender, EventArgs e)
        {
            btn_Y.Enabled = false;
        }

        private void btn_Z_Click(object sender, EventArgs e)
        {
            btn_Z.Enabled = false;
        }
    }
}

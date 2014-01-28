﻿/*
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

namespace Hangman
{

    public partial class Form1 : Form
    {
        static Random choice = new Random();//new instance of the random class
        public static string[] wordBank = { "packmule", "pie", "marathon", "internet", "pumpkin", "christmas", "bicycle", "teacher" };//wordbank
        public string winningWord = wordBank[choice.Next(0, wordBank.Length)];//Pick a random word from the word bank
        
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
            TextBox[] letters = new TextBox[10] { txt_bx_1, txt_bx_2, txt_bx_3, txt_bx_4, txt_bx_5, txt_bx_6, txt_bx_7, txt_bx_8, txt_bx_9, txt_bx_10 };//array of all the text boxes in the game.  Right now there are only 10 text boxes which means only 10 letters can be in a word
            for (int i = 0; i < winningWord.Length;i++ )//loop through the selected word and show a text box for each letter in the word
            {
                letters[i].Visible = true;
            }
        }

        public void chosenLetter(char choice, string word)//letter gets passed and compared to the winning word if its in the word it gets added in the text box
        {
            
            TextBox[] letters = new TextBox[10] { txt_bx_1, txt_bx_2, txt_bx_3, txt_bx_4, txt_bx_5, txt_bx_6, txt_bx_7, txt_bx_8, txt_bx_9, txt_bx_10 };//all the text boxes
            for (int i = 0; i < word.Length; i++) 
            {
                if (choice == word[i])//If the passed letter is in the word then execute
                {
                    letters[i].Text = choice.ToString();
                    break;//I am not sure why I need two breaks here.  Is it one to get out of the if/else and one for the for?
                    break;//Either way it seems to be working.  Maybe it works with one?
                }
                else//The idea here is if the letter is not in the word then execute adding the next body part to the hanging man
                {
                    bodyBuilder();
                }
            }
            
        }

        public void bodyBuilder()//function to add the next available body part to the hanging man
        {
            //int a = 9;//working on the right loop/logic to check if the body part is already being shown
            for (int i = 0; i < 7; i++)
            {
                if (head.Visible != true)
                {
                    head.Visible = true;
                    //a = 11;
                    break;
                    //break;
                }
                else if (body.Visible == false)
                {
                    body.Visible = true;
                    //a = 11;
                    break;
                }
            }


        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            chosenLetter('a',winningWord);
            //bodyBuilder();
            
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            btn_B.Enabled = false;
            chosenLetter('b', winningWord);
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            btn_C.Enabled = false;
            chosenLetter('c', winningWord);
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            btn_D.Enabled = false;
            chosenLetter('d', winningWord);
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            btn_E.Enabled = false;
            chosenLetter('e', winningWord);
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            btn_F.Enabled = false;
            chosenLetter('f', winningWord);
        }

        private void btn_G_Click(object sender, EventArgs e)
        {
            btn_G.Enabled = false;
            chosenLetter('g', winningWord);
        }

        private void btn_H_Click(object sender, EventArgs e)
        {
            btn_H.Enabled = false;
            chosenLetter('h', winningWord);
        }

        private void btn_I_Click(object sender, EventArgs e)
        {
            btn_I.Enabled = false;
            chosenLetter('i', winningWord);
        }

        private void btn_J_Click(object sender, EventArgs e)
        {
            btn_J.Enabled = false;
            chosenLetter('j', winningWord);
        }

        private void btn_K_Click(object sender, EventArgs e)
        {
            btn_K.Enabled = false;
            chosenLetter('k', winningWord);
        }

        private void btn_L_Click(object sender, EventArgs e)
        {
            btn_L.Enabled = false;
            chosenLetter('l', winningWord);
        }

        private void btn_M_Click(object sender, EventArgs e)
        {
            btn_M.Enabled = false;
            chosenLetter('m', winningWord);
        }

        private void btn_N_Click(object sender, EventArgs e)
        {
            btn_N.Enabled = false;
            chosenLetter('n', winningWord);
        }

        private void btn_O_Click(object sender, EventArgs e)
        {
            btn_O.Enabled = false;
            chosenLetter('o', winningWord);
        }

        private void btn_P_Click(object sender, EventArgs e)
        {
            btn_P.Enabled = false;
            chosenLetter('p', winningWord);
        }

        private void btn_Q_Click(object sender, EventArgs e)
        {
            btn_Q.Enabled = false;
            chosenLetter('q', winningWord);
        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            btn_R.Enabled = false;
            chosenLetter('r', winningWord);
        }

        private void btn_S_Click(object sender, EventArgs e)
        {
            btn_S.Enabled = false;
            chosenLetter('s', winningWord);
        }

        private void btn_T_Click(object sender, EventArgs e)
        {
            btn_T.Enabled = false;
            chosenLetter('t', winningWord);
        }

        private void btn_U_Click(object sender, EventArgs e)
        {
            btn_U.Enabled = false;
            chosenLetter('u', winningWord);
        }

        private void btn_V_Click(object sender, EventArgs e)
        {
            btn_V.Enabled = false;
            chosenLetter('v', winningWord);
        }

        private void btn_W_Click(object sender, EventArgs e)
        {
            btn_W.Enabled = false;
            chosenLetter('w', winningWord);
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            btn_X.Enabled = false;
            chosenLetter('x', winningWord);
        }

        private void btn_Y_Click(object sender, EventArgs e)
        {
            btn_Y.Enabled = false;
            chosenLetter('y', winningWord);
        }

        private void btn_Z_Click(object sender, EventArgs e)
        {
            btn_Z.Enabled = false;
            chosenLetter('z', winningWord);
        }
    }
}

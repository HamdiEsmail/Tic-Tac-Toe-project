using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_project.Properties;

namespace Tic_Tac_Toe_project
{
    public partial class Form1 : Form
    {
        char CurrUser = '1';
        string[,] AllChoices = new string[3, 3];


        public Form1()
        {
            InitializeComponent();
            RenameLabTurn();


        }
        void RenameLabTurn()
        {
            if (CurrUser == '1')
            {
                labTurn.Text = "Player1";
            }
            else
            {

                labTurn.Text = "Player2";

            }
        }
        bool HandleCellClick(object sender)
        {
            if (!(((PictureBox)sender).Tag.ToString() == "?"))
            {
                MessageBox.Show("This place is already taken!", "Error");
                return false;
            }
            else if (CurrUser == '1')
            {

                ((PictureBox)sender).Tag = "Player1"; //set new tag to use it in diff cases
                ((PictureBox)sender).Image = Resources.This_is_X; //set X in his side 
                CurrUser = '2'; //shift to user 2 


            }
            else
            {

                ((PictureBox)sender).Tag = "Player2";
                ((PictureBox)sender).Image = Resources.This_is_O;
                CurrUser = '1';

            }
            return true;

        }

        string IsThereAWinner()
        {
            //for horizantal 


            for (byte i = 0; i < 3; i++)
            {
                if (AllChoices[i, 0] != null && AllChoices[i, 0] == AllChoices[i, 1] && AllChoices[i, 1] == AllChoices[i, 2]) return AllChoices[i, 0];
            }

            //for vertical 


            for (byte i = 0; i < 3; i++)
            {
                if (AllChoices[0, i] != null && AllChoices[0, i] == AllChoices[1, i] && AllChoices[1, i] == AllChoices[2, i]) return AllChoices[0, i];


            }

            //for digonal
            if (AllChoices[0, 0] != null && AllChoices[0, 0] == AllChoices[1, 1] && AllChoices[1, 1] == AllChoices[2, 2]) return AllChoices[0, 0];
            if (AllChoices[0, 2] != null && AllChoices[0, 2] == AllChoices[1, 1] && AllChoices[1, 1] == AllChoices[2, 0]) return AllChoices[0, 2];

            return null;

        }

        bool isFull()
        {
            foreach (string temp in AllChoices)
            {
                if (temp == default) return false;

            }
            return true;

        }
        void EndTheGame()
        {
            string Winner = IsThereAWinner();
            if (Winner != null)
            {
                labWinner.Text = Winner;
                MessageBox.Show("There is a winner", "Game End!!");
                panel1.Enabled = false;

            }
            else if (isFull())
            {
                labWinner.Text = "Draw";
                MessageBox.Show("There is no winner", "Game End!!");
                panel1.Enabled = false;

            }


        }

        void Restart()
        {
            AllChoices = new string[3, 3];
            panel1.Enabled = true;
            CurrUser = '1';
            pB1.Tag = "?";
            pB2.Tag = "?";
            pB3.Tag = "?";
            pB4.Tag = "?";
            pB5.Tag = "?";
            pB6.Tag = "?";
            pB7.Tag = "?";
            pB8.Tag = "?";
            pB9.Tag = "?";
            labWinner.Text = "In Progress";
            pB1.Image = Resources.استفهام_;
            pB2.Image = Resources.استفهام_;
            pB3.Image = Resources.استفهام_;
            pB4.Image = Resources.استفهام_;
            pB5.Image = Resources.استفهام_;
            pB6.Image = Resources.استفهام_;
            pB7.Image = Resources.استفهام_;
            pB8.Image = Resources.استفهام_;
            pB9.Image = Resources.استفهام_;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pB1_Click(object sender, EventArgs e)
        {
            if (HandleCellClick(sender))
            {
                RenameLabTurn();
                AllChoices[0, 0] = pB1.Tag.ToString();
                EndTheGame();


            }
        }

        private void pB2_Click(object sender, EventArgs e)
        {
            if (HandleCellClick(sender))
            {
                RenameLabTurn();
                AllChoices[0, 1] = pB2.Tag.ToString();
                EndTheGame();


            }
        }

        private void pB3_Click(object sender, EventArgs e)
        {
            if (HandleCellClick(sender))
            {
                RenameLabTurn();
                AllChoices[0, 2] = pB3.Tag.ToString();
                EndTheGame();


            }
        }

        private void pB4_Click(object sender, EventArgs e)
        {
            if (HandleCellClick(sender))
            {
                RenameLabTurn();
                AllChoices[1, 0] = pB4.Tag.ToString();
                EndTheGame();


            }
        }

        private void pB5_Click(object sender, EventArgs e)
        {
            if (HandleCellClick(sender))
            {
                RenameLabTurn();
                AllChoices[1, 1] = pB5.Tag.ToString();
                EndTheGame();


            }
        }

        private void pB6_Click(object sender, EventArgs e)
        {
            if (HandleCellClick(sender))
            {
                RenameLabTurn();
                AllChoices[1, 2] = pB6.Tag.ToString();
                EndTheGame();


            }
        }

        private void pB7_Click(object sender, EventArgs e)
        {
            if (HandleCellClick(sender))
            {
                RenameLabTurn();
                AllChoices[2, 0] = pB7.Tag.ToString();
                EndTheGame();


            }
        }

        private void pB8_Click(object sender, EventArgs e)
        {
            if (HandleCellClick(sender))
            {
                RenameLabTurn();
                AllChoices[2, 1] = pB8.Tag.ToString();
                EndTheGame();


            }
        }

        private void pB9_Click(object sender, EventArgs e)
        {
            if (HandleCellClick(sender))
            {
                RenameLabTurn();
                AllChoices[2, 2] = pB9.Tag.ToString();
                EndTheGame();


            }

        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            Restart();
            RenameLabTurn();

        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessingGame
{
    public partial class frmWordGuessingGame : Form
    {
        public frmWordGuessingGame()
        {
            InitializeComponent();
        }
        private string GuessWord; 
        private void Form1_Load(object sender, EventArgs e)
        {
            GuessWord = "computer";

            StringBuilder maskedVersion = new StringBuilder();
            maskedVersion.Append(GuessWord[0]);
            maskedVersion.Append(new string('?', GuessWord.Length - 2));
            maskedVersion.Append(GuessWord[GuessWord.Length - 1]);
            WordToGuess.Text = maskedVersion.ToString();
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            string playerGuess = GuessBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(playerGuess))
            {
                MessageBox.Show("Please enter a guess!", "Missing Input");
                GuessBox.Focus();
                return;
            }
            if (playerGuess.Equals(GuessWord, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Correct guess!", "Success");
                WordToGuess.Text = GuessWord;
                GuessButton.Enabled = false;
            }
            else
            {
                WrongGuessList.Items.Add(playerGuess);
                MessageBox.Show("Wrong guess!\nTry again.", "Incorrect");

                GuessBox.Clear();
                GuessBox.Focus();
            }
        }
    }
}

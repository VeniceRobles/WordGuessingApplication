namespace WordGuessingGame
{
    partial class frmWordGuessingGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WordToGuess = new System.Windows.Forms.Label();
            this.GuessBox = new System.Windows.Forms.TextBox();
            this.GuessButton = new System.Windows.Forms.Button();
            this.WrongGuessList = new System.Windows.Forms.ListBox();
            this.WrongGuessLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WordToGuess
            // 
            this.WordToGuess.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.WordToGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WordToGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordToGuess.ForeColor = System.Drawing.Color.White;
            this.WordToGuess.Location = new System.Drawing.Point(12, 9);
            this.WordToGuess.Name = "WordToGuess";
            this.WordToGuess.Size = new System.Drawing.Size(432, 89);
            this.WordToGuess.TabIndex = 0;
            this.WordToGuess.Text = "computer";
            this.WordToGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuessBox
            // 
            this.GuessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessBox.Location = new System.Drawing.Point(79, 102);
            this.GuessBox.Name = "GuessBox";
            this.GuessBox.Size = new System.Drawing.Size(299, 34);
            this.GuessBox.TabIndex = 1;
            this.GuessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GuessButton
            // 
            this.GuessButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GuessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessButton.ForeColor = System.Drawing.Color.White;
            this.GuessButton.Location = new System.Drawing.Point(160, 142);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(142, 41);
            this.GuessButton.TabIndex = 2;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = false;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // WrongGuessList
            // 
            this.WrongGuessList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongGuessList.FormattingEnabled = true;
            this.WrongGuessList.ItemHeight = 20;
            this.WrongGuessList.Location = new System.Drawing.Point(450, 43);
            this.WrongGuessList.Name = "WrongGuessList";
            this.WrongGuessList.Size = new System.Drawing.Size(190, 144);
            this.WrongGuessList.TabIndex = 3;
            // 
            // WrongGuessLB
            // 
            this.WrongGuessLB.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.WrongGuessLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongGuessLB.ForeColor = System.Drawing.Color.White;
            this.WrongGuessLB.Location = new System.Drawing.Point(450, 9);
            this.WrongGuessLB.Name = "WrongGuessLB";
            this.WrongGuessLB.Size = new System.Drawing.Size(190, 31);
            this.WrongGuessLB.TabIndex = 4;
            this.WrongGuessLB.Text = "Wrong Guess";
            this.WrongGuessLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmWordGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 200);
            this.Controls.Add(this.WrongGuessLB);
            this.Controls.Add(this.WrongGuessList);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.GuessBox);
            this.Controls.Add(this.WordToGuess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmWordGuessingGame";
            this.Text = "Guess the Word";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WordToGuess;
        private System.Windows.Forms.TextBox GuessBox;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.ListBox WrongGuessList;
        private System.Windows.Forms.Label WrongGuessLB;
    }
}


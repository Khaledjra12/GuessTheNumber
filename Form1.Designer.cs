
namespace GuessTheNumber
{
    partial class Form1
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
            instructionsLabel = new Label();
            feedbackLabel = new Label();
            guessTextBox = new TextBox();
            newGameButton = new Button();
            instructionsLabel1 = new Label();
            SuspendLayout();
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            instructionsLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instructionsLabel.Location = new Point(43, 23);
            instructionsLabel.Margin = new Padding(4, 0, 4, 0);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(316, 20);
            instructionsLabel.TabIndex = 0;
            instructionsLabel.Text = "I have a number between 1 and 1000";
            // 
            // feedbackLabel
            // 
            feedbackLabel.AutoSize = true;
            feedbackLabel.Location = new Point(144, 115);
            feedbackLabel.Margin = new Padding(4, 0, 4, 0);
            feedbackLabel.Name = "feedbackLabel";
            feedbackLabel.Size = new Size(0, 20);
            feedbackLabel.TabIndex = 1;
            // 
            // guessTextBox
            // 
            guessTextBox.Location = new Point(124, 89);
            guessTextBox.Margin = new Padding(4);
            guessTextBox.Name = "guessTextBox";
            guessTextBox.Size = new Size(133, 26);
            guessTextBox.TabIndex = 2;
            guessTextBox.TextChanged += guessTextBox_TextChanged;
            // 
            // newGameButton
            // 
            newGameButton.Location = new Point(111, 166);
            newGameButton.Margin = new Padding(4);
            newGameButton.Name = "newGameButton";
            newGameButton.Size = new Size(156, 36);
            newGameButton.TabIndex = 3;
            newGameButton.Text = "New Game";
            newGameButton.UseVisualStyleBackColor = true;
            newGameButton.Click += newGameButton_Click;
            // 
            // instructionsLabel1
            // 
            instructionsLabel1.AutoSize = true;
            instructionsLabel1.Location = new Point(12, 48);
            instructionsLabel1.Name = "instructionsLabel1";
            instructionsLabel1.Size = new Size(454, 20);
            instructionsLabel1.TabIndex = 0;
            instructionsLabel1.Text = "can you guess my number? Please enter your guess:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 240);
            Controls.Add(instructionsLabel1);
            Controls.Add(newGameButton);
            Controls.Add(guessTextBox);
            Controls.Add(feedbackLabel);
            Controls.Add(instructionsLabel);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label instructionsLabel1;
    }
}

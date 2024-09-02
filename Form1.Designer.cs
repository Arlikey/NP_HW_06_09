namespace NP_HW_06_09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rollButton = new Button();
            dice1Button = new Button();
            dice2Button = new Button();
            label1 = new Label();
            playerVsPlayerButton = new Button();
            playerVsComputerButton = new Button();
            rulesButton = new Button();
            player1RollsList = new ListBox();
            player2RollsList = new ListBox();
            player1ScoreLabel = new Label();
            player2ScoreLabel = new Label();
            SuspendLayout();
            // 
            // rollButton
            // 
            rollButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rollButton.Location = new Point(355, 351);
            rollButton.Name = "rollButton";
            rollButton.Size = new Size(101, 42);
            rollButton.TabIndex = 2;
            rollButton.Text = "Roll";
            rollButton.UseVisualStyleBackColor = true;
            rollButton.Click += rollButton_Click;
            // 
            // dice1Button
            // 
            dice1Button.Enabled = false;
            dice1Button.FlatStyle = FlatStyle.Flat;
            dice1Button.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dice1Button.Location = new Point(266, 164);
            dice1Button.Name = "dice1Button";
            dice1Button.Size = new Size(75, 75);
            dice1Button.TabIndex = 3;
            dice1Button.UseVisualStyleBackColor = true;
            // 
            // dice2Button
            // 
            dice2Button.Enabled = false;
            dice2Button.FlatStyle = FlatStyle.Flat;
            dice2Button.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dice2Button.Location = new Point(486, 164);
            dice2Button.Name = "dice2Button";
            dice2Button.Size = new Size(75, 75);
            dice2Button.TabIndex = 4;
            dice2Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(288, 63);
            label1.Name = "label1";
            label1.Size = new Size(253, 32);
            label1.TabIndex = 5;
            label1.Text = "Choose game mode :";
            // 
            // playerVsPlayerButton
            // 
            playerVsPlayerButton.FlatStyle = FlatStyle.Flat;
            playerVsPlayerButton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            playerVsPlayerButton.Location = new Point(288, 146);
            playerVsPlayerButton.Name = "playerVsPlayerButton";
            playerVsPlayerButton.Size = new Size(237, 57);
            playerVsPlayerButton.TabIndex = 6;
            playerVsPlayerButton.Text = "Player vs Player";
            playerVsPlayerButton.UseVisualStyleBackColor = true;
            playerVsPlayerButton.Click += playerVsPlayerButton_Click;
            // 
            // playerVsComputerButton
            // 
            playerVsComputerButton.FlatStyle = FlatStyle.Flat;
            playerVsComputerButton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            playerVsComputerButton.Location = new Point(288, 245);
            playerVsComputerButton.Name = "playerVsComputerButton";
            playerVsComputerButton.Size = new Size(237, 57);
            playerVsComputerButton.TabIndex = 6;
            playerVsComputerButton.Text = "Player vs Computer";
            playerVsComputerButton.UseVisualStyleBackColor = true;
            playerVsComputerButton.Click += playerVsComputerButton_Click;
            // 
            // rulesButton
            // 
            rulesButton.BackgroundImage = Properties.Resources.book;
            rulesButton.BackgroundImageLayout = ImageLayout.Stretch;
            rulesButton.Cursor = Cursors.Help;
            rulesButton.FlatAppearance.BorderSize = 0;
            rulesButton.FlatStyle = FlatStyle.Flat;
            rulesButton.Location = new Point(728, 381);
            rulesButton.Name = "rulesButton";
            rulesButton.Size = new Size(60, 57);
            rulesButton.TabIndex = 7;
            rulesButton.UseVisualStyleBackColor = true;
            rulesButton.Click += rulesButton_Click;
            // 
            // player1RollsList
            // 
            player1RollsList.FormattingEnabled = true;
            player1RollsList.ItemHeight = 15;
            player1RollsList.Location = new Point(12, 63);
            player1RollsList.Name = "player1RollsList";
            player1RollsList.Size = new Size(142, 214);
            player1RollsList.TabIndex = 8;
            // 
            // player2RollsList
            // 
            player2RollsList.FormattingEnabled = true;
            player2RollsList.ItemHeight = 15;
            player2RollsList.Location = new Point(646, 63);
            player2RollsList.Name = "player2RollsList";
            player2RollsList.Size = new Size(142, 214);
            player2RollsList.TabIndex = 8;
            // 
            // player1ScoreLabel
            // 
            player1ScoreLabel.AutoSize = true;
            player1ScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            player1ScoreLabel.Location = new Point(12, 24);
            player1ScoreLabel.Name = "player1ScoreLabel";
            player1ScoreLabel.Size = new Size(67, 21);
            player1ScoreLabel.TabIndex = 9;
            player1ScoreLabel.Text = "Игрок 1";
            // 
            // player2ScoreLabel
            // 
            player2ScoreLabel.AutoSize = true;
            player2ScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            player2ScoreLabel.Location = new Point(646, 24);
            player2ScoreLabel.Name = "player2ScoreLabel";
            player2ScoreLabel.Size = new Size(74, 21);
            player2ScoreLabel.TabIndex = 9;
            player2ScoreLabel.Text = "Игрок 2 :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(player2ScoreLabel);
            Controls.Add(player1ScoreLabel);
            Controls.Add(player2RollsList);
            Controls.Add(player1RollsList);
            Controls.Add(rulesButton);
            Controls.Add(playerVsComputerButton);
            Controls.Add(playerVsPlayerButton);
            Controls.Add(label1);
            Controls.Add(dice2Button);
            Controls.Add(dice1Button);
            Controls.Add(rollButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rollButton;
        private Button dice1Button;
        private Button dice2Button;
        private Label label1;
        private Button playerVsPlayerButton;
        private Button playerVsComputerButton;
        private Button rulesButton;
        private ListBox player1RollsList;
        private ListBox player2RollsList;
        private Label player1ScoreLabel;
        private Label player2ScoreLabel;
    }
}

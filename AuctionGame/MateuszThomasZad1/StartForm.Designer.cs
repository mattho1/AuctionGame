namespace AuctionGame
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.labelChoicePlayer = new System.Windows.Forms.Label();
            this.trackBarDifficultyLevel = new System.Windows.Forms.TrackBar();
            this.labelDifficultyLevel = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDifficultyLevelEasy = new System.Windows.Forms.Label();
            this.labelDifficultyLevelMedium = new System.Windows.Forms.Label();
            this.labelDifficultyLevelHard = new System.Windows.Forms.Label();
            this.groupBoxDifficultyLevel = new System.Windows.Forms.GroupBox();
            this.textBoxNamePlayer1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDifficultyLevel)).BeginInit();
            this.groupBoxDifficultyLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelChoicePlayer
            // 
            this.labelChoicePlayer.AutoSize = true;
            this.labelChoicePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChoicePlayer.Location = new System.Drawing.Point(115, 263);
            this.labelChoicePlayer.Name = "labelChoicePlayer";
            this.labelChoicePlayer.Size = new System.Drawing.Size(197, 20);
            this.labelChoicePlayer.TabIndex = 0;
            this.labelChoicePlayer.Text = "Wybór imienia gracza:";
            // 
            // trackBarDifficultyLevel
            // 
            this.trackBarDifficultyLevel.Location = new System.Drawing.Point(11, 52);
            this.trackBarDifficultyLevel.Maximum = 2;
            this.trackBarDifficultyLevel.Name = "trackBarDifficultyLevel";
            this.trackBarDifficultyLevel.Size = new System.Drawing.Size(293, 56);
            this.trackBarDifficultyLevel.TabIndex = 7;
            // 
            // labelDifficultyLevel
            // 
            this.labelDifficultyLevel.AutoSize = true;
            this.labelDifficultyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDifficultyLevel.Location = new System.Drawing.Point(8, 9);
            this.labelDifficultyLevel.Name = "labelDifficultyLevel";
            this.labelDifficultyLevel.Size = new System.Drawing.Size(161, 20);
            this.labelDifficultyLevel.TabIndex = 8;
            this.labelDifficultyLevel.Text = "Poziom trudności:";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStartGame.Location = new System.Drawing.Point(149, 488);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(122, 40);
            this.buttonStartGame.TabIndex = 9;
            this.buttonStartGame.Text = "START";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(417, 198);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDifficultyLevelEasy
            // 
            this.labelDifficultyLevelEasy.AutoSize = true;
            this.labelDifficultyLevelEasy.Location = new System.Drawing.Point(9, 101);
            this.labelDifficultyLevelEasy.Name = "labelDifficultyLevelEasy";
            this.labelDifficultyLevelEasy.Size = new System.Drawing.Size(44, 17);
            this.labelDifficultyLevelEasy.TabIndex = 12;
            this.labelDifficultyLevelEasy.Text = "Łatwy";
            // 
            // labelDifficultyLevelMedium
            // 
            this.labelDifficultyLevelMedium.AutoSize = true;
            this.labelDifficultyLevelMedium.Location = new System.Drawing.Point(139, 101);
            this.labelDifficultyLevelMedium.Name = "labelDifficultyLevelMedium";
            this.labelDifficultyLevelMedium.Size = new System.Drawing.Size(49, 17);
            this.labelDifficultyLevelMedium.TabIndex = 13;
            this.labelDifficultyLevelMedium.Text = "Średni";
            // 
            // labelDifficultyLevelHard
            // 
            this.labelDifficultyLevelHard.AutoSize = true;
            this.labelDifficultyLevelHard.Location = new System.Drawing.Point(251, 101);
            this.labelDifficultyLevelHard.Name = "labelDifficultyLevelHard";
            this.labelDifficultyLevelHard.Size = new System.Drawing.Size(53, 17);
            this.labelDifficultyLevelHard.TabIndex = 14;
            this.labelDifficultyLevelHard.Text = "Trudny";
            // 
            // groupBoxDifficultyLevel
            // 
            this.groupBoxDifficultyLevel.Controls.Add(this.labelDifficultyLevelHard);
            this.groupBoxDifficultyLevel.Controls.Add(this.labelDifficultyLevelMedium);
            this.groupBoxDifficultyLevel.Controls.Add(this.labelDifficultyLevelEasy);
            this.groupBoxDifficultyLevel.Controls.Add(this.labelDifficultyLevel);
            this.groupBoxDifficultyLevel.Controls.Add(this.trackBarDifficultyLevel);
            this.groupBoxDifficultyLevel.Location = new System.Drawing.Point(55, 356);
            this.groupBoxDifficultyLevel.Name = "groupBoxDifficultyLevel";
            this.groupBoxDifficultyLevel.Size = new System.Drawing.Size(312, 126);
            this.groupBoxDifficultyLevel.TabIndex = 15;
            this.groupBoxDifficultyLevel.TabStop = false;
            // 
            // textBoxNamePlayer1
            // 
            this.textBoxNamePlayer1.Location = new System.Drawing.Point(98, 306);
            this.textBoxNamePlayer1.Name = "textBoxNamePlayer1";
            this.textBoxNamePlayer1.Size = new System.Drawing.Size(232, 22);
            this.textBoxNamePlayer1.TabIndex = 18;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 550);
            this.Controls.Add(this.textBoxNamePlayer1);
            this.Controls.Add(this.groupBoxDifficultyLevel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelChoicePlayer);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ustawienia początkowe";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDifficultyLevel)).EndInit();
            this.groupBoxDifficultyLevel.ResumeLayout(false);
            this.groupBoxDifficultyLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChoicePlayer;
        private System.Windows.Forms.TrackBar trackBarDifficultyLevel;
        private System.Windows.Forms.Label labelDifficultyLevel;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelDifficultyLevelEasy;
        private System.Windows.Forms.Label labelDifficultyLevelMedium;
        private System.Windows.Forms.Label labelDifficultyLevelHard;
        private System.Windows.Forms.GroupBox groupBoxDifficultyLevel;
        private System.Windows.Forms.TextBox textBoxNamePlayer1;
    }
}
namespace AuctionGame
{
    partial class SellForm
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
            this.components = new System.ComponentModel.Container();
            this.labelItemName = new System.Windows.Forms.Label();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.labelValueSellItem = new System.Windows.Forms.Label();
            this.labelPurchasePrice = new System.Windows.Forms.Label();
            this.labelAuction = new System.Windows.Forms.Label();
            this.labelActualPrice = new System.Windows.Forms.Label();
            this.groupBoxAuction = new System.Windows.Forms.GroupBox();
            this.timerTimeAuction = new System.Windows.Forms.Timer(this.components);
            this.buttonBackToMainForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.groupBoxAuction.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelItemName.Location = new System.Drawing.Point(52, 24);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(77, 25);
            this.labelItemName.TabIndex = 4;
            this.labelItemName.Text = "Nazwa";
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxItem.Location = new System.Drawing.Point(57, 67);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(283, 333);
            this.pictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxItem.TabIndex = 5;
            this.pictureBoxItem.TabStop = false;
            // 
            // labelValueSellItem
            // 
            this.labelValueSellItem.AutoSize = true;
            this.labelValueSellItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelValueSellItem.Location = new System.Drawing.Point(375, 67);
            this.labelValueSellItem.Name = "labelValueSellItem";
            this.labelValueSellItem.Size = new System.Drawing.Size(107, 25);
            this.labelValueSellItem.TabIndex = 6;
            this.labelValueSellItem.Text = "Wartość: 0";
            // 
            // labelPurchasePrice
            // 
            this.labelPurchasePrice.AutoSize = true;
            this.labelPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPurchasePrice.Location = new System.Drawing.Point(375, 120);
            this.labelPurchasePrice.Name = "labelPurchasePrice";
            this.labelPurchasePrice.Size = new System.Drawing.Size(151, 25);
            this.labelPurchasePrice.TabIndex = 7;
            this.labelPurchasePrice.Text = "Cena zakupu: 0";
            // 
            // labelAuction
            // 
            this.labelAuction.AutoSize = true;
            this.labelAuction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAuction.Location = new System.Drawing.Point(7, 18);
            this.labelAuction.Name = "labelAuction";
            this.labelAuction.Size = new System.Drawing.Size(88, 25);
            this.labelAuction.TabIndex = 8;
            this.labelAuction.Text = "Licytacja";
            // 
            // labelActualPrice
            // 
            this.labelActualPrice.AutoSize = true;
            this.labelActualPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualPrice.Location = new System.Drawing.Point(7, 72);
            this.labelActualPrice.Name = "labelActualPrice";
            this.labelActualPrice.Size = new System.Drawing.Size(167, 25);
            this.labelActualPrice.TabIndex = 9;
            this.labelActualPrice.Text = "Aktualna kwota: 0";
            // 
            // groupBoxAuction
            // 
            this.groupBoxAuction.Controls.Add(this.labelActualPrice);
            this.groupBoxAuction.Controls.Add(this.labelAuction);
            this.groupBoxAuction.Location = new System.Drawing.Point(368, 220);
            this.groupBoxAuction.Name = "groupBoxAuction";
            this.groupBoxAuction.Size = new System.Drawing.Size(236, 114);
            this.groupBoxAuction.TabIndex = 0;
            this.groupBoxAuction.TabStop = false;
            // 
            // timerTimeAuction
            // 
            this.timerTimeAuction.Interval = 1500;
            this.timerTimeAuction.Tick += new System.EventHandler(this.timerTimeAuction_Tick);
            // 
            // buttonBackToMainForm
            // 
            this.buttonBackToMainForm.Location = new System.Drawing.Point(368, 364);
            this.buttonBackToMainForm.Name = "buttonBackToMainForm";
            this.buttonBackToMainForm.Size = new System.Drawing.Size(235, 36);
            this.buttonBackToMainForm.TabIndex = 8;
            this.buttonBackToMainForm.Text = "Powrót";
            this.buttonBackToMainForm.UseVisualStyleBackColor = true;
            this.buttonBackToMainForm.Click += new System.EventHandler(this.buttonBackToMainForm_Click);
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 456);
            this.Controls.Add(this.buttonBackToMainForm);
            this.Controls.Add(this.groupBoxAuction);
            this.Controls.Add(this.labelPurchasePrice);
            this.Controls.Add(this.labelValueSellItem);
            this.Controls.Add(this.pictureBoxItem);
            this.Controls.Add(this.labelItemName);
            this.Name = "SellForm";
            this.Text = "SellForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.groupBoxAuction.ResumeLayout(false);
            this.groupBoxAuction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.Label labelValueSellItem;
        private System.Windows.Forms.Label labelPurchasePrice;
        private System.Windows.Forms.Label labelAuction;
        private System.Windows.Forms.Label labelActualPrice;
        private System.Windows.Forms.GroupBox groupBoxAuction;
        private System.Windows.Forms.Timer timerTimeAuction;
        private System.Windows.Forms.Button buttonBackToMainForm;
    }
}
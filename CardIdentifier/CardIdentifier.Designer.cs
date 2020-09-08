namespace CardIdentifier
{
    partial class CardIdentifier
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
            this.clickACardLabel = new System.Windows.Forms.Label();
            this.cardOne = new System.Windows.Forms.PictureBox();
            this.cardTwo = new System.Windows.Forms.PictureBox();
            this.cardThree = new System.Windows.Forms.PictureBox();
            this.cardFour = new System.Windows.Forms.PictureBox();
            this.cardFive = new System.Windows.Forms.PictureBox();
            this.selectedCardLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFive)).BeginInit();
            this.SuspendLayout();
            // 
            // clickACardLabel
            // 
            this.clickACardLabel.AutoSize = true;
            this.clickACardLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickACardLabel.Location = new System.Drawing.Point(279, 41);
            this.clickACardLabel.Name = "clickACardLabel";
            this.clickACardLabel.Size = new System.Drawing.Size(231, 22);
            this.clickACardLabel.TabIndex = 0;
            this.clickACardLabel.Text = "Click a card to see its name";
            this.clickACardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cardOne
            // 
            this.cardOne.Image = global::CardIdentifier.Properties.Resources._8_Diamonds;
            this.cardOne.Location = new System.Drawing.Point(32, 97);
            this.cardOne.Name = "cardOne";
            this.cardOne.Size = new System.Drawing.Size(123, 185);
            this.cardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardOne.TabIndex = 1;
            this.cardOne.TabStop = false;
            this.cardOne.Click += new System.EventHandler(this.cardOne_Click);
            // 
            // cardTwo
            // 
            this.cardTwo.Image = global::CardIdentifier.Properties.Resources._2_Clubs;
            this.cardTwo.Location = new System.Drawing.Point(188, 97);
            this.cardTwo.Name = "cardTwo";
            this.cardTwo.Size = new System.Drawing.Size(123, 185);
            this.cardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardTwo.TabIndex = 1;
            this.cardTwo.TabStop = false;
            this.cardTwo.Click += new System.EventHandler(this.cardTwo_Click);
            // 
            // cardThree
            // 
            this.cardThree.Image = global::CardIdentifier.Properties.Resources.King_Spades;
            this.cardThree.Location = new System.Drawing.Point(342, 97);
            this.cardThree.Name = "cardThree";
            this.cardThree.Size = new System.Drawing.Size(123, 185);
            this.cardThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardThree.TabIndex = 1;
            this.cardThree.TabStop = false;
            this.cardThree.Click += new System.EventHandler(this.cardThree_Click);
            // 
            // cardFour
            // 
            this.cardFour.Image = global::CardIdentifier.Properties.Resources.Ace_Spades;
            this.cardFour.Location = new System.Drawing.Point(495, 97);
            this.cardFour.Name = "cardFour";
            this.cardFour.Size = new System.Drawing.Size(123, 185);
            this.cardFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFour.TabIndex = 1;
            this.cardFour.TabStop = false;
            this.cardFour.Click += new System.EventHandler(this.cardFour_Click);
            // 
            // cardFive
            // 
            this.cardFive.Image = global::CardIdentifier.Properties.Resources.Joker_Black;
            this.cardFive.Location = new System.Drawing.Point(648, 97);
            this.cardFive.Name = "cardFive";
            this.cardFive.Size = new System.Drawing.Size(123, 185);
            this.cardFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFive.TabIndex = 1;
            this.cardFive.TabStop = false;
            this.cardFive.Click += new System.EventHandler(this.cardFive_Click);
            // 
            // selectedCardLabel
            // 
            this.selectedCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedCardLabel.Location = new System.Drawing.Point(32, 308);
            this.selectedCardLabel.Name = "selectedCardLabel";
            this.selectedCardLabel.Padding = new System.Windows.Forms.Padding(10);
            this.selectedCardLabel.Size = new System.Drawing.Size(739, 38);
            this.selectedCardLabel.TabIndex = 2;
            this.selectedCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(342, 379);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(123, 39);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CardIdentifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectedCardLabel);
            this.Controls.Add(this.cardFive);
            this.Controls.Add(this.cardFour);
            this.Controls.Add(this.cardThree);
            this.Controls.Add(this.cardTwo);
            this.Controls.Add(this.cardOne);
            this.Controls.Add(this.clickACardLabel);
            this.Name = "CardIdentifier";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.cardOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clickACardLabel;
        private System.Windows.Forms.PictureBox cardOne;
        private System.Windows.Forms.PictureBox cardTwo;
        private System.Windows.Forms.PictureBox cardThree;
        private System.Windows.Forms.PictureBox cardFour;
        private System.Windows.Forms.PictureBox cardFive;
        private System.Windows.Forms.Label selectedCardLabel;
        private System.Windows.Forms.Button exitButton;
    }
}


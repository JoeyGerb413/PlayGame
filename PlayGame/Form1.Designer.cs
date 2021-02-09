namespace PlayGame
{
    partial class EpicGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EpicGame));
            this.CreditDisplay = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.GO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreditDisplay
            // 
            this.CreditDisplay.AutoSize = true;
            this.CreditDisplay.Font = new System.Drawing.Font("mono 07_65", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditDisplay.Location = new System.Drawing.Point(250, 306);
            this.CreditDisplay.Name = "CreditDisplay";
            this.CreditDisplay.Size = new System.Drawing.Size(327, 31);
            this.CreditDisplay.TabIndex = 0;
            this.CreditDisplay.Text = "(Credit Required)";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("mono 07_66", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(330, 206);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(126, 66);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Press to Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // GO
            // 
            this.GO.AutoSize = true;
            this.GO.Font = new System.Drawing.Font("mono 07_65", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GO.ForeColor = System.Drawing.Color.Blue;
            this.GO.Location = new System.Drawing.Point(265, 125);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(278, 78);
            this.GO.TabIndex = 2;
            this.GO.Text = "GO!!!";
            // 
            // EpicGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CreditDisplay);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EpicGame";
            this.Text = "Xplode";
            this.Load += new System.EventHandler(this.EpicGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreditDisplay;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label GO;
    }
}


namespace Poker_Game
{
    partial class FormEndGame
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
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblBetterLuck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pbResult
            // 
            this.pbResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbResult.Location = new System.Drawing.Point(-1, -2);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(288, 223);
            this.pbResult.TabIndex = 0;
            this.pbResult.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(197, 227);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblBetterLuck
            // 
            this.lblBetterLuck.AutoSize = true;
            this.lblBetterLuck.Location = new System.Drawing.Point(12, 232);
            this.lblBetterLuck.Name = "lblBetterLuck";
            this.lblBetterLuck.Size = new System.Drawing.Size(137, 12);
            this.lblBetterLuck.TabIndex = 2;
            this.lblBetterLuck.Text = "Better Luck Next Time!";
            // 
            // FormEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblBetterLuck);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pbResult);
            this.Name = "FormEndGame";
            this.Text = "FormEndGame";
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblBetterLuck;
    }
}
namespace Poker_Game
{
    partial class FormGetMoney
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
            this.nudBetRaise = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRaiseAmount = new System.Windows.Forms.Label();
            this.tbRaise = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.nudBetRaise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRaise)).BeginInit();
            this.SuspendLayout();
            // 
            // nudBetRaise
            // 
            this.nudBetRaise.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudBetRaise.Location = new System.Drawing.Point(159, 31);
            this.nudBetRaise.Name = "nudBetRaise";
            this.nudBetRaise.Size = new System.Drawing.Size(75, 20);
            this.nudBetRaise.TabIndex = 0;
            this.nudBetRaise.ValueChanged += new System.EventHandler(this.nudBetRaise_ValueChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(78, 82);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(159, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblRaiseAmount
            // 
            this.lblRaiseAmount.AutoSize = true;
            this.lblRaiseAmount.Location = new System.Drawing.Point(35, 9);
            this.lblRaiseAmount.Name = "lblRaiseAmount";
            this.lblRaiseAmount.Size = new System.Drawing.Size(73, 13);
            this.lblRaiseAmount.TabIndex = 3;
            this.lblRaiseAmount.Text = "Raise Amount";
            // 
            // tbRaise
            // 
            this.tbRaise.LargeChange = 500;
            this.tbRaise.Location = new System.Drawing.Point(24, 31);
            this.tbRaise.Name = "tbRaise";
            this.tbRaise.Size = new System.Drawing.Size(129, 45);
            this.tbRaise.SmallChange = 250;
            this.tbRaise.TabIndex = 4;
            this.tbRaise.TickFrequency = 250;
            this.tbRaise.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbRaise.Scroll += new System.EventHandler(this.tbRaise_Scroll);
            // 
            // FormGetMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 125);
            this.Controls.Add(this.tbRaise);
            this.Controls.Add(this.lblRaiseAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nudBetRaise);
            this.Name = "FormGetMoney";
            this.Text = "Raise";
            ((System.ComponentModel.ISupportInitialize)(this.nudBetRaise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRaise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.NumericUpDown nudBetRaise;
        private System.Windows.Forms.TrackBar tbRaise;
        public System.Windows.Forms.Label lblRaiseAmount;

    }
}
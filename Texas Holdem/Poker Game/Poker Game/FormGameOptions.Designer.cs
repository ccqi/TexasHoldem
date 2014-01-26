namespace Poker_Game
{
    partial class FormGameOptions
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
            this.nudBuyIn = new System.Windows.Forms.NumericUpDown();
            this.lblBuyIn = new System.Windows.Forms.Label();
            this.lblPlayerAmount = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtYourName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyIn)).BeginInit();
            this.SuspendLayout();
            // 
            // nudBuyIn
            // 
            this.nudBuyIn.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBuyIn.Location = new System.Drawing.Point(144, 57);
            this.nudBuyIn.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudBuyIn.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudBuyIn.Name = "nudBuyIn";
            this.nudBuyIn.Size = new System.Drawing.Size(144, 20);
            this.nudBuyIn.TabIndex = 2;
            this.nudBuyIn.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // lblBuyIn
            // 
            this.lblBuyIn.AutoSize = true;
            this.lblBuyIn.Location = new System.Drawing.Point(24, 60);
            this.lblBuyIn.Name = "lblBuyIn";
            this.lblBuyIn.Size = new System.Drawing.Size(85, 13);
            this.lblBuyIn.TabIndex = 1;
            this.lblBuyIn.Text = "Buy In Amount : ";
            // 
            // lblPlayerAmount
            // 
            this.lblPlayerAmount.AutoSize = true;
            this.lblPlayerAmount.Location = new System.Drawing.Point(24, 101);
            this.lblPlayerAmount.Name = "lblPlayerAmount";
            this.lblPlayerAmount.Size = new System.Drawing.Size(104, 13);
            this.lblPlayerAmount.TabIndex = 2;
            this.lblPlayerAmount.Text = "Number Of Players : ";
            this.lblPlayerAmount.Click += new System.EventHandler(this.lblPlayerAmount_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.BorderSize = 2;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(144, 95);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(31, 25);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn2_MouseDown);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.BorderSize = 2;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(200, 95);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(31, 25);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn3_MouseDown);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.BorderSize = 2;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(257, 95);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(31, 25);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn4_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Difficulty : ";
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Checked = true;
            this.rbEasy.Location = new System.Drawing.Point(104, 148);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(48, 17);
            this.rbEasy.TabIndex = 6;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(157, 148);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 7;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Location = new System.Drawing.Point(222, 148);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(48, 17);
            this.rbHard.TabIndex = 8;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(168, 187);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(57, 51);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtYourName
            // 
            this.txtYourName.Location = new System.Drawing.Point(144, 13);
            this.txtYourName.Name = "txtYourName";
            this.txtYourName.Size = new System.Drawing.Size(144, 20);
            this.txtYourName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Your Name : ";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(231, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 51);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormGameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 251);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtYourName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbHard);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.rbEasy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lblPlayerAmount);
            this.Controls.Add(this.lblBuyIn);
            this.Controls.Add(this.nudBuyIn);
            this.Name = "FormGameOptions";
            this.Text = "New Game Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGameOptions_FormClosing);
            this.Load += new System.EventHandler(this.FormGameOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudBuyIn;
        private System.Windows.Forms.Label lblBuyIn;
        private System.Windows.Forms.Label lblPlayerAmount;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtYourName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
    }
}
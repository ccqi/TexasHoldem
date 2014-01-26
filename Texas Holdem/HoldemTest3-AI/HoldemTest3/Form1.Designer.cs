namespace HoldemTest3
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
            this.lbMain = new System.Windows.Forms.ListBox();
            this.btnHandValue = new System.Windows.Forms.Button();
            this.btnPotOdds = new System.Windows.Forms.Button();
            this.pbCards = new System.Windows.Forms.PictureBox();
            this.btnHole = new System.Windows.Forms.Button();
            this.btnTurn = new System.Windows.Forms.Button();
            this.btnRiver = new System.Windows.Forms.Button();
            this.btnFlop = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.nudPlayers = new System.Windows.Forms.NumericUpDown();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.txtCall = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMain
            // 
            this.lbMain.FormattingEnabled = true;
            this.lbMain.Location = new System.Drawing.Point(26, 69);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(179, 95);
            this.lbMain.TabIndex = 0;
            // 
            // btnHandValue
            // 
            this.btnHandValue.Location = new System.Drawing.Point(275, 15);
            this.btnHandValue.Name = "btnHandValue";
            this.btnHandValue.Size = new System.Drawing.Size(100, 23);
            this.btnHandValue.TabIndex = 1;
            this.btnHandValue.Text = "Hand Value";
            this.btnHandValue.UseVisualStyleBackColor = true;
            this.btnHandValue.Click += new System.EventHandler(this.btnHandValue_Click);
            // 
            // btnPotOdds
            // 
            this.btnPotOdds.Location = new System.Drawing.Point(275, 99);
            this.btnPotOdds.Name = "btnPotOdds";
            this.btnPotOdds.Size = new System.Drawing.Size(100, 23);
            this.btnPotOdds.TabIndex = 2;
            this.btnPotOdds.Text = "Pot Odds";
            this.btnPotOdds.UseVisualStyleBackColor = true;
            this.btnPotOdds.Click += new System.EventHandler(this.btnPotOdds_Click);
            // 
            // pbCards
            // 
            this.pbCards.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbCards.Location = new System.Drawing.Point(26, 184);
            this.pbCards.Name = "pbCards";
            this.pbCards.Size = new System.Drawing.Size(710, 116);
            this.pbCards.TabIndex = 3;
            this.pbCards.TabStop = false;
            // 
            // btnHole
            // 
            this.btnHole.Location = new System.Drawing.Point(26, 321);
            this.btnHole.Name = "btnHole";
            this.btnHole.Size = new System.Drawing.Size(105, 23);
            this.btnHole.TabIndex = 4;
            this.btnHole.Text = "Generate Hole";
            this.btnHole.UseVisualStyleBackColor = true;
            this.btnHole.Click += new System.EventHandler(this.btnHole_Click);
            // 
            // btnTurn
            // 
            this.btnTurn.Location = new System.Drawing.Point(275, 321);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(100, 23);
            this.btnTurn.TabIndex = 5;
            this.btnTurn.Text = "Generate Turn";
            this.btnTurn.UseVisualStyleBackColor = true;
            this.btnTurn.Click += new System.EventHandler(this.btnTurn_Click);
            // 
            // btnRiver
            // 
            this.btnRiver.Location = new System.Drawing.Point(394, 321);
            this.btnRiver.Name = "btnRiver";
            this.btnRiver.Size = new System.Drawing.Size(105, 23);
            this.btnRiver.TabIndex = 6;
            this.btnRiver.Text = "Generate River";
            this.btnRiver.UseVisualStyleBackColor = true;
            this.btnRiver.Click += new System.EventHandler(this.btnRiver_Click);
            // 
            // btnFlop
            // 
            this.btnFlop.Location = new System.Drawing.Point(148, 321);
            this.btnFlop.Name = "btnFlop";
            this.btnFlop.Size = new System.Drawing.Size(100, 23);
            this.btnFlop.TabIndex = 7;
            this.btnFlop.Text = "Generate Flop";
            this.btnFlop.UseVisualStyleBackColor = true;
            this.btnFlop.Click += new System.EventHandler(this.btnFlop_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.Location = new System.Drawing.Point(26, 13);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(105, 23);
            this.btnPlayers.TabIndex = 8;
            this.btnPlayers.Text = "Generate";
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // nudPlayers
            // 
            this.nudPlayers.Location = new System.Drawing.Point(148, 15);
            this.nudPlayers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPlayers.Name = "nudPlayers";
            this.nudPlayers.Size = new System.Drawing.Size(120, 20);
            this.nudPlayers.TabIndex = 9;
            this.nudPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(514, 15);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(160, 149);
            this.rtbOutput.TabIndex = 10;
            this.rtbOutput.Text = "";
            // 
            // txtCall
            // 
            this.txtCall.Location = new System.Drawing.Point(399, 102);
            this.txtCall.Name = "txtCall";
            this.txtCall.Size = new System.Drawing.Size(100, 20);
            this.txtCall.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(399, 144);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount To Call";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Amount In Pot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCall);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.nudPlayers);
            this.Controls.Add(this.btnPlayers);
            this.Controls.Add(this.btnFlop);
            this.Controls.Add(this.btnRiver);
            this.Controls.Add(this.btnTurn);
            this.Controls.Add(this.btnHole);
            this.Controls.Add(this.pbCards);
            this.Controls.Add(this.btnPotOdds);
            this.Controls.Add(this.btnHandValue);
            this.Controls.Add(this.lbMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMain;
        private System.Windows.Forms.Button btnHandValue;
        private System.Windows.Forms.Button btnPotOdds;
        private System.Windows.Forms.PictureBox pbCards;
        private System.Windows.Forms.Button btnHole;
        private System.Windows.Forms.Button btnTurn;
        private System.Windows.Forms.Button btnRiver;
        private System.Windows.Forms.Button btnFlop;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.NumericUpDown nudPlayers;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.TextBox txtCall;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


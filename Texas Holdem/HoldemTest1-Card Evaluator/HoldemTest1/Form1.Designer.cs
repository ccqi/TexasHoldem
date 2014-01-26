namespace HoldemTest1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbRank = new System.Windows.Forms.ComboBox();
            this.cbSuit = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnEvalute = new System.Windows.Forms.Button();
            this.MainList = new System.Windows.Forms.ListBox();
            this.btnAddHand2 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button25 = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Hand 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(36, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 155);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbRank
            // 
            this.cbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRank.FormattingEnabled = true;
            this.cbRank.Location = new System.Drawing.Point(160, 336);
            this.cbRank.Name = "cbRank";
            this.cbRank.Size = new System.Drawing.Size(121, 21);
            this.cbRank.TabIndex = 2;
            // 
            // cbSuit
            // 
            this.cbSuit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuit.FormattingEnabled = true;
            this.cbSuit.Location = new System.Drawing.Point(160, 377);
            this.cbSuit.Name = "cbSuit";
            this.cbSuit.Size = new System.Drawing.Size(121, 21);
            this.cbSuit.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(424, 355);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 25);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Check Royal Flush";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "Remove Hand 1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(424, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 25);
            this.button4.TabIndex = 7;
            this.button4.Text = "Check Straight Flush";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(424, 450);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 25);
            this.button5.TabIndex = 8;
            this.button5.Text = "Check 4Kind";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(424, 481);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 25);
            this.button6.TabIndex = 9;
            this.button6.Text = "Check FullHouse";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(424, 512);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 25);
            this.button7.TabIndex = 10;
            this.button7.Text = "Check Flush";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(424, 544);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 25);
            this.button8.TabIndex = 11;
            this.button8.Text = "Check Straight";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(424, 575);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 25);
            this.button9.TabIndex = 12;
            this.button9.Text = "Check 3Kind";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(424, 607);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(136, 25);
            this.button10.TabIndex = 13;
            this.button10.Text = "Check 2Pair";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(424, 638);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(136, 25);
            this.button11.TabIndex = 14;
            this.button11.Text = "Check 1Pair";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(424, 666);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(136, 25);
            this.button12.TabIndex = 15;
            this.button12.Text = "Check High Card";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(566, 387);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(136, 25);
            this.button13.TabIndex = 16;
            this.button13.Text = "Get Royal Flush";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(566, 418);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(136, 25);
            this.button14.TabIndex = 17;
            this.button14.Text = "Get Straight Flush";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(566, 450);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(136, 25);
            this.button15.TabIndex = 18;
            this.button15.Text = "Get 4Kind";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(566, 481);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(136, 25);
            this.button16.TabIndex = 19;
            this.button16.Text = "Get FullHouse";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(566, 512);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(136, 25);
            this.button17.TabIndex = 20;
            this.button17.Text = "Get Flush";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(566, 544);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(136, 25);
            this.button18.TabIndex = 21;
            this.button18.Text = "Get Straight";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(566, 575);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(136, 25);
            this.button19.TabIndex = 22;
            this.button19.Text = "Get 3Kind";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(566, 607);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(136, 25);
            this.button20.TabIndex = 23;
            this.button20.Text = "Get 2Pair";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(566, 638);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(136, 25);
            this.button21.TabIndex = 24;
            this.button21.Text = "Get 1Pair";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(566, 666);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(136, 25);
            this.button22.TabIndex = 25;
            this.button22.Text = "Get HighCard";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(36, 420);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(116, 23);
            this.btnAuto.TabIndex = 26;
            this.btnAuto.Text = "Auto Generate";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnEvalute
            // 
            this.btnEvalute.Location = new System.Drawing.Point(36, 465);
            this.btnEvalute.Name = "btnEvalute";
            this.btnEvalute.Size = new System.Drawing.Size(116, 25);
            this.btnEvalute.TabIndex = 27;
            this.btnEvalute.Text = "Evaluate";
            this.btnEvalute.UseVisualStyleBackColor = true;
            this.btnEvalute.Click += new System.EventHandler(this.btnEvalute_Click);
            // 
            // MainList
            // 
            this.MainList.FormattingEnabled = true;
            this.MainList.Location = new System.Drawing.Point(652, 22);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(194, 186);
            this.MainList.TabIndex = 28;
            // 
            // btnAddHand2
            // 
            this.btnAddHand2.Location = new System.Drawing.Point(36, 376);
            this.btnAddHand2.Name = "btnAddHand2";
            this.btnAddHand2.Size = new System.Drawing.Size(75, 23);
            this.btnAddHand2.TabIndex = 29;
            this.btnAddHand2.Text = "Add Hand 2";
            this.btnAddHand2.UseVisualStyleBackColor = true;
            this.btnAddHand2.Click += new System.EventHandler(this.btnAddHand2_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(297, 377);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(97, 25);
            this.button23.TabIndex = 30;
            this.button23.Text = "Remove Hand 2";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(165, 420);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(146, 23);
            this.button24.TabIndex = 31;
            this.button24.Text = "Auto Generate Hand 2";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(36, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 155);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(165, 465);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(116, 25);
            this.button25.TabIndex = 33;
            this.button25.Text = "Evaluate Hand 2";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(36, 514);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(116, 23);
            this.btnCompare.TabIndex = 34;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 699);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.btnAddHand2);
            this.Controls.Add(this.MainList);
            this.Controls.Add(this.btnEvalute);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cbSuit);
            this.Controls.Add(this.cbRank);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbRank;
        private System.Windows.Forms.ComboBox cbSuit;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnEvalute;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.Button btnAddHand2;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button btnCompare;
    }
}


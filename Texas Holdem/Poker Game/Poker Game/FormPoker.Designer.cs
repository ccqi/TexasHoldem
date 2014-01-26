namespace Poker_Game
{
    partial class FormPoker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPoker));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.btnAllIn = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnRaise = new System.Windows.Forms.Button();
            this.btnFold = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.pbDealer = new System.Windows.Forms.PictureBox();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblM2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblP3 = new System.Windows.Forms.Label();
            this.lblA3 = new System.Windows.Forms.Label();
            this.lblM3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblP4 = new System.Windows.Forms.Label();
            this.lblA4 = new System.Windows.Forms.Label();
            this.lblM4 = new System.Windows.Forms.Label();
            this.panelBubble = new System.Windows.Forms.Panel();
            this.lblBubble = new System.Windows.Forms.Label();
            this.TimerNextMove = new System.Windows.Forms.Timer(this.components);
            this.lblBanner = new System.Windows.Forms.Label();
            this.TimerWait3Seconds = new System.Windows.Forms.Timer(this.components);
            this.TimerShowdown = new System.Windows.Forms.Timer(this.components);
            this.lblPot = new System.Windows.Forms.Label();
            this.timerBusted = new System.Windows.Forms.Timer(this.components);
            this.toolTipHint = new System.Windows.Forms.ToolTip(this.components);
            this.timerCalculate = new System.Windows.Forms.Timer(this.components);
            this.btnMusic = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer)).BeginInit();
            this.panelPlayer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelBubble.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.Transparent;
            this.pbMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMain.BackgroundImage")));
            this.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMain.Location = new System.Drawing.Point(0, 0);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(1366, 768);
            this.pbMain.TabIndex = 6;
            this.pbMain.TabStop = false;
            // 
            // btnAllIn
            // 
            this.btnAllIn.BackColor = System.Drawing.Color.Transparent;
            this.btnAllIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAllIn.BackgroundImage")));
            this.btnAllIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAllIn.FlatAppearance.BorderSize = 0;
            this.btnAllIn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAllIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAllIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAllIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllIn.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllIn.ForeColor = System.Drawing.Color.White;
            this.btnAllIn.Location = new System.Drawing.Point(1083, 592);
            this.btnAllIn.Name = "btnAllIn";
            this.btnAllIn.Size = new System.Drawing.Size(159, 50);
            this.btnAllIn.TabIndex = 4;
            this.btnAllIn.Text = "All In";
            this.btnAllIn.UseVisualStyleBackColor = false;
            this.btnAllIn.Visible = false;
            this.btnAllIn.Click += new System.EventHandler(this.btnAllIn_Click);
            this.btnAllIn.MouseEnter += new System.EventHandler(this.btnAllIn_MouseEnter);
            this.btnAllIn.MouseLeave += new System.EventHandler(this.btnAllIn_MouseLeave);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.BackgroundImage")));
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(1083, 482);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(159, 50);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseEnter += new System.EventHandler(this.btnCheck_MouseEnter);
            this.btnCheck.MouseLeave += new System.EventHandler(this.btnCheck_MouseLeave);
            // 
            // btnRaise
            // 
            this.btnRaise.BackColor = System.Drawing.Color.Transparent;
            this.btnRaise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRaise.BackgroundImage")));
            this.btnRaise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRaise.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRaise.FlatAppearance.BorderSize = 0;
            this.btnRaise.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRaise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRaise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRaise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaise.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaise.ForeColor = System.Drawing.Color.White;
            this.btnRaise.Location = new System.Drawing.Point(1083, 536);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(159, 50);
            this.btnRaise.TabIndex = 8;
            this.btnRaise.Text = "Raise";
            this.btnRaise.UseVisualStyleBackColor = false;
            this.btnRaise.Visible = false;
            this.btnRaise.Click += new System.EventHandler(this.btnRaise_Click);
            this.btnRaise.MouseEnter += new System.EventHandler(this.btnRaise_MouseEnter);
            this.btnRaise.MouseLeave += new System.EventHandler(this.btnRaise_MouseLeave);
            // 
            // btnFold
            // 
            this.btnFold.BackColor = System.Drawing.Color.Transparent;
            this.btnFold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFold.BackgroundImage")));
            this.btnFold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFold.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFold.FlatAppearance.BorderSize = 0;
            this.btnFold.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnFold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFold.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFold.ForeColor = System.Drawing.Color.White;
            this.btnFold.Location = new System.Drawing.Point(1083, 649);
            this.btnFold.Name = "btnFold";
            this.btnFold.Size = new System.Drawing.Size(159, 50);
            this.btnFold.TabIndex = 9;
            this.btnFold.Text = "Fold";
            this.btnFold.UseVisualStyleBackColor = false;
            this.btnFold.Visible = false;
            this.btnFold.Click += new System.EventHandler(this.btnFold_Click);
            this.btnFold.MouseEnter += new System.EventHandler(this.btnFold_MouseEnter);
            this.btnFold.MouseLeave += new System.EventHandler(this.btnFold_MouseLeave);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.White;
            this.lblDisplay.Location = new System.Drawing.Point(420, 463);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 25);
            this.lblDisplay.TabIndex = 14;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbDealer
            // 
            this.pbDealer.BackColor = System.Drawing.Color.Transparent;
            this.pbDealer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbDealer.BackgroundImage")));
            this.pbDealer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDealer.Location = new System.Drawing.Point(298, 67);
            this.pbDealer.Name = "pbDealer";
            this.pbDealer.Size = new System.Drawing.Size(60, 60);
            this.pbDealer.TabIndex = 15;
            this.pbDealer.TabStop = false;
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.panelPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPlayer.BackgroundImage")));
            this.panelPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPlayer.Controls.Add(this.lblName);
            this.panelPlayer.Controls.Add(this.lblAction);
            this.panelPlayer.Controls.Add(this.lblMoney);
            this.panelPlayer.Location = new System.Drawing.Point(599, 590);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(185, 111);
            this.panelPlayer.TabIndex = 17;
            this.toolTipHint.SetToolTip(this.panelPlayer, "\r\n");
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(35, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 29);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Charles Qi";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.ForeColor = System.Drawing.Color.White;
            this.lblAction.Location = new System.Drawing.Point(8, 59);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(75, 20);
            this.lblAction.TabIndex = 18;
            this.lblAction.Text = "FOLDED";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(15, 87);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(75, 24);
            this.lblMoney.TabIndex = 17;
            this.lblMoney.Text = "$10,000";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblP2);
            this.panel2.Controls.Add(this.lblA2);
            this.panel2.Controls.Add(this.lblM2);
            this.panel2.Location = new System.Drawing.Point(150, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 111);
            this.panel2.TabIndex = 19;
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.Location = new System.Drawing.Point(35, 8);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(98, 29);
            this.lblP2.TabIndex = 20;
            this.lblP2.Text = "Player 2";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA2.ForeColor = System.Drawing.Color.White;
            this.lblA2.Location = new System.Drawing.Point(8, 59);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(75, 20);
            this.lblA2.TabIndex = 18;
            this.lblA2.Text = "FOLDED";
            // 
            // lblM2
            // 
            this.lblM2.AutoSize = true;
            this.lblM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM2.ForeColor = System.Drawing.Color.White;
            this.lblM2.Location = new System.Drawing.Point(15, 87);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(75, 24);
            this.lblM2.TabIndex = 17;
            this.lblM2.Text = "$10,000";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblP3);
            this.panel3.Controls.Add(this.lblA3);
            this.panel3.Controls.Add(this.lblM3);
            this.panel3.Location = new System.Drawing.Point(599, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 111);
            this.panel3.TabIndex = 20;
            this.panel3.Visible = false;
            // 
            // lblP3
            // 
            this.lblP3.AutoSize = true;
            this.lblP3.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP3.Location = new System.Drawing.Point(35, 8);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(98, 29);
            this.lblP3.TabIndex = 20;
            this.lblP3.Text = "Player 3";
            // 
            // lblA3
            // 
            this.lblA3.AutoSize = true;
            this.lblA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA3.ForeColor = System.Drawing.Color.White;
            this.lblA3.Location = new System.Drawing.Point(8, 59);
            this.lblA3.Name = "lblA3";
            this.lblA3.Size = new System.Drawing.Size(75, 20);
            this.lblA3.TabIndex = 18;
            this.lblA3.Text = "FOLDED";
            // 
            // lblM3
            // 
            this.lblM3.AutoSize = true;
            this.lblM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM3.ForeColor = System.Drawing.Color.White;
            this.lblM3.Location = new System.Drawing.Point(15, 87);
            this.lblM3.Name = "lblM3";
            this.lblM3.Size = new System.Drawing.Size(75, 24);
            this.lblM3.TabIndex = 17;
            this.lblM3.Text = "$10,000";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lblP4);
            this.panel4.Controls.Add(this.lblA4);
            this.panel4.Controls.Add(this.lblM4);
            this.panel4.Location = new System.Drawing.Point(1026, 322);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 111);
            this.panel4.TabIndex = 21;
            this.panel4.Visible = false;
            // 
            // lblP4
            // 
            this.lblP4.AutoSize = true;
            this.lblP4.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP4.Location = new System.Drawing.Point(35, 8);
            this.lblP4.Name = "lblP4";
            this.lblP4.Size = new System.Drawing.Size(98, 29);
            this.lblP4.TabIndex = 20;
            this.lblP4.Text = "Player 4";
            // 
            // lblA4
            // 
            this.lblA4.AutoSize = true;
            this.lblA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA4.ForeColor = System.Drawing.Color.White;
            this.lblA4.Location = new System.Drawing.Point(8, 59);
            this.lblA4.Name = "lblA4";
            this.lblA4.Size = new System.Drawing.Size(75, 20);
            this.lblA4.TabIndex = 18;
            this.lblA4.Text = "FOLDED";
            // 
            // lblM4
            // 
            this.lblM4.AutoSize = true;
            this.lblM4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM4.ForeColor = System.Drawing.Color.White;
            this.lblM4.Location = new System.Drawing.Point(15, 87);
            this.lblM4.Name = "lblM4";
            this.lblM4.Size = new System.Drawing.Size(75, 24);
            this.lblM4.TabIndex = 17;
            this.lblM4.Text = "$10,000";
            // 
            // panelBubble
            // 
            this.panelBubble.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBubble.BackgroundImage")));
            this.panelBubble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBubble.Controls.Add(this.lblBubble);
            this.panelBubble.Location = new System.Drawing.Point(84, 98);
            this.panelBubble.Name = "panelBubble";
            this.panelBubble.Size = new System.Drawing.Size(183, 171);
            this.panelBubble.TabIndex = 22;
            // 
            // lblBubble
            // 
            this.lblBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBubble.Location = new System.Drawing.Point(26, 23);
            this.lblBubble.Name = "lblBubble";
            this.lblBubble.Size = new System.Drawing.Size(123, 73);
            this.lblBubble.TabIndex = 0;
            this.lblBubble.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimerNextMove
            // 
            this.TimerNextMove.Interval = 2500;
            this.TimerNextMove.Tick += new System.EventHandler(this.TimerNextMove_Tick);
            // 
            // lblBanner
            // 
            this.lblBanner.BackColor = System.Drawing.Color.Transparent;
            this.lblBanner.Font = new System.Drawing.Font("Castellar", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.Location = new System.Drawing.Point(390, 232);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(580, 69);
            this.lblBanner.TabIndex = 23;
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBanner.Visible = false;
            // 
            // TimerWait3Seconds
            // 
            this.TimerWait3Seconds.Interval = 3000;
            this.TimerWait3Seconds.Tick += new System.EventHandler(this.TimerWait3Seconds_Tick);
            // 
            // TimerShowdown
            // 
            this.TimerShowdown.Interval = 2500;
            this.TimerShowdown.Tick += new System.EventHandler(this.TimerShowdown_Tick);
            // 
            // lblPot
            // 
            this.lblPot.AutoSize = true;
            this.lblPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPot.ForeColor = System.Drawing.Color.White;
            this.lblPot.Location = new System.Drawing.Point(1061, 67);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(0, 25);
            this.lblPot.TabIndex = 24;
            this.lblPot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerBusted
            // 
            this.timerBusted.Interval = 2500;
            this.timerBusted.Tick += new System.EventHandler(this.timerBusted_Tick);
            // 
            // toolTipHint
            // 
            this.toolTipHint.AutomaticDelay = 0;
            this.toolTipHint.AutoPopDelay = 0;
            this.toolTipHint.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTipHint.InitialDelay = 0;
            this.toolTipHint.ReshowDelay = 0;
            this.toolTipHint.ShowAlways = true;
            this.toolTipHint.ToolTipTitle = "Your best hand is:";
            this.toolTipHint.UseFading = false;
            this.toolTipHint.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTipHint_Draw);
            // 
            // timerCalculate
            // 
            this.timerCalculate.Interval = 1;
            this.timerCalculate.Tick += new System.EventHandler(this.timerCalculate_Tick);
            // 
            // btnMusic
            // 
            this.btnMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMusic.BackgroundImage")));
            this.btnMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusic.FlatAppearance.BorderSize = 0;
            this.btnMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Location = new System.Drawing.Point(1288, 619);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(50, 50);
            this.btnMusic.TabIndex = 25;
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // FormPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.lblPot);
            this.Controls.Add(this.lblBanner);
            this.Controls.Add(this.panelBubble);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.pbDealer);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnFold);
            this.Controls.Add(this.btnRaise);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnAllIn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbMain);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPoker";
            this.Text = "Texas Holdem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPoker_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer)).EndInit();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelBubble.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Button btnAllIn;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnFold;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.PictureBox pbDealer;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label lblM2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblA3;
        private System.Windows.Forms.Label lblM3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblA4;
        private System.Windows.Forms.Label lblM4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblP3;
        private System.Windows.Forms.Label lblP4;
        private System.Windows.Forms.Panel panelBubble;
        private System.Windows.Forms.Label lblBubble;
        private System.Windows.Forms.Timer TimerNextMove;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Timer TimerWait3Seconds;
        private System.Windows.Forms.Timer TimerShowdown;
        private System.Windows.Forms.Label lblPot;
        private System.Windows.Forms.Timer timerBusted;
        private System.Windows.Forms.ToolTip toolTipHint;
        private System.Windows.Forms.Timer timerCalculate;
        public System.Windows.Forms.Button btnRaise;
        private System.Windows.Forms.Button btnMusic;
    }
}
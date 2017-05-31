namespace OOPDogRace
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
            this.lblLane2 = new System.Windows.Forms.Label();
            this.lblLane3 = new System.Windows.Forms.Label();
            this.lblLane4 = new System.Windows.Forms.Label();
            this.lblLane1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.udDogNumber = new System.Windows.Forms.NumericUpDown();
            this.txtPlayer3Info = new System.Windows.Forms.TextBox();
            this.txtPlayer2Info = new System.Windows.Forms.TextBox();
            this.txtPlayer1Info = new System.Windows.Forms.TextBox();
            this.lblMaxBet = new System.Windows.Forms.Label();
            this.udBetAmount = new System.Windows.Forms.NumericUpDown();
            this.rbPlayer3 = new System.Windows.Forms.RadioButton();
            this.rbPlayer2 = new System.Windows.Forms.RadioButton();
            this.rbPlayer1 = new System.Windows.Forms.RadioButton();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMinBet = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udDogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLane2
            // 
            this.lblLane2.AutoSize = true;
            this.lblLane2.Location = new System.Drawing.Point(202, 161);
            this.lblLane2.Name = "lblLane2";
            this.lblLane2.Size = new System.Drawing.Size(14, 15);
            this.lblLane2.TabIndex = 26;
            this.lblLane2.Text = "2";
            // 
            // lblLane3
            // 
            this.lblLane3.AutoSize = true;
            this.lblLane3.Location = new System.Drawing.Point(202, 232);
            this.lblLane3.Name = "lblLane3";
            this.lblLane3.Size = new System.Drawing.Size(14, 15);
            this.lblLane3.TabIndex = 25;
            this.lblLane3.Text = "3";
            // 
            // lblLane4
            // 
            this.lblLane4.AutoSize = true;
            this.lblLane4.Location = new System.Drawing.Point(202, 297);
            this.lblLane4.Name = "lblLane4";
            this.lblLane4.Size = new System.Drawing.Size(14, 15);
            this.lblLane4.TabIndex = 24;
            this.lblLane4.Text = "4";
            // 
            // lblLane1
            // 
            this.lblLane1.AutoSize = true;
            this.lblLane1.Location = new System.Drawing.Point(202, 84);
            this.lblLane1.Name = "lblLane1";
            this.lblLane1.Size = new System.Drawing.Size(14, 15);
            this.lblLane1.TabIndex = 23;
            this.lblLane1.Text = "1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblMinBet);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.udDogNumber);
            this.panel1.Controls.Add(this.txtPlayer3Info);
            this.panel1.Controls.Add(this.txtPlayer2Info);
            this.panel1.Controls.Add(this.txtPlayer1Info);
            this.panel1.Controls.Add(this.lblMaxBet);
            this.panel1.Controls.Add(this.udBetAmount);
            this.panel1.Controls.Add(this.rbPlayer3);
            this.panel1.Controls.Add(this.rbPlayer2);
            this.panel1.Controls.Add(this.rbPlayer1);
            this.panel1.Location = new System.Drawing.Point(16, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 85);
            this.panel1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "On Dog number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bet amount ($)";
            // 
            // udDogNumber
            // 
            this.udDogNumber.Location = new System.Drawing.Point(266, 56);
            this.udDogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udDogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udDogNumber.Name = "udDogNumber";
            this.udDogNumber.ReadOnly = true;
            this.udDogNumber.Size = new System.Drawing.Size(73, 20);
            this.udDogNumber.TabIndex = 8;
            this.udDogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPlayer3Info
            // 
            this.txtPlayer3Info.Location = new System.Drawing.Point(345, 57);
            this.txtPlayer3Info.Name = "txtPlayer3Info";
            this.txtPlayer3Info.ReadOnly = true;
            this.txtPlayer3Info.Size = new System.Drawing.Size(378, 20);
            this.txtPlayer3Info.TabIndex = 7;
            // 
            // txtPlayer2Info
            // 
            this.txtPlayer2Info.Location = new System.Drawing.Point(345, 34);
            this.txtPlayer2Info.Name = "txtPlayer2Info";
            this.txtPlayer2Info.ReadOnly = true;
            this.txtPlayer2Info.Size = new System.Drawing.Size(378, 20);
            this.txtPlayer2Info.TabIndex = 6;
            // 
            // txtPlayer1Info
            // 
            this.txtPlayer1Info.Location = new System.Drawing.Point(345, 11);
            this.txtPlayer1Info.Name = "txtPlayer1Info";
            this.txtPlayer1Info.ReadOnly = true;
            this.txtPlayer1Info.Size = new System.Drawing.Size(378, 20);
            this.txtPlayer1Info.TabIndex = 5;
            // 
            // lblMaxBet
            // 
            this.lblMaxBet.AutoSize = true;
            this.lblMaxBet.Location = new System.Drawing.Point(175, 37);
            this.lblMaxBet.Name = "lblMaxBet";
            this.lblMaxBet.Size = new System.Drawing.Size(79, 15);
            this.lblMaxBet.TabIndex = 4;
            this.lblMaxBet.Text = "Max Bet: $15";
            // 
            // udBetAmount
            // 
            this.udBetAmount.Location = new System.Drawing.Point(266, 12);
            this.udBetAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udBetAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udBetAmount.Name = "udBetAmount";
            this.udBetAmount.ReadOnly = true;
            this.udBetAmount.Size = new System.Drawing.Size(73, 20);
            this.udBetAmount.TabIndex = 3;
            this.udBetAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // rbPlayer3
            // 
            this.rbPlayer3.AutoSize = true;
            this.rbPlayer3.Location = new System.Drawing.Point(3, 58);
            this.rbPlayer3.Name = "rbPlayer3";
            this.rbPlayer3.Size = new System.Drawing.Size(98, 19);
            this.rbPlayer3.TabIndex = 2;
            this.rbPlayer3.TabStop = true;
            this.rbPlayer3.Text = "radioButton3";
            this.rbPlayer3.UseVisualStyleBackColor = true;
            this.rbPlayer3.CheckedChanged += new System.EventHandler(this.rbPlayer3_CheckedChanged);
            // 
            // rbPlayer2
            // 
            this.rbPlayer2.AutoSize = true;
            this.rbPlayer2.Location = new System.Drawing.Point(3, 35);
            this.rbPlayer2.Name = "rbPlayer2";
            this.rbPlayer2.Size = new System.Drawing.Size(98, 19);
            this.rbPlayer2.TabIndex = 1;
            this.rbPlayer2.TabStop = true;
            this.rbPlayer2.Text = "radioButton2";
            this.rbPlayer2.UseVisualStyleBackColor = true;
            this.rbPlayer2.CheckedChanged += new System.EventHandler(this.rbPlayer2_CheckedChanged);
            // 
            // rbPlayer1
            // 
            this.rbPlayer1.AutoSize = true;
            this.rbPlayer1.Location = new System.Drawing.Point(3, 12);
            this.rbPlayer1.Name = "rbPlayer1";
            this.rbPlayer1.Size = new System.Drawing.Size(98, 19);
            this.rbPlayer1.TabIndex = 0;
            this.rbPlayer1.TabStop = true;
            this.rbPlayer1.Text = "radioButton1";
            this.rbPlayer1.UseVisualStyleBackColor = true;
            this.rbPlayer1.CheckedChanged += new System.EventHandler(this.rbPlayer1_CheckedChanged);
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.Location = new System.Drawing.Point(16, 458);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(145, 23);
            this.btnPlaceBet.TabIndex = 20;
            this.btnPlaceBet.Text = "Place Bet";
            this.btnPlaceBet.UseVisualStyleBackColor = true;
            this.btnPlaceBet.Click += new System.EventHandler(this.btnPlaceBet_Click);
            // 
            // btnRace
            // 
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.Location = new System.Drawing.Point(647, 459);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(95, 23);
            this.btnRace.TabIndex = 19;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(549, 459);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Next Round";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.BackgroundImage = global::OOPDogRace.Properties.Resources.StartingRace;
            this.pbRaceTrack.Location = new System.Drawing.Point(100, 57);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(582, 279);
            this.pbRaceTrack.TabIndex = 22;
            this.pbRaceTrack.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblMinBet
            // 
            this.lblMinBet.AutoSize = true;
            this.lblMinBet.Location = new System.Drawing.Point(263, 37);
            this.lblMinBet.Name = "lblMinBet";
            this.lblMinBet.Size = new System.Drawing.Size(69, 15);
            this.lblMinBet.TabIndex = 11;
            this.lblMinBet.Text = "Min Bet: $5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 499);
            this.Controls.Add(this.lblLane2);
            this.Controls.Add(this.lblLane3);
            this.Controls.Add(this.lblLane4);
            this.Controls.Add(this.lblLane1);
            this.Controls.Add(this.pbRaceTrack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPlaceBet);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dog Racing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udDogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLane2;
        private System.Windows.Forms.Label lblLane3;
        private System.Windows.Forms.Label lblLane4;
        private System.Windows.Forms.Label lblLane1;
        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown udDogNumber;
        private System.Windows.Forms.TextBox txtPlayer3Info;
        private System.Windows.Forms.TextBox txtPlayer2Info;
        private System.Windows.Forms.TextBox txtPlayer1Info;
        private System.Windows.Forms.Label lblMaxBet;
        private System.Windows.Forms.NumericUpDown udBetAmount;
        private System.Windows.Forms.RadioButton rbPlayer3;
        private System.Windows.Forms.RadioButton rbPlayer2;
        private System.Windows.Forms.RadioButton rbPlayer1;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblMinBet;
    }
}


namespace ProjectGalgje
{
    partial class frmgalgje
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.woordenIngevenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.woordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblwoord = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.pbHangman = new System.Windows.Forms.PictureBox();
            this.btnB = new ProjectGalgje.RondeButton();
            this.btnN = new ProjectGalgje.RondeButton();
            this.btnA = new ProjectGalgje.RondeButton();
            this.btnZ = new ProjectGalgje.RondeButton();
            this.btnM = new ProjectGalgje.RondeButton();
            this.btnY = new ProjectGalgje.RondeButton();
            this.btnL = new ProjectGalgje.RondeButton();
            this.btnX = new ProjectGalgje.RondeButton();
            this.btnK = new ProjectGalgje.RondeButton();
            this.btnW = new ProjectGalgje.RondeButton();
            this.btnJ = new ProjectGalgje.RondeButton();
            this.btnV = new ProjectGalgje.RondeButton();
            this.btnU = new ProjectGalgje.RondeButton();
            this.btnT = new ProjectGalgje.RondeButton();
            this.btnS = new ProjectGalgje.RondeButton();
            this.btnR = new ProjectGalgje.RondeButton();
            this.btnQ = new ProjectGalgje.RondeButton();
            this.btnP = new ProjectGalgje.RondeButton();
            this.btnO = new ProjectGalgje.RondeButton();
            this.btnI = new ProjectGalgje.RondeButton();
            this.btnH = new ProjectGalgje.RondeButton();
            this.btnG = new ProjectGalgje.RondeButton();
            this.btnF = new ProjectGalgje.RondeButton();
            this.btnE = new ProjectGalgje.RondeButton();
            this.btnD = new ProjectGalgje.RondeButton();
            this.btnC = new ProjectGalgje.RondeButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.woordenIngevenToolStripMenuItem,
            this.woordenToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.afsluitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // woordenIngevenToolStripMenuItem
            // 
            this.woordenIngevenToolStripMenuItem.Name = "woordenIngevenToolStripMenuItem";
            this.woordenIngevenToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.woordenIngevenToolStripMenuItem.Text = "Regels";
            this.woordenIngevenToolStripMenuItem.Click += new System.EventHandler(this.WoordenIngevenToolStripMenuItem_Click);
            // 
            // woordenToolStripMenuItem
            // 
            this.woordenToolStripMenuItem.Name = "woordenToolStripMenuItem";
            this.woordenToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.woordenToolStripMenuItem.Text = "Woorden";
            this.woordenToolStripMenuItem.Click += new System.EventHandler(this.WoordenToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.AfsluitenToolStripMenuItem_Click);
            // 
            // lblwoord
            // 
            this.lblwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwoord.Location = new System.Drawing.Point(99, 406);
            this.lblwoord.Name = "lblwoord";
            this.lblwoord.Size = new System.Drawing.Size(598, 35);
            this.lblwoord.TabIndex = 27;
            this.lblwoord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(354, 163);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(90, 43);
            this.btnstart.TabIndex = 28;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pbHangman
            // 
            this.pbHangman.Location = new System.Drawing.Point(142, 30);
            this.pbHangman.Name = "pbHangman";
            this.pbHangman.Size = new System.Drawing.Size(502, 285);
            this.pbHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHangman.TabIndex = 30;
            this.pbHangman.TabStop = false;
            this.pbHangman.Visible = false;
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnB.Location = new System.Drawing.Point(151, 321);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(38, 38);
            this.btnB.TabIndex = 31;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.BtnB_Click_1);
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnN.Location = new System.Drawing.Point(107, 365);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(38, 38);
            this.btnN.TabIndex = 32;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.BtnN_Click);
            // 
            // btnA
            // 
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(107, 321);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(38, 38);
            this.btnA.TabIndex = 33;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.BtnA_Click_1);
            // 
            // btnZ
            // 
            this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnZ.Location = new System.Drawing.Point(637, 365);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(38, 38);
            this.btnZ.TabIndex = 34;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.BtnZ_Click);
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnM.Location = new System.Drawing.Point(637, 321);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(38, 38);
            this.btnM.TabIndex = 35;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.BtnM_Click);
            // 
            // btnY
            // 
            this.btnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnY.Location = new System.Drawing.Point(593, 365);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(38, 38);
            this.btnY.TabIndex = 36;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.BtnY_Click);
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnL.Location = new System.Drawing.Point(593, 321);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(38, 38);
            this.btnL.TabIndex = 37;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.BtnL_Click);
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnX.Location = new System.Drawing.Point(549, 365);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(38, 38);
            this.btnX.TabIndex = 38;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // btnK
            // 
            this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnK.Location = new System.Drawing.Point(549, 321);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(38, 38);
            this.btnK.TabIndex = 39;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.BtnK_Click);
            // 
            // btnW
            // 
            this.btnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnW.Location = new System.Drawing.Point(505, 365);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(38, 38);
            this.btnW.TabIndex = 40;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.BtnW_Click);
            // 
            // btnJ
            // 
            this.btnJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnJ.Location = new System.Drawing.Point(505, 321);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(38, 38);
            this.btnJ.TabIndex = 41;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.BtnJ_Click);
            // 
            // btnV
            // 
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnV.Location = new System.Drawing.Point(461, 365);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(38, 38);
            this.btnV.TabIndex = 42;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.BtnV_Click);
            // 
            // btnU
            // 
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnU.Location = new System.Drawing.Point(417, 365);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(38, 38);
            this.btnU.TabIndex = 43;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.BtnU_Click);
            // 
            // btnT
            // 
            this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnT.Location = new System.Drawing.Point(371, 365);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(38, 38);
            this.btnT.TabIndex = 44;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.BtnT_Click);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnS.Location = new System.Drawing.Point(327, 365);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(38, 38);
            this.btnS.TabIndex = 45;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.RondeButton15_Click);
            // 
            // btnR
            // 
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnR.Location = new System.Drawing.Point(283, 365);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(38, 38);
            this.btnR.TabIndex = 46;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.BtnR_Click);
            // 
            // btnQ
            // 
            this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnQ.Location = new System.Drawing.Point(239, 365);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(38, 38);
            this.btnQ.TabIndex = 47;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.BtnQ_Click);
            // 
            // btnP
            // 
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnP.Location = new System.Drawing.Point(195, 365);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(38, 38);
            this.btnP.TabIndex = 48;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.BtnP_Click);
            // 
            // btnO
            // 
            this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnO.Location = new System.Drawing.Point(151, 365);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(38, 38);
            this.btnO.TabIndex = 49;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.BtnO_Click);
            // 
            // btnI
            // 
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnI.Location = new System.Drawing.Point(461, 321);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(38, 38);
            this.btnI.TabIndex = 50;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.BtnI_Click);
            // 
            // btnH
            // 
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnH.Location = new System.Drawing.Point(417, 322);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(38, 38);
            this.btnH.TabIndex = 51;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.BtnH_Click);
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnG.Location = new System.Drawing.Point(371, 321);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(38, 38);
            this.btnG.TabIndex = 52;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.BtnG_Click);
            // 
            // btnF
            // 
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnF.Location = new System.Drawing.Point(327, 321);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(38, 38);
            this.btnF.TabIndex = 53;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.RondeButton23_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnE.Location = new System.Drawing.Point(283, 321);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(38, 38);
            this.btnE.TabIndex = 54;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.BtnE_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnD.Location = new System.Drawing.Point(239, 321);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(38, 38);
            this.btnD.TabIndex = 55;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnC.Location = new System.Drawing.Point(195, 321);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(38, 38);
            this.btnC.TabIndex = 56;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // frmgalgje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.pbHangman);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblwoord);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmgalgje";
            this.Text = "Galgje";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmgalgje_FormClosing);
            this.Load += new System.EventHandler(this.Frmgalgje_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem woordenIngevenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem woordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.Label lblwoord;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.PictureBox pbHangman;
        private RondeButton btnB;
        private RondeButton btnN;
        private RondeButton btnA;
        private RondeButton btnZ;
        private RondeButton btnM;
        private RondeButton btnY;
        private RondeButton btnL;
        private RondeButton btnX;
        private RondeButton btnK;
        private RondeButton btnW;
        private RondeButton btnJ;
        private RondeButton btnV;
        private RondeButton btnU;
        private RondeButton btnT;
        private RondeButton btnS;
        private RondeButton btnR;
        private RondeButton btnQ;
        private RondeButton btnP;
        private RondeButton btnO;
        private RondeButton btnI;
        private RondeButton btnH;
        private RondeButton btnG;
        private RondeButton btnF;
        private RondeButton btnE;
        private RondeButton btnD;
        private RondeButton btnC;
    }
}


namespace oefeningen_engels
{
    partial class frmOefenen
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
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtengels = new System.Windows.Forms.TextBox();
            this.txtneder = new System.Windows.Forms.TextBox();
            this.btncontrole = new System.Windows.Forms.Button();
            this.btnopgave = new System.Windows.Forms.Button();
            this.lbleng = new System.Windows.Forms.Label();
            this.lblned = new System.Windows.Forms.Label();
            this.lblantwoord = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(235, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openenToolStripMenuItem,
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // openenToolStripMenuItem
            // 
            this.openenToolStripMenuItem.Name = "openenToolStripMenuItem";
            this.openenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openenToolStripMenuItem.Text = "Openen";
            this.openenToolStripMenuItem.Click += new System.EventHandler(this.OpenenToolStripMenuItem_Click);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.AfsluitenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // txtengels
            // 
            this.txtengels.Location = new System.Drawing.Point(93, 44);
            this.txtengels.Name = "txtengels";
            this.txtengels.Size = new System.Drawing.Size(100, 20);
            this.txtengels.TabIndex = 3;
            // 
            // txtneder
            // 
            this.txtneder.Location = new System.Drawing.Point(93, 92);
            this.txtneder.Name = "txtneder";
            this.txtneder.Size = new System.Drawing.Size(100, 20);
            this.txtneder.TabIndex = 5;
            // 
            // btncontrole
            // 
            this.btncontrole.Location = new System.Drawing.Point(108, 151);
            this.btncontrole.Name = "btncontrole";
            this.btncontrole.Size = new System.Drawing.Size(90, 46);
            this.btncontrole.TabIndex = 7;
            this.btncontrole.Text = "Controle";
            this.btncontrole.UseVisualStyleBackColor = true;
            this.btncontrole.Click += new System.EventHandler(this.Btncontrole_Click);
            // 
            // btnopgave
            // 
            this.btnopgave.Location = new System.Drawing.Point(12, 151);
            this.btnopgave.Name = "btnopgave";
            this.btnopgave.Size = new System.Drawing.Size(90, 46);
            this.btnopgave.TabIndex = 8;
            this.btnopgave.Text = "Opgave";
            this.btnopgave.UseVisualStyleBackColor = true;
            this.btnopgave.Click += new System.EventHandler(this.Btnopgave_Click);
            // 
            // lbleng
            // 
            this.lbleng.AutoSize = true;
            this.lbleng.Location = new System.Drawing.Point(9, 47);
            this.lbleng.Name = "lbleng";
            this.lbleng.Size = new System.Drawing.Size(39, 13);
            this.lbleng.TabIndex = 9;
            this.lbleng.Text = "Engels";
            // 
            // lblned
            // 
            this.lblned.AutoSize = true;
            this.lblned.Location = new System.Drawing.Point(9, 95);
            this.lblned.Name = "lblned";
            this.lblned.Size = new System.Drawing.Size(61, 13);
            this.lblned.TabIndex = 10;
            this.lblned.Text = "Nederlands";
            // 
            // lblantwoord
            // 
            this.lblantwoord.AutoSize = true;
            this.lblantwoord.Location = new System.Drawing.Point(9, 124);
            this.lblantwoord.Name = "lblantwoord";
            this.lblantwoord.Size = new System.Drawing.Size(0, 13);
            this.lblantwoord.TabIndex = 11;
            // 
            // frmOefenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 227);
            this.Controls.Add(this.lblantwoord);
            this.Controls.Add(this.lblned);
            this.Controls.Add(this.lbleng);
            this.Controls.Add(this.btnopgave);
            this.Controls.Add(this.btncontrole);
            this.Controls.Add(this.txtneder);
            this.Controls.Add(this.txtengels);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOefenen";
            this.Text = "Oefenen Engels";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox txtengels;
        private System.Windows.Forms.TextBox txtneder;
        private System.Windows.Forms.Button btncontrole;
        private System.Windows.Forms.Button btnopgave;
        private System.Windows.Forms.Label lbleng;
        private System.Windows.Forms.Label lblned;
        private System.Windows.Forms.Label lblantwoord;
    }
}


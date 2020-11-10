namespace oefeningen_engels
{
    partial class frmvertalen
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
            this.lstbxvertaling = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbleng = new System.Windows.Forms.Label();
            this.lblned = new System.Windows.Forms.Label();
            this.txteng = new System.Windows.Forms.TextBox();
            this.txtned = new System.Windows.Forms.TextBox();
            this.btnverwijderen = new System.Windows.Forms.Button();
            this.btntoevoeg = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxvertaling
            // 
            this.lstbxvertaling.FormattingEnabled = true;
            this.lstbxvertaling.Location = new System.Drawing.Point(12, 55);
            this.lstbxvertaling.Name = "lstbxvertaling";
            this.lstbxvertaling.Size = new System.Drawing.Size(120, 95);
            this.lstbxvertaling.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // sluitenToolStripMenuItem
            // 
            this.sluitenToolStripMenuItem.Name = "sluitenToolStripMenuItem";
            this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sluitenToolStripMenuItem.Text = "Afsluiten";
            this.sluitenToolStripMenuItem.Click += new System.EventHandler(this.SluitenToolStripMenuItem_Click);
            // 
            // lbleng
            // 
            this.lbleng.AutoSize = true;
            this.lbleng.Location = new System.Drawing.Point(138, 55);
            this.lbleng.Name = "lbleng";
            this.lbleng.Size = new System.Drawing.Size(39, 13);
            this.lbleng.TabIndex = 2;
            this.lbleng.Text = "Engels";
            // 
            // lblned
            // 
            this.lblned.AutoSize = true;
            this.lblned.Location = new System.Drawing.Point(138, 101);
            this.lblned.Name = "lblned";
            this.lblned.Size = new System.Drawing.Size(61, 13);
            this.lblned.TabIndex = 3;
            this.lblned.Text = "Nederlands";
            // 
            // txteng
            // 
            this.txteng.Location = new System.Drawing.Point(205, 52);
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(100, 20);
            this.txteng.TabIndex = 4;
            // 
            // txtned
            // 
            this.txtned.Location = new System.Drawing.Point(205, 98);
            this.txtned.Name = "txtned";
            this.txtned.Size = new System.Drawing.Size(100, 20);
            this.txtned.TabIndex = 5;
            // 
            // btnverwijderen
            // 
            this.btnverwijderen.Location = new System.Drawing.Point(164, 177);
            this.btnverwijderen.Name = "btnverwijderen";
            this.btnverwijderen.Size = new System.Drawing.Size(141, 59);
            this.btnverwijderen.TabIndex = 7;
            this.btnverwijderen.Text = "Verwijderen";
            this.btnverwijderen.UseVisualStyleBackColor = true;
            this.btnverwijderen.Click += new System.EventHandler(this.Btnverwijderen_Click);
            // 
            // btntoevoeg
            // 
            this.btntoevoeg.Location = new System.Drawing.Point(12, 177);
            this.btntoevoeg.Name = "btntoevoeg";
            this.btntoevoeg.Size = new System.Drawing.Size(141, 59);
            this.btntoevoeg.TabIndex = 8;
            this.btntoevoeg.Text = "Toevoegen";
            this.btntoevoeg.UseVisualStyleBackColor = true;
            this.btntoevoeg.Click += new System.EventHandler(this.Btntoevoeg_Click);
            // 
            // frmvertalen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.btntoevoeg);
            this.Controls.Add(this.btnverwijderen);
            this.Controls.Add(this.txtned);
            this.Controls.Add(this.txteng);
            this.Controls.Add(this.lblned);
            this.Controls.Add(this.lbleng);
            this.Controls.Add(this.lstbxvertaling);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmvertalen";
            this.Text = "Engels-Nederlands";
            this.Activated += new System.EventHandler(this.Frmvertalen_Activated);
            this.Load += new System.EventHandler(this.Frmvertalen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxvertaling;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sluitenToolStripMenuItem;
        private System.Windows.Forms.Label lbleng;
        private System.Windows.Forms.Label lblned;
        private System.Windows.Forms.TextBox txteng;
        private System.Windows.Forms.TextBox txtned;
        private System.Windows.Forms.Button btnverwijderen;
        private System.Windows.Forms.Button btntoevoeg;
    }
}
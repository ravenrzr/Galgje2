namespace Project1
{
    partial class frmhoofd
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
            this.verkoopsgegevensIngevenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afrekenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eindeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nederlandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txttotaal = new System.Windows.Forms.TextBox();
            this.lbltitel = new System.Windows.Forms.Label();
            this.lstvwartikelen = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbxsort = new System.Windows.Forms.ComboBox();
            this.lblsorteer = new System.Windows.Forms.Label();
            this.lbltotaal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verkoopsgegevensIngevenToolStripMenuItem,
            this.afrekenenToolStripMenuItem,
            this.nieuwToolStripMenuItem,
            this.taalToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verkoopsgegevensIngevenToolStripMenuItem
            // 
            this.verkoopsgegevensIngevenToolStripMenuItem.Name = "verkoopsgegevensIngevenToolStripMenuItem";
            this.verkoopsgegevensIngevenToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.verkoopsgegevensIngevenToolStripMenuItem.Text = "Verkoopsgegevens Ingeven";
            this.verkoopsgegevensIngevenToolStripMenuItem.Click += new System.EventHandler(this.VerkoopsgegevensIngevenToolStripMenuItem_Click);
            // 
            // afrekenenToolStripMenuItem
            // 
            this.afrekenenToolStripMenuItem.Name = "afrekenenToolStripMenuItem";
            this.afrekenenToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.afrekenenToolStripMenuItem.Text = "Afrekening";
            this.afrekenenToolStripMenuItem.Click += new System.EventHandler(this.AfrekenenToolStripMenuItem_Click);
            // 
            // nieuwToolStripMenuItem
            // 
            this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
            this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.nieuwToolStripMenuItem.Text = "Wissen";
            this.nieuwToolStripMenuItem.Click += new System.EventHandler(this.NieuwToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auteurToolStripMenuItem,
            this.eindeToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // auteurToolStripMenuItem
            // 
            this.auteurToolStripMenuItem.Name = "auteurToolStripMenuItem";
            this.auteurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.auteurToolStripMenuItem.Text = "Auteur";
            this.auteurToolStripMenuItem.Click += new System.EventHandler(this.AuteurToolStripMenuItem_Click);
            // 
            // eindeToolStripMenuItem
            // 
            this.eindeToolStripMenuItem.Name = "eindeToolStripMenuItem";
            this.eindeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eindeToolStripMenuItem.Text = "Einde";
            this.eindeToolStripMenuItem.Click += new System.EventHandler(this.EindeToolStripMenuItem_Click);
            // 
            // taalToolStripMenuItem
            // 
            this.taalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nederlandsToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.taalToolStripMenuItem.Name = "taalToolStripMenuItem";
            this.taalToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.taalToolStripMenuItem.Text = "Taal";
            // 
            // nederlandsToolStripMenuItem
            // 
            this.nederlandsToolStripMenuItem.Name = "nederlandsToolStripMenuItem";
            this.nederlandsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.nederlandsToolStripMenuItem.Text = "Nederlands";
            this.nederlandsToolStripMenuItem.Click += new System.EventHandler(this.NederlandsToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
            // 
            // txttotaal
            // 
            this.txttotaal.Location = new System.Drawing.Point(688, 350);
            this.txttotaal.Name = "txttotaal";
            this.txttotaal.ReadOnly = true;
            this.txttotaal.Size = new System.Drawing.Size(100, 20);
            this.txttotaal.TabIndex = 3;
            // 
            // lbltitel
            // 
            this.lbltitel.AutoSize = true;
            this.lbltitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitel.Location = new System.Drawing.Point(12, 51);
            this.lbltitel.Name = "lbltitel";
            this.lbltitel.Size = new System.Drawing.Size(161, 36);
            this.lbltitel.TabIndex = 4;
            this.lbltitel.Text = "Producten";
            // 
            // lstvwartikelen
            // 
            this.lstvwartikelen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstvwartikelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvwartikelen.GridLines = true;
            this.lstvwartikelen.HideSelection = false;
            this.lstvwartikelen.Location = new System.Drawing.Point(18, 96);
            this.lstvwartikelen.Name = "lstvwartikelen";
            this.lstvwartikelen.Size = new System.Drawing.Size(770, 237);
            this.lstvwartikelen.TabIndex = 5;
            this.lstvwartikelen.UseCompatibleStateImageBehavior = false;
            this.lstvwartikelen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Productnaam";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Aantal";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prijs";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "BTW percentage";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Subtotaal";
            this.columnHeader5.Width = 150;
            // 
            // cmbxsort
            // 
            this.cmbxsort.AllowDrop = true;
            this.cmbxsort.FormattingEnabled = true;
            this.cmbxsort.Items.AddRange(new object[] {
            "Oplopend",
            "Aflopend"});
            this.cmbxsort.Location = new System.Drawing.Point(667, 69);
            this.cmbxsort.Name = "cmbxsort";
            this.cmbxsort.Size = new System.Drawing.Size(121, 21);
            this.cmbxsort.TabIndex = 7;
            this.cmbxsort.Text = "Oplopend";
            this.cmbxsort.SelectedIndexChanged += new System.EventHandler(this.Cmbxsort_SelectedIndexChanged);
            // 
            // lblsorteer
            // 
            this.lblsorteer.AutoSize = true;
            this.lblsorteer.Location = new System.Drawing.Point(664, 51);
            this.lblsorteer.Name = "lblsorteer";
            this.lblsorteer.Size = new System.Drawing.Size(41, 13);
            this.lblsorteer.TabIndex = 8;
            this.lblsorteer.Text = "Sorteer";
            // 
            // lbltotaal
            // 
            this.lbltotaal.AutoSize = true;
            this.lbltotaal.Location = new System.Drawing.Point(645, 353);
            this.lbltotaal.Name = "lbltotaal";
            this.lbltotaal.Size = new System.Drawing.Size(37, 13);
            this.lbltotaal.TabIndex = 9;
            this.lbltotaal.Text = "Totaal";
            // 
            // frmhoofd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltotaal);
            this.Controls.Add(this.lblsorteer);
            this.Controls.Add(this.cmbxsort);
            this.Controls.Add(this.lstvwartikelen);
            this.Controls.Add(this.lbltitel);
            this.Controls.Add(this.txttotaal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmhoofd";
            this.Text = "Inventaris";
            this.Load += new System.EventHandler(this.Frmhoofd_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verkoopsgegevensIngevenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afrekenenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eindeToolStripMenuItem;
        private System.Windows.Forms.TextBox txttotaal;
        private System.Windows.Forms.Label lbltitel;
        private System.Windows.Forms.ListView lstvwartikelen;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cmbxsort;
        private System.Windows.Forms.Label lblsorteer;
        private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nederlandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.Label lbltotaal;
    }
}


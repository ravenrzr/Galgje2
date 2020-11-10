namespace ProjectGalgje
{
    partial class frmwoorden
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
            this.lstbxwoorden = new System.Windows.Forms.ListBox();
            this.btninvoegen = new System.Windows.Forms.Button();
            this.txtinvoegen = new System.Windows.Forms.TextBox();
            this.btnverwijderen = new System.Windows.Forms.Button();
            this.btnalle = new System.Windows.Forms.Button();
            this.btnleeg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxwoorden
            // 
            this.lstbxwoorden.FormattingEnabled = true;
            this.lstbxwoorden.Location = new System.Drawing.Point(93, 40);
            this.lstbxwoorden.Name = "lstbxwoorden";
            this.lstbxwoorden.Size = new System.Drawing.Size(100, 160);
            this.lstbxwoorden.TabIndex = 0;
            // 
            // btninvoegen
            // 
            this.btninvoegen.Location = new System.Drawing.Point(12, 12);
            this.btninvoegen.Name = "btninvoegen";
            this.btninvoegen.Size = new System.Drawing.Size(75, 23);
            this.btninvoegen.TabIndex = 1;
            this.btninvoegen.Text = "Invoegen";
            this.btninvoegen.UseVisualStyleBackColor = true;
            this.btninvoegen.Click += new System.EventHandler(this.Btninvoegen_Click);
            // 
            // txtinvoegen
            // 
            this.txtinvoegen.Location = new System.Drawing.Point(93, 14);
            this.txtinvoegen.Name = "txtinvoegen";
            this.txtinvoegen.Size = new System.Drawing.Size(100, 20);
            this.txtinvoegen.TabIndex = 2;
            // 
            // btnverwijderen
            // 
            this.btnverwijderen.Location = new System.Drawing.Point(12, 148);
            this.btnverwijderen.Name = "btnverwijderen";
            this.btnverwijderen.Size = new System.Drawing.Size(75, 23);
            this.btnverwijderen.TabIndex = 3;
            this.btnverwijderen.Text = "Verwijderen";
            this.btnverwijderen.UseVisualStyleBackColor = true;
            this.btnverwijderen.Click += new System.EventHandler(this.Btnverwijderen_Click);
            // 
            // btnalle
            // 
            this.btnalle.Location = new System.Drawing.Point(12, 41);
            this.btnalle.Name = "btnalle";
            this.btnalle.Size = new System.Drawing.Size(75, 23);
            this.btnalle.TabIndex = 4;
            this.btnalle.Text = "Alle";
            this.btnalle.UseVisualStyleBackColor = true;
            this.btnalle.Click += new System.EventHandler(this.Btnalle_Click);
            // 
            // btnleeg
            // 
            this.btnleeg.Location = new System.Drawing.Point(12, 177);
            this.btnleeg.Name = "btnleeg";
            this.btnleeg.Size = new System.Drawing.Size(75, 23);
            this.btnleeg.TabIndex = 5;
            this.btnleeg.Text = "Leeg";
            this.btnleeg.UseVisualStyleBackColor = true;
            this.btnleeg.Click += new System.EventHandler(this.Btnleeg_Click);
            // 
            // frmwoorden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 224);
            this.Controls.Add(this.btnleeg);
            this.Controls.Add(this.btnalle);
            this.Controls.Add(this.btnverwijderen);
            this.Controls.Add(this.txtinvoegen);
            this.Controls.Add(this.btninvoegen);
            this.Controls.Add(this.lstbxwoorden);
            this.Name = "frmwoorden";
            this.Text = "Woorden";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmwoorden_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxwoorden;
        private System.Windows.Forms.Button btninvoegen;
        private System.Windows.Forms.TextBox txtinvoegen;
        private System.Windows.Forms.Button btnverwijderen;
        private System.Windows.Forms.Button btnalle;
        private System.Windows.Forms.Button btnleeg;
    }
}
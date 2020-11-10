namespace Project1
{
    partial class frmsub
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
            this.txtnaam = new System.Windows.Forms.TextBox();
            this.lblnaam = new System.Windows.Forms.Label();
            this.lblprijs = new System.Windows.Forms.Label();
            this.lblbtw = new System.Windows.Forms.Label();
            this.txtprijs = new System.Windows.Forms.TextBox();
            this.btnbewaar = new System.Windows.Forms.Button();
            this.btnnieuw = new System.Windows.Forms.Button();
            this.rdbtn6 = new System.Windows.Forms.RadioButton();
            this.rdbtn12 = new System.Windows.Forms.RadioButton();
            this.rdbtn21 = new System.Windows.Forms.RadioButton();
            this.txtaantal = new System.Windows.Forms.TextBox();
            this.lblaantal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnaam
            // 
            this.txtnaam.Location = new System.Drawing.Point(71, 26);
            this.txtnaam.Name = "txtnaam";
            this.txtnaam.Size = new System.Drawing.Size(100, 20);
            this.txtnaam.TabIndex = 0;
            // 
            // lblnaam
            // 
            this.lblnaam.AutoSize = true;
            this.lblnaam.Location = new System.Drawing.Point(12, 29);
            this.lblnaam.Name = "lblnaam";
            this.lblnaam.Size = new System.Drawing.Size(44, 13);
            this.lblnaam.TabIndex = 1;
            this.lblnaam.Text = "Product";
            // 
            // lblprijs
            // 
            this.lblprijs.AutoSize = true;
            this.lblprijs.Location = new System.Drawing.Point(12, 65);
            this.lblprijs.Name = "lblprijs";
            this.lblprijs.Size = new System.Drawing.Size(26, 13);
            this.lblprijs.TabIndex = 2;
            this.lblprijs.Text = "Prijs";
            // 
            // lblbtw
            // 
            this.lblbtw.AutoSize = true;
            this.lblbtw.Location = new System.Drawing.Point(12, 145);
            this.lblbtw.Name = "lblbtw";
            this.lblbtw.Size = new System.Drawing.Size(56, 13);
            this.lblbtw.TabIndex = 3;
            this.lblbtw.Text = "BTW-perc";
            // 
            // txtprijs
            // 
            this.txtprijs.Location = new System.Drawing.Point(71, 62);
            this.txtprijs.Name = "txtprijs";
            this.txtprijs.Size = new System.Drawing.Size(100, 20);
            this.txtprijs.TabIndex = 4;
            // 
            // btnbewaar
            // 
            this.btnbewaar.Location = new System.Drawing.Point(12, 184);
            this.btnbewaar.Name = "btnbewaar";
            this.btnbewaar.Size = new System.Drawing.Size(83, 43);
            this.btnbewaar.TabIndex = 6;
            this.btnbewaar.Text = "Bewaar";
            this.btnbewaar.UseVisualStyleBackColor = true;
            this.btnbewaar.Click += new System.EventHandler(this.Btnbewaar_Click);
            // 
            // btnnieuw
            // 
            this.btnnieuw.Location = new System.Drawing.Point(101, 184);
            this.btnnieuw.Name = "btnnieuw";
            this.btnnieuw.Size = new System.Drawing.Size(87, 43);
            this.btnnieuw.TabIndex = 7;
            this.btnnieuw.Text = "Nieuw";
            this.btnnieuw.UseVisualStyleBackColor = true;
            this.btnnieuw.Click += new System.EventHandler(this.Btnnieuw_Click);
            // 
            // rdbtn6
            // 
            this.rdbtn6.AutoSize = true;
            this.rdbtn6.Location = new System.Drawing.Point(71, 143);
            this.rdbtn6.Name = "rdbtn6";
            this.rdbtn6.Size = new System.Drawing.Size(31, 17);
            this.rdbtn6.TabIndex = 8;
            this.rdbtn6.TabStop = true;
            this.rdbtn6.Text = "6";
            this.rdbtn6.UseVisualStyleBackColor = true;
            // 
            // rdbtn12
            // 
            this.rdbtn12.AutoSize = true;
            this.rdbtn12.Location = new System.Drawing.Point(108, 143);
            this.rdbtn12.Name = "rdbtn12";
            this.rdbtn12.Size = new System.Drawing.Size(37, 17);
            this.rdbtn12.TabIndex = 9;
            this.rdbtn12.TabStop = true;
            this.rdbtn12.Text = "12";
            this.rdbtn12.UseVisualStyleBackColor = true;
            // 
            // rdbtn21
            // 
            this.rdbtn21.AutoSize = true;
            this.rdbtn21.Location = new System.Drawing.Point(151, 143);
            this.rdbtn21.Name = "rdbtn21";
            this.rdbtn21.Size = new System.Drawing.Size(37, 17);
            this.rdbtn21.TabIndex = 10;
            this.rdbtn21.TabStop = true;
            this.rdbtn21.Text = "21";
            this.rdbtn21.UseVisualStyleBackColor = true;
            // 
            // txtaantal
            // 
            this.txtaantal.Location = new System.Drawing.Point(71, 98);
            this.txtaantal.Name = "txtaantal";
            this.txtaantal.Size = new System.Drawing.Size(100, 20);
            this.txtaantal.TabIndex = 14;
            // 
            // lblaantal
            // 
            this.lblaantal.AutoSize = true;
            this.lblaantal.Location = new System.Drawing.Point(12, 101);
            this.lblaantal.Name = "lblaantal";
            this.lblaantal.Size = new System.Drawing.Size(37, 13);
            this.lblaantal.TabIndex = 13;
            this.lblaantal.Text = "Aantal";
            // 
            // frmsub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 239);
            this.Controls.Add(this.txtaantal);
            this.Controls.Add(this.lblaantal);
            this.Controls.Add(this.rdbtn21);
            this.Controls.Add(this.rdbtn12);
            this.Controls.Add(this.rdbtn6);
            this.Controls.Add(this.btnnieuw);
            this.Controls.Add(this.btnbewaar);
            this.Controls.Add(this.txtprijs);
            this.Controls.Add(this.lblbtw);
            this.Controls.Add(this.lblprijs);
            this.Controls.Add(this.lblnaam);
            this.Controls.Add(this.txtnaam);
            this.Name = "frmsub";
            this.Text = "Ingeven";
            this.Load += new System.EventHandler(this.Frmsub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnaam;
        private System.Windows.Forms.Label lblnaam;
        private System.Windows.Forms.Label lblprijs;
        private System.Windows.Forms.Label lblbtw;
        private System.Windows.Forms.TextBox txtprijs;
        private System.Windows.Forms.Button btnbewaar;
        private System.Windows.Forms.Button btnnieuw;
        private System.Windows.Forms.RadioButton rdbtn6;
        private System.Windows.Forms.RadioButton rdbtn12;
        private System.Windows.Forms.RadioButton rdbtn21;
        private System.Windows.Forms.TextBox txtaantal;
        private System.Windows.Forms.Label lblaantal;
    }
}
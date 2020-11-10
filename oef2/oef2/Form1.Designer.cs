namespace oef2
{
    partial class frmoef2
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
            this.lblaantal = new System.Windows.Forms.Label();
            this.lblingang = new System.Windows.Forms.Label();
            this.lblvoor = new System.Windows.Forms.Label();
            this.lblna = new System.Windows.Forms.Label();
            this.txtaantal = new System.Windows.Forms.TextBox();
            this.txtingang = new System.Windows.Forms.TextBox();
            this.txtvoor = new System.Windows.Forms.TextBox();
            this.txtna = new System.Windows.Forms.TextBox();
            this.btngenereer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblaantal
            // 
            this.lblaantal.AutoSize = true;
            this.lblaantal.Location = new System.Drawing.Point(12, 19);
            this.lblaantal.Name = "lblaantal";
            this.lblaantal.Size = new System.Drawing.Size(79, 13);
            this.lblaantal.TabIndex = 0;
            this.lblaantal.Text = "Aantal Getallen";
            // 
            // lblingang
            // 
            this.lblingang.AutoSize = true;
            this.lblingang.Location = new System.Drawing.Point(12, 57);
            this.lblingang.Name = "lblingang";
            this.lblingang.Size = new System.Drawing.Size(40, 13);
            this.lblingang.TabIndex = 1;
            this.lblingang.Text = "Ingang";
            // 
            // lblvoor
            // 
            this.lblvoor.AutoSize = true;
            this.lblvoor.Location = new System.Drawing.Point(17, 135);
            this.lblvoor.Name = "lblvoor";
            this.lblvoor.Size = new System.Drawing.Size(29, 13);
            this.lblvoor.TabIndex = 2;
            this.lblvoor.Text = "Voor";
            // 
            // lblna
            // 
            this.lblna.AutoSize = true;
            this.lblna.Location = new System.Drawing.Point(17, 287);
            this.lblna.Name = "lblna";
            this.lblna.Size = new System.Drawing.Size(21, 13);
            this.lblna.TabIndex = 3;
            this.lblna.Text = "Na";
            // 
            // txtaantal
            // 
            this.txtaantal.Location = new System.Drawing.Point(97, 16);
            this.txtaantal.Name = "txtaantal";
            this.txtaantal.Size = new System.Drawing.Size(100, 20);
            this.txtaantal.TabIndex = 4;
            // 
            // txtingang
            // 
            this.txtingang.Location = new System.Drawing.Point(97, 54);
            this.txtingang.Name = "txtingang";
            this.txtingang.Size = new System.Drawing.Size(100, 20);
            this.txtingang.TabIndex = 5;
            // 
            // txtvoor
            // 
            this.txtvoor.Location = new System.Drawing.Point(20, 151);
            this.txtvoor.Multiline = true;
            this.txtvoor.Name = "txtvoor";
            this.txtvoor.Size = new System.Drawing.Size(357, 117);
            this.txtvoor.TabIndex = 6;
            // 
            // txtna
            // 
            this.txtna.Location = new System.Drawing.Point(20, 303);
            this.txtna.Multiline = true;
            this.txtna.Name = "txtna";
            this.txtna.Size = new System.Drawing.Size(357, 117);
            this.txtna.TabIndex = 7;
            // 
            // btngenereer
            // 
            this.btngenereer.Location = new System.Drawing.Point(165, 441);
            this.btngenereer.Name = "btngenereer";
            this.btngenereer.Size = new System.Drawing.Size(75, 23);
            this.btngenereer.TabIndex = 8;
            this.btngenereer.Text = "Genereer";
            this.btngenereer.UseVisualStyleBackColor = true;
            this.btngenereer.Click += new System.EventHandler(this.Btngenereer_Click);
            this.btngenereer.Leave += new System.EventHandler(this.Btngenereer_Leave);
            // 
            // frmoef2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 476);
            this.Controls.Add(this.btngenereer);
            this.Controls.Add(this.txtna);
            this.Controls.Add(this.txtvoor);
            this.Controls.Add(this.txtingang);
            this.Controls.Add(this.txtaantal);
            this.Controls.Add(this.lblna);
            this.Controls.Add(this.lblvoor);
            this.Controls.Add(this.lblingang);
            this.Controls.Add(this.lblaantal);
            this.Name = "frmoef2";
            this.Text = "oef2";
            this.Load += new System.EventHandler(this.Frmoef2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblaantal;
        private System.Windows.Forms.Label lblingang;
        private System.Windows.Forms.Label lblvoor;
        private System.Windows.Forms.Label lblna;
        private System.Windows.Forms.TextBox txtaantal;
        private System.Windows.Forms.TextBox txtingang;
        private System.Windows.Forms.TextBox txtvoor;
        private System.Windows.Forms.TextBox txtna;
        private System.Windows.Forms.Button btngenereer;
    }
}


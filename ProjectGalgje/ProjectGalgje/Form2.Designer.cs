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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btninvoegen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnverwijderen = new System.Windows.Forms.Button();
            this.btnalle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(93, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 160);
            this.listBox1.TabIndex = 0;
            // 
            // btninvoegen
            // 
            this.btninvoegen.Location = new System.Drawing.Point(12, 12);
            this.btninvoegen.Name = "btninvoegen";
            this.btninvoegen.Size = new System.Drawing.Size(75, 23);
            this.btninvoegen.TabIndex = 1;
            this.btninvoegen.Text = "Invoegen";
            this.btninvoegen.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnverwijderen
            // 
            this.btnverwijderen.Location = new System.Drawing.Point(12, 40);
            this.btnverwijderen.Name = "btnverwijderen";
            this.btnverwijderen.Size = new System.Drawing.Size(75, 23);
            this.btnverwijderen.TabIndex = 3;
            this.btnverwijderen.Text = "button2";
            this.btnverwijderen.UseVisualStyleBackColor = true;
            // 
            // btnalle
            // 
            this.btnalle.Location = new System.Drawing.Point(12, 177);
            this.btnalle.Name = "btnalle";
            this.btnalle.Size = new System.Drawing.Size(75, 23);
            this.btnalle.TabIndex = 4;
            this.btnalle.Text = "Alle";
            this.btnalle.UseVisualStyleBackColor = true;
            this.btnalle.Click += new System.EventHandler(this.Btnalle_Click);
            // 
            // frmwoorden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 224);
            this.Controls.Add(this.btnalle);
            this.Controls.Add(this.btnverwijderen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btninvoegen);
            this.Controls.Add(this.listBox1);
            this.Name = "frmwoorden";
            this.Text = "Woorden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btninvoegen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnverwijderen;
        private System.Windows.Forms.Button btnalle;
    }
}
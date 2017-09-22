namespace DaveO_Sullivan
{
    partial class frmSupplierNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSuppName = new System.Windows.Forms.TextBox();
            this.newSuppContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.mnuSuppNew = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regMnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSuppNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Name: ";
            // 
            // txtSuppName
            // 
            this.txtSuppName.Location = new System.Drawing.Point(191, 114);
            this.txtSuppName.MaxLength = 10;
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.Size = new System.Drawing.Size(122, 20);
            this.txtSuppName.TabIndex = 1;
            // 
            // newSuppContact
            // 
            this.newSuppContact.Location = new System.Drawing.Point(191, 153);
            this.newSuppContact.MaxLength = 15;
            this.newSuppContact.Name = "newSuppContact";
            this.newSuppContact.Size = new System.Drawing.Size(122, 20);
            this.newSuppContact.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact: ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(191, 72);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "012";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Supplier I.D.";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(191, 234);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(122, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register Supplier";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // mnuSuppNew
            // 
            this.mnuSuppNew.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.regMnuExit});
            this.mnuSuppNew.Location = new System.Drawing.Point(0, 0);
            this.mnuSuppNew.Name = "mnuSuppNew";
            this.mnuSuppNew.Size = new System.Drawing.Size(469, 24);
            this.mnuSuppNew.TabIndex = 7;
            this.mnuSuppNew.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // regMnuExit
            // 
            this.regMnuExit.Name = "regMnuExit";
            this.regMnuExit.Size = new System.Drawing.Size(37, 20);
            this.regMnuExit.Text = "Exit";
            this.regMnuExit.Click += new System.EventHandler(this.regMnuExit_Click);
            // 
            // frmSupplierNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 308);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newSuppContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSuppName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuSuppNew);
            this.MainMenuStrip = this.mnuSuppNew;
            this.Name = "frmSupplierNew";
            this.Text = "New Supplier";
            this.mnuSuppNew.ResumeLayout(false);
            this.mnuSuppNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSuppName;
        private System.Windows.Forms.TextBox newSuppContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.MenuStrip mnuSuppNew;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regMnuExit;
    }
}
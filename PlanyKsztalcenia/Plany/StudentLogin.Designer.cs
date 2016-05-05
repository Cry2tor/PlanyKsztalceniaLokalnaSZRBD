namespace Plany
{
    partial class StudentLogin
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
            this.StudentLoginZaloguj = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentLoginZaloguj
            // 
            this.StudentLoginZaloguj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentLoginZaloguj.Location = new System.Drawing.Point(84, 184);
            this.StudentLoginZaloguj.Name = "StudentLoginZaloguj";
            this.StudentLoginZaloguj.Size = new System.Drawing.Size(93, 33);
            this.StudentLoginZaloguj.TabIndex = 0;
            this.StudentLoginZaloguj.Text = "Zaloguj";
            this.StudentLoginZaloguj.UseVisualStyleBackColor = true;
            this.StudentLoginZaloguj.Click += new System.EventHandler(this.StudentLoginZaloguj_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(118, 53);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(118, 92);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.Size = new System.Drawing.Size(100, 20);
            this.tbHaslo.TabIndex = 2;
            this.tbHaslo.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło:";
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.StudentLoginZaloguj);
            this.Name = "StudentLogin";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentLoginZaloguj;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
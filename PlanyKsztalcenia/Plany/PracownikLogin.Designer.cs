namespace Plany
{
    partial class PracownikLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.PracownikZaloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasło:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login:";
            // 
            // tbHaslo
            // 
            this.tbHaslo.HideSelection = false;
            this.tbHaslo.Location = new System.Drawing.Point(125, 87);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.Size = new System.Drawing.Size(100, 20);
            this.tbHaslo.TabIndex = 7;
            this.tbHaslo.UseSystemPasswordChar = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(125, 48);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 6;
            // 
            // PracownikZaloguj
            // 
            this.PracownikZaloguj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PracownikZaloguj.Location = new System.Drawing.Point(91, 179);
            this.PracownikZaloguj.Name = "PracownikZaloguj";
            this.PracownikZaloguj.Size = new System.Drawing.Size(93, 33);
            this.PracownikZaloguj.TabIndex = 5;
            this.PracownikZaloguj.Text = "Zaloguj";
            this.PracownikZaloguj.UseVisualStyleBackColor = true;
            this.PracownikZaloguj.Click += new System.EventHandler(this.PracownikZaloguj_Click);
            // 
            // PracownikLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.PracownikZaloguj);
            this.Name = "PracownikLogin";
            this.Text = "PracownikLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button PracownikZaloguj;
    }
}
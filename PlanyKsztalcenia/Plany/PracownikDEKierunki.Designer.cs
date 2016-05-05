namespace Plany
{
    partial class PracownikDEKierunki
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbid_kierunek = new System.Windows.Forms.TextBox();
            this.tbnazwa = new System.Windows.Forms.TextBox();
            this.tbwydzial = new System.Windows.Forms.TextBox();
            this.pdeKierunkiZapisz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(68, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "id_kierunku:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(68, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "nazwa:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(68, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "wydział:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbid_kierunek
            // 
            this.tbid_kierunek.Location = new System.Drawing.Point(174, 121);
            this.tbid_kierunek.Name = "tbid_kierunek";
            this.tbid_kierunek.Size = new System.Drawing.Size(100, 20);
            this.tbid_kierunek.TabIndex = 3;
            // 
            // tbnazwa
            // 
            this.tbnazwa.Location = new System.Drawing.Point(174, 166);
            this.tbnazwa.Name = "tbnazwa";
            this.tbnazwa.Size = new System.Drawing.Size(100, 20);
            this.tbnazwa.TabIndex = 4;
            // 
            // tbwydzial
            // 
            this.tbwydzial.Location = new System.Drawing.Point(175, 205);
            this.tbwydzial.Name = "tbwydzial";
            this.tbwydzial.Size = new System.Drawing.Size(100, 20);
            this.tbwydzial.TabIndex = 5;
            // 
            // pdeKierunkiZapisz
            // 
            this.pdeKierunkiZapisz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdeKierunkiZapisz.Location = new System.Drawing.Point(113, 297);
            this.pdeKierunkiZapisz.Name = "pdeKierunkiZapisz";
            this.pdeKierunkiZapisz.Size = new System.Drawing.Size(120, 30);
            this.pdeKierunkiZapisz.TabIndex = 6;
            this.pdeKierunkiZapisz.Text = "Zapisz";
            this.pdeKierunkiZapisz.UseVisualStyleBackColor = true;
            this.pdeKierunkiZapisz.Click += new System.EventHandler(this.pdeKierunkiZapisz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(58, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wprowadź dane:";
            // 
            // PracownikDEKierunki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pdeKierunkiZapisz);
            this.Controls.Add(this.tbwydzial);
            this.Controls.Add(this.tbnazwa);
            this.Controls.Add(this.tbid_kierunek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PracownikDEKierunki";
            this.Text = "Dodaj - Edytuj Kierunki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbid_kierunek;
        private System.Windows.Forms.TextBox tbnazwa;
        private System.Windows.Forms.TextBox tbwydzial;
        private System.Windows.Forms.Button pdeKierunkiZapisz;
        private System.Windows.Forms.Label label4;
    }
}
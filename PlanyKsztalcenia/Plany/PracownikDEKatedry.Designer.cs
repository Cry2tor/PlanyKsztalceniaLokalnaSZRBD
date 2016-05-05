namespace Plany
{
    partial class PracownikDEKatedry
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
            this.pdeKatedraZapisz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbid_katedra = new System.Windows.Forms.TextBox();
            this.tbnazwa = new System.Windows.Forms.TextBox();
            this.tbid_kierunku = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pdeKatedraZapisz
            // 
            this.pdeKatedraZapisz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdeKatedraZapisz.Location = new System.Drawing.Point(100, 291);
            this.pdeKatedraZapisz.Name = "pdeKatedraZapisz";
            this.pdeKatedraZapisz.Size = new System.Drawing.Size(120, 30);
            this.pdeKatedraZapisz.TabIndex = 0;
            this.pdeKatedraZapisz.Text = "Zapisz";
            this.pdeKatedraZapisz.UseVisualStyleBackColor = true;
            this.pdeKatedraZapisz.Click += new System.EventHandler(this.pdeKatedraZapisz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(46, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "id_Katedry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(46, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "nazwa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(46, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "id_kierunku:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(44, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wprowadź dane:";
            // 
            // tbid_katedra
            // 
            this.tbid_katedra.Location = new System.Drawing.Point(168, 98);
            this.tbid_katedra.Name = "tbid_katedra";
            this.tbid_katedra.Size = new System.Drawing.Size(100, 20);
            this.tbid_katedra.TabIndex = 5;
            // 
            // tbnazwa
            // 
            this.tbnazwa.Location = new System.Drawing.Point(168, 142);
            this.tbnazwa.Name = "tbnazwa";
            this.tbnazwa.Size = new System.Drawing.Size(100, 20);
            this.tbnazwa.TabIndex = 6;
            // 
            // tbid_kierunku
            // 
            this.tbid_kierunku.Location = new System.Drawing.Point(168, 184);
            this.tbid_kierunku.Name = "tbid_kierunku";
            this.tbid_kierunku.Size = new System.Drawing.Size(100, 20);
            this.tbid_kierunku.TabIndex = 7;
            // 
            // PracownikDEKatedry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.tbid_kierunku);
            this.Controls.Add(this.tbnazwa);
            this.Controls.Add(this.tbid_katedra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pdeKatedraZapisz);
            this.Name = "PracownikDEKatedry";
            this.Text = "Dodaj - Edytuj Katedry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pdeKatedraZapisz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbid_katedra;
        private System.Windows.Forms.TextBox tbnazwa;
        private System.Windows.Forms.TextBox tbid_kierunku;
    }
}
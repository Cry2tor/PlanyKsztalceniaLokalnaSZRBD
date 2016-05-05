namespace Plany
{
    partial class PracownikDESpecjalnosci
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbid_specjalnosc = new System.Windows.Forms.TextBox();
            this.tbid_katedra = new System.Windows.Forms.TextBox();
            this.tbnazwa = new System.Windows.Forms.TextBox();
            this.tbstopien = new System.Windows.Forms.TextBox();
            this.zapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadź dane:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(38, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "id_specjalnosc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(38, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "id_katedra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(38, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "nazwa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(38, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "stopien:";
            // 
            // tbid_specjalnosc
            // 
            this.tbid_specjalnosc.Location = new System.Drawing.Point(184, 87);
            this.tbid_specjalnosc.Name = "tbid_specjalnosc";
            this.tbid_specjalnosc.Size = new System.Drawing.Size(100, 20);
            this.tbid_specjalnosc.TabIndex = 5;
            // 
            // tbid_katedra
            // 
            this.tbid_katedra.Location = new System.Drawing.Point(184, 128);
            this.tbid_katedra.Name = "tbid_katedra";
            this.tbid_katedra.Size = new System.Drawing.Size(100, 20);
            this.tbid_katedra.TabIndex = 6;
            // 
            // tbnazwa
            // 
            this.tbnazwa.Location = new System.Drawing.Point(184, 171);
            this.tbnazwa.Name = "tbnazwa";
            this.tbnazwa.Size = new System.Drawing.Size(100, 20);
            this.tbnazwa.TabIndex = 7;
            // 
            // tbstopien
            // 
            this.tbstopien.Location = new System.Drawing.Point(184, 213);
            this.tbstopien.Name = "tbstopien";
            this.tbstopien.Size = new System.Drawing.Size(100, 20);
            this.tbstopien.TabIndex = 8;
            // 
            // zapisz
            // 
            this.zapisz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapisz.Location = new System.Drawing.Point(96, 319);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(120, 30);
            this.zapisz.TabIndex = 9;
            this.zapisz.Text = "Zapisz";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // PracownikDESpecjalnosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.zapisz);
            this.Controls.Add(this.tbstopien);
            this.Controls.Add(this.tbnazwa);
            this.Controls.Add(this.tbid_katedra);
            this.Controls.Add(this.tbid_specjalnosc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PracownikDESpecjalnosci";
            this.Text = "Dodaj - Edytuj Specjalnosc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbid_specjalnosc;
        private System.Windows.Forms.TextBox tbid_katedra;
        private System.Windows.Forms.TextBox tbnazwa;
        private System.Windows.Forms.TextBox tbstopien;
        private System.Windows.Forms.Button zapisz;
    }
}
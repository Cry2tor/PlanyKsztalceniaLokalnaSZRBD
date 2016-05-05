namespace Plany
{
    partial class PracownicyDEStypendium
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
            this.tbid_stypendium = new System.Windows.Forms.TextBox();
            this.tbrodzaj = new System.Windows.Forms.TextBox();
            this.tbkwota = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(54, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "id_stypendium:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(54, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rodzaj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(54, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kwota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(52, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wprowadź dane:";
            // 
            // tbid_stypendium
            // 
            this.tbid_stypendium.Location = new System.Drawing.Point(191, 101);
            this.tbid_stypendium.Name = "tbid_stypendium";
            this.tbid_stypendium.Size = new System.Drawing.Size(100, 20);
            this.tbid_stypendium.TabIndex = 4;
            // 
            // tbrodzaj
            // 
            this.tbrodzaj.Location = new System.Drawing.Point(191, 152);
            this.tbrodzaj.Name = "tbrodzaj";
            this.tbrodzaj.Size = new System.Drawing.Size(100, 20);
            this.tbrodzaj.TabIndex = 5;
            // 
            // tbkwota
            // 
            this.tbkwota.Location = new System.Drawing.Point(191, 201);
            this.tbkwota.Name = "tbkwota";
            this.tbkwota.Size = new System.Drawing.Size(100, 20);
            this.tbkwota.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(119, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PracownicyDEStypendium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbkwota);
            this.Controls.Add(this.tbrodzaj);
            this.Controls.Add(this.tbid_stypendium);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PracownicyDEStypendium";
            this.Text = "Dodaj - Edytuj Stypendium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbid_stypendium;
        private System.Windows.Forms.TextBox tbrodzaj;
        private System.Windows.Forms.TextBox tbkwota;
        private System.Windows.Forms.Button button1;
    }
}
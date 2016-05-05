namespace Plany
{
    partial class PracownikKierunki
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pracownikKierunekDodaj = new System.Windows.Forms.Button();
            this.pracownikKierunekEdytuj = new System.Windows.Forms.Button();
            this.pracownikKierunekUsun = new System.Windows.Forms.Button();
            this.pracownikierunekZakoncz = new System.Windows.Forms.Button();
            this.planyDataSet27 = new Plany.PlanyDataSet27();
            this.kierunekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kierunekTableAdapter = new Plany.PlanyDataSet27TableAdapters.kierunekTableAdapter();
            this.idkierunekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wydzialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kierunekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkierunekDataGridViewTextBoxColumn,
            this.wydzialDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kierunekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(111, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 153);
            this.dataGridView1.TabIndex = 0;
            // 
            // pracownikKierunekDodaj
            // 
            this.pracownikKierunekDodaj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pracownikKierunekDodaj.Location = new System.Drawing.Point(85, 256);
            this.pracownikKierunekDodaj.Name = "pracownikKierunekDodaj";
            this.pracownikKierunekDodaj.Size = new System.Drawing.Size(120, 30);
            this.pracownikKierunekDodaj.TabIndex = 1;
            this.pracownikKierunekDodaj.Text = "Dodaj";
            this.pracownikKierunekDodaj.UseVisualStyleBackColor = true;
            this.pracownikKierunekDodaj.Click += new System.EventHandler(this.pracownikKierunekDodaj_Click);
            // 
            // pracownikKierunekEdytuj
            // 
            this.pracownikKierunekEdytuj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pracownikKierunekEdytuj.Location = new System.Drawing.Point(250, 256);
            this.pracownikKierunekEdytuj.Name = "pracownikKierunekEdytuj";
            this.pracownikKierunekEdytuj.Size = new System.Drawing.Size(120, 30);
            this.pracownikKierunekEdytuj.TabIndex = 2;
            this.pracownikKierunekEdytuj.Text = "Edytuj";
            this.pracownikKierunekEdytuj.UseVisualStyleBackColor = true;
            this.pracownikKierunekEdytuj.Click += new System.EventHandler(this.pracownikKierunekEdytuj_Click);
            // 
            // pracownikKierunekUsun
            // 
            this.pracownikKierunekUsun.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pracownikKierunekUsun.Location = new System.Drawing.Point(415, 256);
            this.pracownikKierunekUsun.Name = "pracownikKierunekUsun";
            this.pracownikKierunekUsun.Size = new System.Drawing.Size(120, 30);
            this.pracownikKierunekUsun.TabIndex = 3;
            this.pracownikKierunekUsun.Text = "Usuń";
            this.pracownikKierunekUsun.UseVisualStyleBackColor = true;
            this.pracownikKierunekUsun.Click += new System.EventHandler(this.pracownikKierunekUsun_Click);
            // 
            // pracownikierunekZakoncz
            // 
            this.pracownikierunekZakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pracownikierunekZakoncz.Location = new System.Drawing.Point(552, 319);
            this.pracownikierunekZakoncz.Name = "pracownikierunekZakoncz";
            this.pracownikierunekZakoncz.Size = new System.Drawing.Size(120, 30);
            this.pracownikierunekZakoncz.TabIndex = 4;
            this.pracownikierunekZakoncz.Text = "Zakończ";
            this.pracownikierunekZakoncz.UseVisualStyleBackColor = true;
            this.pracownikierunekZakoncz.Click += new System.EventHandler(this.pracownikierunekZakoncz_Click);
            // 
            // planyDataSet27
            // 
            this.planyDataSet27.DataSetName = "PlanyDataSet27";
            this.planyDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kierunekBindingSource
            // 
            this.kierunekBindingSource.DataMember = "kierunek";
            this.kierunekBindingSource.DataSource = this.planyDataSet27;
            // 
            // kierunekTableAdapter
            // 
            this.kierunekTableAdapter.ClearBeforeFill = true;
            // 
            // idkierunekDataGridViewTextBoxColumn
            // 
            this.idkierunekDataGridViewTextBoxColumn.DataPropertyName = "id_kierunek";
            this.idkierunekDataGridViewTextBoxColumn.HeaderText = "id_kierunek";
            this.idkierunekDataGridViewTextBoxColumn.Name = "idkierunekDataGridViewTextBoxColumn";
            // 
            // wydzialDataGridViewTextBoxColumn
            // 
            this.wydzialDataGridViewTextBoxColumn.DataPropertyName = "wydzial";
            this.wydzialDataGridViewTextBoxColumn.HeaderText = "wydzial";
            this.wydzialDataGridViewTextBoxColumn.Name = "wydzialDataGridViewTextBoxColumn";
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.Width = 150;
            // 
            // PracownikKierunki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.pracownikierunekZakoncz);
            this.Controls.Add(this.pracownikKierunekUsun);
            this.Controls.Add(this.pracownikKierunekEdytuj);
            this.Controls.Add(this.pracownikKierunekDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PracownikKierunki";
            this.Text = "Kierunki";
            this.Load += new System.EventHandler(this.PracownikKierunki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kierunekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button pracownikKierunekDodaj;
        private System.Windows.Forms.Button pracownikKierunekEdytuj;
        private System.Windows.Forms.Button pracownikKierunekUsun;
        private System.Windows.Forms.Button pracownikierunekZakoncz;
        private PlanyDataSet27 planyDataSet27;
        private System.Windows.Forms.BindingSource kierunekBindingSource;
        private PlanyDataSet27TableAdapters.kierunekTableAdapter kierunekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkierunekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydzialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
    }
}
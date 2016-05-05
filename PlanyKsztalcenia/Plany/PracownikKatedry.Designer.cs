namespace Plany
{
    partial class PracownikKatedry
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
            this.pracownikKatedraDodaj = new System.Windows.Forms.Button();
            this.pracownikKatedraEdytuj = new System.Windows.Forms.Button();
            this.pracownikKatedraUsun = new System.Windows.Forms.Button();
            this.pracownikKatedraZakoncz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planyDataSet28 = new Plany.PlanyDataSet28();
            this.katedraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.katedraTableAdapter = new Plany.PlanyDataSet28TableAdapters.katedraTableAdapter();
            this.idkatedraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkierunekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katedraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pracownikKatedraDodaj
            // 
            this.pracownikKatedraDodaj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pracownikKatedraDodaj.Location = new System.Drawing.Point(85, 236);
            this.pracownikKatedraDodaj.Name = "pracownikKatedraDodaj";
            this.pracownikKatedraDodaj.Size = new System.Drawing.Size(120, 30);
            this.pracownikKatedraDodaj.TabIndex = 0;
            this.pracownikKatedraDodaj.Text = "Dodaj";
            this.pracownikKatedraDodaj.UseVisualStyleBackColor = true;
            this.pracownikKatedraDodaj.Click += new System.EventHandler(this.pracownikKatedraDodaj_Click);
            // 
            // pracownikKatedraEdytuj
            // 
            this.pracownikKatedraEdytuj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pracownikKatedraEdytuj.Location = new System.Drawing.Point(238, 236);
            this.pracownikKatedraEdytuj.Name = "pracownikKatedraEdytuj";
            this.pracownikKatedraEdytuj.Size = new System.Drawing.Size(120, 30);
            this.pracownikKatedraEdytuj.TabIndex = 1;
            this.pracownikKatedraEdytuj.Text = "Edytuj";
            this.pracownikKatedraEdytuj.UseVisualStyleBackColor = true;
            this.pracownikKatedraEdytuj.Click += new System.EventHandler(this.pracownikKatedraEdytuj_Click);
            // 
            // pracownikKatedraUsun
            // 
            this.pracownikKatedraUsun.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pracownikKatedraUsun.Location = new System.Drawing.Point(398, 236);
            this.pracownikKatedraUsun.Name = "pracownikKatedraUsun";
            this.pracownikKatedraUsun.Size = new System.Drawing.Size(120, 30);
            this.pracownikKatedraUsun.TabIndex = 2;
            this.pracownikKatedraUsun.Text = "Usuń";
            this.pracownikKatedraUsun.UseVisualStyleBackColor = true;
            this.pracownikKatedraUsun.Click += new System.EventHandler(this.pracownikKatedraUsun_Click);
            // 
            // pracownikKatedraZakoncz
            // 
            this.pracownikKatedraZakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pracownikKatedraZakoncz.Location = new System.Drawing.Point(552, 319);
            this.pracownikKatedraZakoncz.Name = "pracownikKatedraZakoncz";
            this.pracownikKatedraZakoncz.Size = new System.Drawing.Size(120, 30);
            this.pracownikKatedraZakoncz.TabIndex = 3;
            this.pracownikKatedraZakoncz.Text = "Zakończ";
            this.pracownikKatedraZakoncz.UseVisualStyleBackColor = true;
            this.pracownikKatedraZakoncz.Click += new System.EventHandler(this.pracownikKatedraZakoncz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkatedraDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.idkierunekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.katedraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(117, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // planyDataSet28
            // 
            this.planyDataSet28.DataSetName = "PlanyDataSet28";
            this.planyDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // katedraBindingSource
            // 
            this.katedraBindingSource.DataMember = "katedra";
            this.katedraBindingSource.DataSource = this.planyDataSet28;
            // 
            // katedraTableAdapter
            // 
            this.katedraTableAdapter.ClearBeforeFill = true;
            // 
            // idkatedraDataGridViewTextBoxColumn
            // 
            this.idkatedraDataGridViewTextBoxColumn.DataPropertyName = "id_katedra";
            this.idkatedraDataGridViewTextBoxColumn.HeaderText = "id_katedra";
            this.idkatedraDataGridViewTextBoxColumn.Name = "idkatedraDataGridViewTextBoxColumn";
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // idkierunekDataGridViewTextBoxColumn
            // 
            this.idkierunekDataGridViewTextBoxColumn.DataPropertyName = "id_kierunek";
            this.idkierunekDataGridViewTextBoxColumn.HeaderText = "id_kierunek";
            this.idkierunekDataGridViewTextBoxColumn.Name = "idkierunekDataGridViewTextBoxColumn";
            // 
            // PracownikKatedry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pracownikKatedraZakoncz);
            this.Controls.Add(this.pracownikKatedraUsun);
            this.Controls.Add(this.pracownikKatedraEdytuj);
            this.Controls.Add(this.pracownikKatedraDodaj);
            this.Name = "PracownikKatedry";
            this.Text = "Katedry";
            this.Load += new System.EventHandler(this.PracownikKatedry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katedraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pracownikKatedraDodaj;
        private System.Windows.Forms.Button pracownikKatedraEdytuj;
        private System.Windows.Forms.Button pracownikKatedraUsun;
        private System.Windows.Forms.Button pracownikKatedraZakoncz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PlanyDataSet28 planyDataSet28;
        private System.Windows.Forms.BindingSource katedraBindingSource;
        private PlanyDataSet28TableAdapters.katedraTableAdapter katedraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkatedraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkierunekDataGridViewTextBoxColumn;
    }
}
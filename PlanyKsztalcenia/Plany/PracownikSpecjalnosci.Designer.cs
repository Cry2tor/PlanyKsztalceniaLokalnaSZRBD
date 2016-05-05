namespace Plany
{
    partial class PracownikSpecjalnosci
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
            this.dod = new System.Windows.Forms.Button();
            this.edytuje = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.zakoncz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planyDataSet29 = new Plany.PlanyDataSet29();
            this.specjalnoscBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specjalnoscTableAdapter = new Plany.PlanyDataSet29TableAdapters.specjalnoscTableAdapter();
            this.idspecjalnoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkatedraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specjalnoscBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dod
            // 
            this.dod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dod.Location = new System.Drawing.Point(90, 238);
            this.dod.Name = "dod";
            this.dod.Size = new System.Drawing.Size(120, 30);
            this.dod.TabIndex = 0;
            this.dod.Text = "Dodaj";
            this.dod.UseVisualStyleBackColor = true;
            this.dod.Click += new System.EventHandler(this.dod_Click);
            // 
            // edytuje
            // 
            this.edytuje.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytuje.Location = new System.Drawing.Point(259, 238);
            this.edytuje.Name = "edytuje";
            this.edytuje.Size = new System.Drawing.Size(120, 30);
            this.edytuje.TabIndex = 1;
            this.edytuje.Text = "Edytuj";
            this.edytuje.UseVisualStyleBackColor = true;
            this.edytuje.Click += new System.EventHandler(this.edytuje_Click);
            // 
            // usun
            // 
            this.usun.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usun.Location = new System.Drawing.Point(419, 238);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(120, 30);
            this.usun.TabIndex = 2;
            this.usun.Text = "Usuń";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // zakoncz
            // 
            this.zakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zakoncz.Location = new System.Drawing.Point(552, 319);
            this.zakoncz.Name = "zakoncz";
            this.zakoncz.Size = new System.Drawing.Size(120, 30);
            this.zakoncz.TabIndex = 3;
            this.zakoncz.Text = "Zakończ";
            this.zakoncz.UseVisualStyleBackColor = true;
            this.zakoncz.Click += new System.EventHandler(this.zakoncz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idspecjalnoscDataGridViewTextBoxColumn,
            this.idkatedraDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.stopienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.specjalnoscBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(90, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // planyDataSet29
            // 
            this.planyDataSet29.DataSetName = "PlanyDataSet29";
            this.planyDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specjalnoscBindingSource
            // 
            this.specjalnoscBindingSource.DataMember = "specjalnosc";
            this.specjalnoscBindingSource.DataSource = this.planyDataSet29;
            // 
            // specjalnoscTableAdapter
            // 
            this.specjalnoscTableAdapter.ClearBeforeFill = true;
            // 
            // idspecjalnoscDataGridViewTextBoxColumn
            // 
            this.idspecjalnoscDataGridViewTextBoxColumn.DataPropertyName = "id_specjalnosc";
            this.idspecjalnoscDataGridViewTextBoxColumn.HeaderText = "id_specjalnosc";
            this.idspecjalnoscDataGridViewTextBoxColumn.Name = "idspecjalnoscDataGridViewTextBoxColumn";
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
            // stopienDataGridViewTextBoxColumn
            // 
            this.stopienDataGridViewTextBoxColumn.DataPropertyName = "stopien";
            this.stopienDataGridViewTextBoxColumn.HeaderText = "stopien";
            this.stopienDataGridViewTextBoxColumn.Name = "stopienDataGridViewTextBoxColumn";
            // 
            // PracownikSpecjalnosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.zakoncz);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.edytuje);
            this.Controls.Add(this.dod);
            this.Name = "PracownikSpecjalnosci";
            this.Text = "Specjalnosci";
            this.Load += new System.EventHandler(this.PracownikSpecjalnosci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specjalnoscBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dod;
        private System.Windows.Forms.Button edytuje;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Button zakoncz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PlanyDataSet29 planyDataSet29;
        private System.Windows.Forms.BindingSource specjalnoscBindingSource;
        private PlanyDataSet29TableAdapters.specjalnoscTableAdapter specjalnoscTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspecjalnoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkatedraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopienDataGridViewTextBoxColumn;
    }
}
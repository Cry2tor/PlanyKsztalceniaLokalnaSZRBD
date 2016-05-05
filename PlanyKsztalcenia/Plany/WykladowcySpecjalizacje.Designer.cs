namespace Plany
{
    partial class WykladowcySpecjalizacje
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
            this.wykladowcaGrupaZakoncz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planyDataSet26 = new Plany.PlanyDataSet26();
            this.specjalnoscBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specjalnoscTableAdapter = new Plany.PlanyDataSet26TableAdapters.specjalnoscTableAdapter();
            this.idspecjalnoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkatedraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specjalnoscBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // wykladowcaGrupaZakoncz
            // 
            this.wykladowcaGrupaZakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wykladowcaGrupaZakoncz.Location = new System.Drawing.Point(552, 319);
            this.wykladowcaGrupaZakoncz.Name = "wykladowcaGrupaZakoncz";
            this.wykladowcaGrupaZakoncz.Size = new System.Drawing.Size(120, 30);
            this.wykladowcaGrupaZakoncz.TabIndex = 0;
            this.wykladowcaGrupaZakoncz.Text = "Zakończ";
            this.wykladowcaGrupaZakoncz.UseVisualStyleBackColor = true;
            this.wykladowcaGrupaZakoncz.Click += new System.EventHandler(this.wykladowcaGrupaZakoncz_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(77, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 111);
            this.dataGridView1.TabIndex = 4;
            // 
            // planyDataSet26
            // 
            this.planyDataSet26.DataSetName = "PlanyDataSet26";
            this.planyDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specjalnoscBindingSource
            // 
            this.specjalnoscBindingSource.DataMember = "specjalnosc";
            this.specjalnoscBindingSource.DataSource = this.planyDataSet26;
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
            // WykladowcySpecjalizacje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.wykladowcaGrupaZakoncz);
            this.Name = "WykladowcySpecjalizacje";
            this.Text = "Specjalności";
            this.Load += new System.EventHandler(this.WykladowcyGrupy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specjalnoscBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wykladowcaGrupaZakoncz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PlanyDataSet26 planyDataSet26;
        private System.Windows.Forms.BindingSource specjalnoscBindingSource;
        private PlanyDataSet26TableAdapters.specjalnoscTableAdapter specjalnoscTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspecjalnoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkatedraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopienDataGridViewTextBoxColumn;
    }
}
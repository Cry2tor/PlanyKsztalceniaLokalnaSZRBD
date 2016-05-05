namespace Plany
{
    partial class StudentPrzedmioty
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
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilegodzinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typzajecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.przedmiotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planyDataSet22 = new Plany.PlanyDataSet22();
            this.StudentPrzedmiotyZakoncz = new System.Windows.Forms.Button();
            this.przedmiotTableAdapter = new Plany.PlanyDataSet22TableAdapters.przedmiotTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet22)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaDataGridViewTextBoxColumn,
            this.ilegodzinDataGridViewTextBoxColumn,
            this.typzajecDataGridViewTextBoxColumn,
            this.semestrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.przedmiotBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(105, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // ilegodzinDataGridViewTextBoxColumn
            // 
            this.ilegodzinDataGridViewTextBoxColumn.DataPropertyName = "ile_godzin";
            this.ilegodzinDataGridViewTextBoxColumn.HeaderText = "ile_godzin";
            this.ilegodzinDataGridViewTextBoxColumn.Name = "ilegodzinDataGridViewTextBoxColumn";
            // 
            // typzajecDataGridViewTextBoxColumn
            // 
            this.typzajecDataGridViewTextBoxColumn.DataPropertyName = "typ_zajec";
            this.typzajecDataGridViewTextBoxColumn.HeaderText = "typ_zajec";
            this.typzajecDataGridViewTextBoxColumn.Name = "typzajecDataGridViewTextBoxColumn";
            // 
            // semestrDataGridViewTextBoxColumn
            // 
            this.semestrDataGridViewTextBoxColumn.DataPropertyName = "semestr";
            this.semestrDataGridViewTextBoxColumn.HeaderText = "semestr";
            this.semestrDataGridViewTextBoxColumn.Name = "semestrDataGridViewTextBoxColumn";
            // 
            // przedmiotBindingSource
            // 
            this.przedmiotBindingSource.DataMember = "przedmiot";
            this.przedmiotBindingSource.DataSource = this.planyDataSet22;
            // 
            // planyDataSet22
            // 
            this.planyDataSet22.DataSetName = "PlanyDataSet22";
            this.planyDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentPrzedmiotyZakoncz
            // 
            this.StudentPrzedmiotyZakoncz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentPrzedmiotyZakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentPrzedmiotyZakoncz.Location = new System.Drawing.Point(552, 319);
            this.StudentPrzedmiotyZakoncz.Name = "StudentPrzedmiotyZakoncz";
            this.StudentPrzedmiotyZakoncz.Size = new System.Drawing.Size(120, 30);
            this.StudentPrzedmiotyZakoncz.TabIndex = 1;
            this.StudentPrzedmiotyZakoncz.Text = "Zakończ";
            this.StudentPrzedmiotyZakoncz.UseVisualStyleBackColor = true;
            this.StudentPrzedmiotyZakoncz.Click += new System.EventHandler(this.StudentPrzedmiotyZakoncz_Click);
            // 
            // przedmiotTableAdapter
            // 
            this.przedmiotTableAdapter.ClearBeforeFill = true;
            // 
            // StudentPrzedmioty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.StudentPrzedmiotyZakoncz);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentPrzedmioty";
            this.Text = "StudentPrzedmioty";
            this.Load += new System.EventHandler(this.StudentPrzedmioty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet22)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button StudentPrzedmiotyZakoncz;
        private PlanyDataSet22 planyDataSet22;
        private System.Windows.Forms.BindingSource przedmiotBindingSource;
        private PlanyDataSet22TableAdapters.przedmiotTableAdapter przedmiotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilegodzinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typzajecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrDataGridViewTextBoxColumn;
    }
}
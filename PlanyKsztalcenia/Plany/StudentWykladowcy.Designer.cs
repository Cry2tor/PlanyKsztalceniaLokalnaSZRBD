namespace Plany
{
    partial class StudentWykladowcy
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
            this.fStudentWykladowcaZakoncz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pokójDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planyDataSet23 = new Plany.PlanyDataSet23();
            this.pracownicyTableAdapter = new Plany.PlanyDataSet23TableAdapters.pracownicyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet23)).BeginInit();
            this.SuspendLayout();
            // 
            // fStudentWykladowcaZakoncz
            // 
            this.fStudentWykladowcaZakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fStudentWykladowcaZakoncz.Location = new System.Drawing.Point(552, 319);
            this.fStudentWykladowcaZakoncz.Name = "fStudentWykladowcaZakoncz";
            this.fStudentWykladowcaZakoncz.Size = new System.Drawing.Size(120, 30);
            this.fStudentWykladowcaZakoncz.TabIndex = 1;
            this.fStudentWykladowcaZakoncz.Text = "Zakończ";
            this.fStudentWykladowcaZakoncz.UseVisualStyleBackColor = true;
            this.fStudentWykladowcaZakoncz.Click += new System.EventHandler(this.fStudentWykladowcaZakoncz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.plecDataGridViewTextBoxColumn,
            this.pokójDataGridViewTextBoxColumn,
            this.stopienDataGridViewTextBoxColumn,
            this.kategoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pracownicyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 176);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // plecDataGridViewTextBoxColumn
            // 
            this.plecDataGridViewTextBoxColumn.DataPropertyName = "plec";
            this.plecDataGridViewTextBoxColumn.HeaderText = "plec";
            this.plecDataGridViewTextBoxColumn.Name = "plecDataGridViewTextBoxColumn";
            // 
            // pokójDataGridViewTextBoxColumn
            // 
            this.pokójDataGridViewTextBoxColumn.DataPropertyName = "pokój";
            this.pokójDataGridViewTextBoxColumn.HeaderText = "pokój";
            this.pokójDataGridViewTextBoxColumn.Name = "pokójDataGridViewTextBoxColumn";
            // 
            // stopienDataGridViewTextBoxColumn
            // 
            this.stopienDataGridViewTextBoxColumn.DataPropertyName = "stopien";
            this.stopienDataGridViewTextBoxColumn.HeaderText = "stopien";
            this.stopienDataGridViewTextBoxColumn.Name = "stopienDataGridViewTextBoxColumn";
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            this.kategoriaDataGridViewTextBoxColumn.DataPropertyName = "kategoria";
            this.kategoriaDataGridViewTextBoxColumn.HeaderText = "kategoria";
            this.kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            // 
            // pracownicyBindingSource
            // 
            this.pracownicyBindingSource.DataMember = "pracownicy";
            this.pracownicyBindingSource.DataSource = this.planyDataSet23;
            // 
            // planyDataSet23
            // 
            this.planyDataSet23.DataSetName = "PlanyDataSet23";
            this.planyDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pracownicyTableAdapter
            // 
            this.pracownicyTableAdapter.ClearBeforeFill = true;
            // 
            // StudentWykladowcy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fStudentWykladowcaZakoncz);
            this.Name = "StudentWykladowcy";
            this.Text = "StudentWykladowcy";
            this.Load += new System.EventHandler(this.StudentWykladowcy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet23)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button fStudentWykladowcaZakoncz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PlanyDataSet23 planyDataSet23;
        private System.Windows.Forms.BindingSource pracownicyBindingSource;
        private PlanyDataSet23TableAdapters.pracownicyTableAdapter pracownicyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pokójDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
    }
}
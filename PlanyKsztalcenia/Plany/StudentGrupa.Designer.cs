namespace Plany
{
    partial class StudentGrupa
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
            this.planyDataSet3 = new Plany.PlanyDataSet3();
            this.studenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studenciTableAdapter = new Plany.PlanyDataSet3TableAdapters.studenciTableAdapter();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGrupaZakoncz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.plecDataGridViewTextBoxColumn,
            this.grupaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // planyDataSet3
            // 
            this.planyDataSet3.DataSetName = "PlanyDataSet3";
            this.planyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studenciBindingSource
            // 
            this.studenciBindingSource.DataMember = "studenci";
            this.studenciBindingSource.DataSource = this.planyDataSet3;
            // 
            // studenciTableAdapter
            // 
            this.studenciTableAdapter.ClearBeforeFill = true;
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
            // grupaDataGridViewTextBoxColumn
            // 
            this.grupaDataGridViewTextBoxColumn.DataPropertyName = "grupa";
            this.grupaDataGridViewTextBoxColumn.HeaderText = "grupa";
            this.grupaDataGridViewTextBoxColumn.Name = "grupaDataGridViewTextBoxColumn";
            // 
            // StudentGrupaZakoncz
            // 
            this.StudentGrupaZakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentGrupaZakoncz.Location = new System.Drawing.Point(552, 319);
            this.StudentGrupaZakoncz.Name = "StudentGrupaZakoncz";
            this.StudentGrupaZakoncz.Size = new System.Drawing.Size(120, 30);
            this.StudentGrupaZakoncz.TabIndex = 1;
            this.StudentGrupaZakoncz.Text = "Zakończ";
            this.StudentGrupaZakoncz.UseVisualStyleBackColor = true;
            this.StudentGrupaZakoncz.Click += new System.EventHandler(this.StudentGrupaZakoncz_Click);
            // 
            // StudentGrupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.StudentGrupaZakoncz);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentGrupa";
            this.Text = "Grupa Student";
            this.Load += new System.EventHandler(this.StudentGrupa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PlanyDataSet3 planyDataSet3;
        private System.Windows.Forms.BindingSource studenciBindingSource;
        private PlanyDataSet3TableAdapters.studenciTableAdapter studenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button StudentGrupaZakoncz;
    }
}
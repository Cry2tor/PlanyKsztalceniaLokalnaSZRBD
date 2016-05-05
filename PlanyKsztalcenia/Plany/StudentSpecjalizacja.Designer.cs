namespace Plany
{
    partial class StudentSpecjalizacja
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
            this.stopienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specjalnoscBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planyDataSet24 = new Plany.PlanyDataSet24();
            this.StudentSpecjalizacjaZakoncz = new System.Windows.Forms.Button();
            this.specjalnoscTableAdapter = new Plany.PlanyDataSet24TableAdapters.specjalnoscTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specjalnoscBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet24)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaDataGridViewTextBoxColumn,
            this.stopienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.specjalnoscBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(190, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(269, 115);
            this.dataGridView1.TabIndex = 0;
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
            // specjalnoscBindingSource
            // 
            this.specjalnoscBindingSource.DataMember = "specjalnosc";
            this.specjalnoscBindingSource.DataSource = this.planyDataSet24;
            // 
            // planyDataSet24
            // 
            this.planyDataSet24.DataSetName = "PlanyDataSet24";
            this.planyDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentSpecjalizacjaZakoncz
            // 
            this.StudentSpecjalizacjaZakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentSpecjalizacjaZakoncz.Location = new System.Drawing.Point(552, 319);
            this.StudentSpecjalizacjaZakoncz.Name = "StudentSpecjalizacjaZakoncz";
            this.StudentSpecjalizacjaZakoncz.Size = new System.Drawing.Size(120, 30);
            this.StudentSpecjalizacjaZakoncz.TabIndex = 1;
            this.StudentSpecjalizacjaZakoncz.Text = "Zakończ";
            this.StudentSpecjalizacjaZakoncz.UseVisualStyleBackColor = true;
            this.StudentSpecjalizacjaZakoncz.Click += new System.EventHandler(this.StudentSpecjalizacjaZakoncz_Click);
            // 
            // specjalnoscTableAdapter
            // 
            this.specjalnoscTableAdapter.ClearBeforeFill = true;
            // 
            // StudentSpecjalizacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.StudentSpecjalizacjaZakoncz);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentSpecjalizacja";
            this.Text = "Specjalizacja Student";
            this.Load += new System.EventHandler(this.StudentSpecjalizacja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specjalnoscBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet24)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button StudentSpecjalizacjaZakoncz;
        private PlanyDataSet24 planyDataSet24;
        private System.Windows.Forms.BindingSource specjalnoscBindingSource;
        private PlanyDataSet24TableAdapters.specjalnoscTableAdapter specjalnoscTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopienDataGridViewTextBoxColumn;
    }
}
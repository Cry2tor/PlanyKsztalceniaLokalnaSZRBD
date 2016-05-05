namespace Plany
{
    partial class WykładowcaStudenci
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
            this.WykladowcaStudenci = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planyDataSet25 = new Plany.PlanyDataSet25();
            this.studenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studenciTableAdapter = new Plany.PlanyDataSet25TableAdapters.studenciTableAdapter();
            this.idkatedraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // WykladowcaStudenci
            // 
            this.WykladowcaStudenci.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WykladowcaStudenci.Location = new System.Drawing.Point(552, 319);
            this.WykladowcaStudenci.Name = "WykladowcaStudenci";
            this.WykladowcaStudenci.Size = new System.Drawing.Size(120, 30);
            this.WykladowcaStudenci.TabIndex = 0;
            this.WykladowcaStudenci.Text = "Zakończ";
            this.WykladowcaStudenci.UseVisualStyleBackColor = true;
            this.WykladowcaStudenci.Click += new System.EventHandler(this.WykladowcaStudenci_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkatedraDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.plecDataGridViewTextBoxColumn,
            this.grupaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(71, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // planyDataSet25
            // 
            this.planyDataSet25.DataSetName = "PlanyDataSet25";
            this.planyDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studenciBindingSource
            // 
            this.studenciBindingSource.DataMember = "studenci";
            this.studenciBindingSource.DataSource = this.planyDataSet25;
            // 
            // studenciTableAdapter
            // 
            this.studenciTableAdapter.ClearBeforeFill = true;
            // 
            // idkatedraDataGridViewTextBoxColumn
            // 
            this.idkatedraDataGridViewTextBoxColumn.DataPropertyName = "id_katedra";
            this.idkatedraDataGridViewTextBoxColumn.HeaderText = "id_katedra";
            this.idkatedraDataGridViewTextBoxColumn.Name = "idkatedraDataGridViewTextBoxColumn";
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
            // WykładowcaStudenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.WykladowcaStudenci);
            this.Name = "WykładowcaStudenci";
            this.Text = "Studenci";
            this.Load += new System.EventHandler(this.WykładowcaStudenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WykladowcaStudenci;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PlanyDataSet25 planyDataSet25;
        private System.Windows.Forms.BindingSource studenciBindingSource;
        private PlanyDataSet25TableAdapters.studenciTableAdapter studenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkatedraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupaDataGridViewTextBoxColumn;
    }
}
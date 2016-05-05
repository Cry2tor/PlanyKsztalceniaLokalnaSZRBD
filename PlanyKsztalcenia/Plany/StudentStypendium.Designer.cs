namespace Plany
{
    partial class StudentStypendium
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
            this.planyDataSet4 = new Plany.PlanyDataSet4();
            this.stypendiumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stypendiumTableAdapter = new Plany.PlanyDataSet4TableAdapters.stypendiumTableAdapter();
            this.rodzajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentStypendiumZakoncz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stypendiumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rodzajDataGridViewTextBoxColumn,
            this.kwotaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stypendiumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(173, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 93);
            this.dataGridView1.TabIndex = 0;
            // 
            // planyDataSet4
            // 
            this.planyDataSet4.DataSetName = "PlanyDataSet4";
            this.planyDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stypendiumBindingSource
            // 
            this.stypendiumBindingSource.DataMember = "stypendium";
            this.stypendiumBindingSource.DataSource = this.planyDataSet4;
            // 
            // stypendiumTableAdapter
            // 
            this.stypendiumTableAdapter.ClearBeforeFill = true;
            // 
            // rodzajDataGridViewTextBoxColumn
            // 
            this.rodzajDataGridViewTextBoxColumn.DataPropertyName = "rodzaj";
            this.rodzajDataGridViewTextBoxColumn.HeaderText = "rodzaj";
            this.rodzajDataGridViewTextBoxColumn.Name = "rodzajDataGridViewTextBoxColumn";
            // 
            // kwotaDataGridViewTextBoxColumn
            // 
            this.kwotaDataGridViewTextBoxColumn.DataPropertyName = "kwota";
            this.kwotaDataGridViewTextBoxColumn.HeaderText = "kwota";
            this.kwotaDataGridViewTextBoxColumn.Name = "kwotaDataGridViewTextBoxColumn";
            // 
            // StudentStypendiumZakoncz
            // 
            this.StudentStypendiumZakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentStypendiumZakoncz.Location = new System.Drawing.Point(552, 319);
            this.StudentStypendiumZakoncz.Name = "StudentStypendiumZakoncz";
            this.StudentStypendiumZakoncz.Size = new System.Drawing.Size(120, 30);
            this.StudentStypendiumZakoncz.TabIndex = 1;
            this.StudentStypendiumZakoncz.Text = "Zakończ";
            this.StudentStypendiumZakoncz.UseVisualStyleBackColor = true;
            this.StudentStypendiumZakoncz.Click += new System.EventHandler(this.StudentStypendiumZakoncz_Click);
            // 
            // StudentStypendium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.StudentStypendiumZakoncz);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentStypendium";
            this.Text = "Stypendium Student";
            this.Load += new System.EventHandler(this.StudentStypendium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stypendiumBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PlanyDataSet4 planyDataSet4;
        private System.Windows.Forms.BindingSource stypendiumBindingSource;
        private PlanyDataSet4TableAdapters.stypendiumTableAdapter stypendiumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kwotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button StudentStypendiumZakoncz;
    }
}
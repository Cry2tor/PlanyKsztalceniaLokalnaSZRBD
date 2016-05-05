namespace Plany
{
    partial class PracownikStypendium
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
            this.zakoncz = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.edytuj = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.planyDataSet36 = new Plany.PlanyDataSet36();
            this.stypendiumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stypendiumTableAdapter = new Plany.PlanyDataSet36TableAdapters.stypendiumTableAdapter();
            this.idstypendumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stypendiumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstypendumDataGridViewTextBoxColumn,
            this.rodzajDataGridViewTextBoxColumn,
            this.kwotaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stypendiumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(99, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 189);
            this.dataGridView1.TabIndex = 9;
            // 
            // zakoncz
            // 
            this.zakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zakoncz.Location = new System.Drawing.Point(552, 318);
            this.zakoncz.Name = "zakoncz";
            this.zakoncz.Size = new System.Drawing.Size(120, 30);
            this.zakoncz.TabIndex = 8;
            this.zakoncz.Text = "Zakończ";
            this.zakoncz.UseVisualStyleBackColor = true;
            this.zakoncz.Click += new System.EventHandler(this.zakoncz_Click);
            // 
            // usun
            // 
            this.usun.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usun.Location = new System.Drawing.Point(381, 280);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(120, 30);
            this.usun.TabIndex = 7;
            this.usun.Text = "Usuń";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // edytuj
            // 
            this.edytuj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytuj.Location = new System.Drawing.Point(216, 280);
            this.edytuj.Name = "edytuj";
            this.edytuj.Size = new System.Drawing.Size(120, 30);
            this.edytuj.TabIndex = 6;
            this.edytuj.Text = "Edytuj";
            this.edytuj.UseVisualStyleBackColor = true;
            this.edytuj.Click += new System.EventHandler(this.edytuj_Click);
            // 
            // dodaj
            // 
            this.dodaj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj.Location = new System.Drawing.Point(55, 280);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(120, 30);
            this.dodaj.TabIndex = 5;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // planyDataSet36
            // 
            this.planyDataSet36.DataSetName = "PlanyDataSet36";
            this.planyDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stypendiumBindingSource
            // 
            this.stypendiumBindingSource.DataMember = "stypendium";
            this.stypendiumBindingSource.DataSource = this.planyDataSet36;
            // 
            // stypendiumTableAdapter
            // 
            this.stypendiumTableAdapter.ClearBeforeFill = true;
            // 
            // idstypendumDataGridViewTextBoxColumn
            // 
            this.idstypendumDataGridViewTextBoxColumn.DataPropertyName = "id_stypendum";
            this.idstypendumDataGridViewTextBoxColumn.HeaderText = "id_stypendum";
            this.idstypendumDataGridViewTextBoxColumn.Name = "idstypendumDataGridViewTextBoxColumn";
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
            // PracownikStypendium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.zakoncz);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.edytuj);
            this.Controls.Add(this.dodaj);
            this.Name = "PracownikStypendium";
            this.Text = "Stypendium";
            this.Load += new System.EventHandler(this.PracownikStypendium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stypendiumBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button zakoncz;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Button edytuj;
        private System.Windows.Forms.Button dodaj;
        private PlanyDataSet36 planyDataSet36;
        private System.Windows.Forms.BindingSource stypendiumBindingSource;
        private PlanyDataSet36TableAdapters.stypendiumTableAdapter stypendiumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstypendumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kwotaDataGridViewTextBoxColumn;
    }
}
namespace Plany
{
    partial class WykladowcaPrzedmioty
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
            this.wykladowcaPrzedmiotDodaj = new System.Windows.Forms.Button();
            this.wykladowcaPrzedmiotEdytuj = new System.Windows.Forms.Button();
            this.wykladowcaPrzedmiotUsun = new System.Windows.Forms.Button();
            this.WykladowcaPrzedmiotZakoncz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planyDataSet12 = new Plany.PlanyDataSet12();
            this.przedmiotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przedmiotTableAdapter = new Plany.PlanyDataSet12TableAdapters.przedmiotTableAdapter();
            this.idprzedmiotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilegodzinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typzajecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkatedraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idspecjalnoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // wykladowcaPrzedmiotDodaj
            // 
            this.wykladowcaPrzedmiotDodaj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wykladowcaPrzedmiotDodaj.Location = new System.Drawing.Point(25, 265);
            this.wykladowcaPrzedmiotDodaj.Name = "wykladowcaPrzedmiotDodaj";
            this.wykladowcaPrzedmiotDodaj.Size = new System.Drawing.Size(120, 30);
            this.wykladowcaPrzedmiotDodaj.TabIndex = 1;
            this.wykladowcaPrzedmiotDodaj.Text = "Dodaj";
            this.wykladowcaPrzedmiotDodaj.UseVisualStyleBackColor = true;
            this.wykladowcaPrzedmiotDodaj.Click += new System.EventHandler(this.wykladowcaPrzedmiotDodaj_Click);
            // 
            // wykladowcaPrzedmiotEdytuj
            // 
            this.wykladowcaPrzedmiotEdytuj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wykladowcaPrzedmiotEdytuj.Location = new System.Drawing.Point(170, 265);
            this.wykladowcaPrzedmiotEdytuj.Name = "wykladowcaPrzedmiotEdytuj";
            this.wykladowcaPrzedmiotEdytuj.Size = new System.Drawing.Size(120, 30);
            this.wykladowcaPrzedmiotEdytuj.TabIndex = 2;
            this.wykladowcaPrzedmiotEdytuj.Text = "Edytuj";
            this.wykladowcaPrzedmiotEdytuj.UseVisualStyleBackColor = true;
            this.wykladowcaPrzedmiotEdytuj.Click += new System.EventHandler(this.wykladowcaPrzedmiotEdytuj_Click);
            // 
            // wykladowcaPrzedmiotUsun
            // 
            this.wykladowcaPrzedmiotUsun.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wykladowcaPrzedmiotUsun.Location = new System.Drawing.Point(316, 265);
            this.wykladowcaPrzedmiotUsun.Name = "wykladowcaPrzedmiotUsun";
            this.wykladowcaPrzedmiotUsun.Size = new System.Drawing.Size(120, 30);
            this.wykladowcaPrzedmiotUsun.TabIndex = 3;
            this.wykladowcaPrzedmiotUsun.Text = "Usuń";
            this.wykladowcaPrzedmiotUsun.UseVisualStyleBackColor = true;
            this.wykladowcaPrzedmiotUsun.Click += new System.EventHandler(this.wykladowcaPrzedmiotUsun_Click);
            // 
            // WykladowcaPrzedmiotZakoncz
            // 
            this.WykladowcaPrzedmiotZakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WykladowcaPrzedmiotZakoncz.Location = new System.Drawing.Point(552, 319);
            this.WykladowcaPrzedmiotZakoncz.Name = "WykladowcaPrzedmiotZakoncz";
            this.WykladowcaPrzedmiotZakoncz.Size = new System.Drawing.Size(120, 30);
            this.WykladowcaPrzedmiotZakoncz.TabIndex = 4;
            this.WykladowcaPrzedmiotZakoncz.Text = "Zakończ";
            this.WykladowcaPrzedmiotZakoncz.UseVisualStyleBackColor = true;
            this.WykladowcaPrzedmiotZakoncz.Click += new System.EventHandler(this.WykladowcaPrzedmiotZakoncz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprzedmiotDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.ilegodzinDataGridViewTextBoxColumn,
            this.typzajecDataGridViewTextBoxColumn,
            this.semestrDataGridViewTextBoxColumn,
            this.idkatedraDataGridViewTextBoxColumn,
            this.idspecjalnoscDataGridViewTextBoxColumn,
            this.idpracownikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.przedmiotBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // planyDataSet12
            // 
            this.planyDataSet12.DataSetName = "PlanyDataSet12";
            this.planyDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // przedmiotBindingSource
            // 
            this.przedmiotBindingSource.DataMember = "przedmiot";
            this.przedmiotBindingSource.DataSource = this.planyDataSet12;
            // 
            // przedmiotTableAdapter
            // 
            this.przedmiotTableAdapter.ClearBeforeFill = true;
            // 
            // idprzedmiotDataGridViewTextBoxColumn
            // 
            this.idprzedmiotDataGridViewTextBoxColumn.DataPropertyName = "id_przedmiot";
            this.idprzedmiotDataGridViewTextBoxColumn.HeaderText = "id_przedmiot";
            this.idprzedmiotDataGridViewTextBoxColumn.Name = "idprzedmiotDataGridViewTextBoxColumn";
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
            // idkatedraDataGridViewTextBoxColumn
            // 
            this.idkatedraDataGridViewTextBoxColumn.DataPropertyName = "id_katedra";
            this.idkatedraDataGridViewTextBoxColumn.HeaderText = "id_katedra";
            this.idkatedraDataGridViewTextBoxColumn.Name = "idkatedraDataGridViewTextBoxColumn";
            // 
            // idspecjalnoscDataGridViewTextBoxColumn
            // 
            this.idspecjalnoscDataGridViewTextBoxColumn.DataPropertyName = "id_specjalnosc";
            this.idspecjalnoscDataGridViewTextBoxColumn.HeaderText = "id_specjalnosc";
            this.idspecjalnoscDataGridViewTextBoxColumn.Name = "idspecjalnoscDataGridViewTextBoxColumn";
            // 
            // idpracownikDataGridViewTextBoxColumn
            // 
            this.idpracownikDataGridViewTextBoxColumn.DataPropertyName = "id_pracownik";
            this.idpracownikDataGridViewTextBoxColumn.HeaderText = "id_pracownik";
            this.idpracownikDataGridViewTextBoxColumn.Name = "idpracownikDataGridViewTextBoxColumn";
            // 
            // WykladowcaPrzedmioty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.WykladowcaPrzedmiotZakoncz);
            this.Controls.Add(this.wykladowcaPrzedmiotUsun);
            this.Controls.Add(this.wykladowcaPrzedmiotEdytuj);
            this.Controls.Add(this.wykladowcaPrzedmiotDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WykladowcaPrzedmioty";
            this.Text = "Przedmioty Wykladowca";
            this.Load += new System.EventHandler(this.WykladowcaPrzedmioty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button wykladowcaPrzedmiotDodaj;
        private System.Windows.Forms.Button wykladowcaPrzedmiotEdytuj;
        private System.Windows.Forms.Button wykladowcaPrzedmiotUsun;
        private System.Windows.Forms.Button WykladowcaPrzedmiotZakoncz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PlanyDataSet12 planyDataSet12;
        private System.Windows.Forms.BindingSource przedmiotBindingSource;
        private PlanyDataSet12TableAdapters.przedmiotTableAdapter przedmiotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprzedmiotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilegodzinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typzajecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkatedraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspecjalnoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpracownikDataGridViewTextBoxColumn;
    }
}
namespace Plany
{
    partial class PracownikPrzedmioty
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
            this.dodaj = new System.Windows.Forms.Button();
            this.edytuj = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.Zakoncz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planyDataSet19 = new Plany.PlanyDataSet19();
            this.przedmiotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przedmiotTableAdapter = new Plany.PlanyDataSet19TableAdapters.przedmiotTableAdapter();
            this.idprzedmiotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilegodzinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typzajecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkatedraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idspecjalnoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dodaj
            // 
            this.dodaj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj.Location = new System.Drawing.Point(59, 276);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(120, 30);
            this.dodaj.TabIndex = 0;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // edytuj
            // 
            this.edytuj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytuj.Location = new System.Drawing.Point(210, 276);
            this.edytuj.Name = "edytuj";
            this.edytuj.Size = new System.Drawing.Size(120, 30);
            this.edytuj.TabIndex = 1;
            this.edytuj.Text = "Edytuj";
            this.edytuj.UseVisualStyleBackColor = true;
            this.edytuj.Click += new System.EventHandler(this.edytuj_Click);
            // 
            // usun
            // 
            this.usun.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usun.Location = new System.Drawing.Point(364, 276);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(120, 30);
            this.usun.TabIndex = 2;
            this.usun.Text = "Usuń";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // Zakoncz
            // 
            this.Zakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zakoncz.Location = new System.Drawing.Point(552, 319);
            this.Zakoncz.Name = "Zakoncz";
            this.Zakoncz.Size = new System.Drawing.Size(120, 30);
            this.Zakoncz.TabIndex = 3;
            this.Zakoncz.Text = "Zakończ";
            this.Zakoncz.UseVisualStyleBackColor = true;
            this.Zakoncz.Click += new System.EventHandler(this.Zakoncz_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(25, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 140);
            this.dataGridView1.TabIndex = 4;
            // 
            // planyDataSet19
            // 
            this.planyDataSet19.DataSetName = "PlanyDataSet19";
            this.planyDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // przedmiotBindingSource
            // 
            this.przedmiotBindingSource.DataMember = "przedmiot";
            this.przedmiotBindingSource.DataSource = this.planyDataSet19;
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
            // PracownikPrzedmioty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Zakoncz);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.edytuj);
            this.Controls.Add(this.dodaj);
            this.Name = "PracownikPrzedmioty";
            this.Text = "Przedmioty";
            this.Load += new System.EventHandler(this.PracownikPrzedmioty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button edytuj;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Button Zakoncz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PlanyDataSet19 planyDataSet19;
        private System.Windows.Forms.BindingSource przedmiotBindingSource;
        private PlanyDataSet19TableAdapters.przedmiotTableAdapter przedmiotTableAdapter;
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
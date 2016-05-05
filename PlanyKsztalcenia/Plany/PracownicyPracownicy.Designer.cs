namespace Plany
{
    partial class PracownicyPracownicy
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
            this.planyDataSet31 = new Plany.PlanyDataSet31();
            this.pracownicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownicyTableAdapter = new Plany.PlanyDataSet31TableAdapters.pracownicyTableAdapter();
            this.idpracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idwykladowcyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkatedraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obecnoscdzieciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iledzieciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pokójDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czywykladowcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokurodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpracownikDataGridViewTextBoxColumn,
            this.idwykladowcyDataGridViewTextBoxColumn,
            this.idkatedraDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.obecnoscdzieciDataGridViewTextBoxColumn,
            this.iledzieciDataGridViewTextBoxColumn,
            this.plecDataGridViewTextBoxColumn,
            this.pokójDataGridViewTextBoxColumn,
            this.stopienDataGridViewTextBoxColumn,
            this.kategoriaDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.hasloDataGridViewTextBoxColumn,
            this.czywykladowcaDataGridViewTextBoxColumn,
            this.rokurodzeniaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pracownicyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 189);
            this.dataGridView1.TabIndex = 9;
            // 
            // zakoncz
            // 
            this.zakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zakoncz.Location = new System.Drawing.Point(552, 294);
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
            this.usun.Location = new System.Drawing.Point(381, 256);
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
            this.edytuj.Location = new System.Drawing.Point(216, 256);
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
            this.dodaj.Location = new System.Drawing.Point(55, 256);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(120, 30);
            this.dodaj.TabIndex = 5;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // planyDataSet31
            // 
            this.planyDataSet31.DataSetName = "PlanyDataSet31";
            this.planyDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pracownicyBindingSource
            // 
            this.pracownicyBindingSource.DataMember = "pracownicy";
            this.pracownicyBindingSource.DataSource = this.planyDataSet31;
            // 
            // pracownicyTableAdapter
            // 
            this.pracownicyTableAdapter.ClearBeforeFill = true;
            // 
            // idpracownikDataGridViewTextBoxColumn
            // 
            this.idpracownikDataGridViewTextBoxColumn.DataPropertyName = "id_pracownik";
            this.idpracownikDataGridViewTextBoxColumn.HeaderText = "id_pracownik";
            this.idpracownikDataGridViewTextBoxColumn.Name = "idpracownikDataGridViewTextBoxColumn";
            // 
            // idwykladowcyDataGridViewTextBoxColumn
            // 
            this.idwykladowcyDataGridViewTextBoxColumn.DataPropertyName = "id_wykladowcy";
            this.idwykladowcyDataGridViewTextBoxColumn.HeaderText = "id_wykladowcy";
            this.idwykladowcyDataGridViewTextBoxColumn.Name = "idwykladowcyDataGridViewTextBoxColumn";
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
            // obecnoscdzieciDataGridViewTextBoxColumn
            // 
            this.obecnoscdzieciDataGridViewTextBoxColumn.DataPropertyName = "obecnosc_dzieci";
            this.obecnoscdzieciDataGridViewTextBoxColumn.HeaderText = "obecnosc_dzieci";
            this.obecnoscdzieciDataGridViewTextBoxColumn.Name = "obecnoscdzieciDataGridViewTextBoxColumn";
            // 
            // iledzieciDataGridViewTextBoxColumn
            // 
            this.iledzieciDataGridViewTextBoxColumn.DataPropertyName = "ile_dzieci";
            this.iledzieciDataGridViewTextBoxColumn.HeaderText = "ile_dzieci";
            this.iledzieciDataGridViewTextBoxColumn.Name = "iledzieciDataGridViewTextBoxColumn";
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
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // hasloDataGridViewTextBoxColumn
            // 
            this.hasloDataGridViewTextBoxColumn.DataPropertyName = "haslo";
            this.hasloDataGridViewTextBoxColumn.HeaderText = "haslo";
            this.hasloDataGridViewTextBoxColumn.Name = "hasloDataGridViewTextBoxColumn";
            // 
            // czywykladowcaDataGridViewTextBoxColumn
            // 
            this.czywykladowcaDataGridViewTextBoxColumn.DataPropertyName = "czy_wykladowca";
            this.czywykladowcaDataGridViewTextBoxColumn.HeaderText = "czy_wykladowca";
            this.czywykladowcaDataGridViewTextBoxColumn.Name = "czywykladowcaDataGridViewTextBoxColumn";
            // 
            // rokurodzeniaDataGridViewTextBoxColumn
            // 
            this.rokurodzeniaDataGridViewTextBoxColumn.DataPropertyName = "rok_urodzenia";
            this.rokurodzeniaDataGridViewTextBoxColumn.HeaderText = "rok_urodzenia";
            this.rokurodzeniaDataGridViewTextBoxColumn.Name = "rokurodzeniaDataGridViewTextBoxColumn";
            // 
            // PracownicyPracownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.zakoncz);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.edytuj);
            this.Controls.Add(this.dodaj);
            this.Name = "PracownicyPracownicy";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.PracownicyPracownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button zakoncz;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Button edytuj;
        private System.Windows.Forms.Button dodaj;
        private PlanyDataSet31 planyDataSet31;
        private System.Windows.Forms.BindingSource pracownicyBindingSource;
        private PlanyDataSet31TableAdapters.pracownicyTableAdapter pracownicyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpracownikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idwykladowcyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkatedraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obecnoscdzieciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iledzieciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pokójDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czywykladowcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokurodzeniaDataGridViewTextBoxColumn;
    }
}
namespace Plany
{
    partial class PracownicyStudenci
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
            this.zakoncz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planyDataSet30 = new Plany.PlanyDataSet30();
            this.studenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studenciTableAdapter = new Plany.PlanyDataSet30TableAdapters.studenciTableAdapter();
            this.idstudenciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkatedraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstypendumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idspecjalnoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkierunekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obecnoscdzieciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iledzieciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokurodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dodaj
            // 
            this.dodaj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj.Location = new System.Drawing.Point(55, 281);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(120, 30);
            this.dodaj.TabIndex = 0;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // edytuj
            // 
            this.edytuj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytuj.Location = new System.Drawing.Point(216, 281);
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
            this.usun.Location = new System.Drawing.Point(381, 281);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(120, 30);
            this.usun.TabIndex = 2;
            this.usun.Text = "Usuń";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // zakoncz
            // 
            this.zakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zakoncz.Location = new System.Drawing.Point(552, 319);
            this.zakoncz.Name = "zakoncz";
            this.zakoncz.Size = new System.Drawing.Size(120, 30);
            this.zakoncz.TabIndex = 3;
            this.zakoncz.Text = "Zakończ";
            this.zakoncz.UseVisualStyleBackColor = true;
            this.zakoncz.Click += new System.EventHandler(this.zakoncz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstudenciDataGridViewTextBoxColumn,
            this.idkatedraDataGridViewTextBoxColumn,
            this.idstypendumDataGridViewTextBoxColumn,
            this.idspecjalnoscDataGridViewTextBoxColumn,
            this.idkierunekDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.obecnoscdzieciDataGridViewTextBoxColumn,
            this.iledzieciDataGridViewTextBoxColumn,
            this.plecDataGridViewTextBoxColumn,
            this.grupaDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.hasloDataGridViewTextBoxColumn,
            this.rokurodzeniaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 189);
            this.dataGridView1.TabIndex = 4;
            // 
            // planyDataSet30
            // 
            this.planyDataSet30.DataSetName = "PlanyDataSet30";
            this.planyDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studenciBindingSource
            // 
            this.studenciBindingSource.DataMember = "studenci";
            this.studenciBindingSource.DataSource = this.planyDataSet30;
            // 
            // studenciTableAdapter
            // 
            this.studenciTableAdapter.ClearBeforeFill = true;
            // 
            // idstudenciDataGridViewTextBoxColumn
            // 
            this.idstudenciDataGridViewTextBoxColumn.DataPropertyName = "id_studenci";
            this.idstudenciDataGridViewTextBoxColumn.HeaderText = "id_studenci";
            this.idstudenciDataGridViewTextBoxColumn.Name = "idstudenciDataGridViewTextBoxColumn";
            // 
            // idkatedraDataGridViewTextBoxColumn
            // 
            this.idkatedraDataGridViewTextBoxColumn.DataPropertyName = "id_katedra";
            this.idkatedraDataGridViewTextBoxColumn.HeaderText = "id_katedra";
            this.idkatedraDataGridViewTextBoxColumn.Name = "idkatedraDataGridViewTextBoxColumn";
            // 
            // idstypendumDataGridViewTextBoxColumn
            // 
            this.idstypendumDataGridViewTextBoxColumn.DataPropertyName = "id_stypendum";
            this.idstypendumDataGridViewTextBoxColumn.HeaderText = "id_stypendum";
            this.idstypendumDataGridViewTextBoxColumn.Name = "idstypendumDataGridViewTextBoxColumn";
            // 
            // idspecjalnoscDataGridViewTextBoxColumn
            // 
            this.idspecjalnoscDataGridViewTextBoxColumn.DataPropertyName = "id_specjalnosc";
            this.idspecjalnoscDataGridViewTextBoxColumn.HeaderText = "id_specjalnosc";
            this.idspecjalnoscDataGridViewTextBoxColumn.Name = "idspecjalnoscDataGridViewTextBoxColumn";
            // 
            // idkierunekDataGridViewTextBoxColumn
            // 
            this.idkierunekDataGridViewTextBoxColumn.DataPropertyName = "id_kierunek";
            this.idkierunekDataGridViewTextBoxColumn.HeaderText = "id_kierunek";
            this.idkierunekDataGridViewTextBoxColumn.Name = "idkierunekDataGridViewTextBoxColumn";
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
            // grupaDataGridViewTextBoxColumn
            // 
            this.grupaDataGridViewTextBoxColumn.DataPropertyName = "grupa";
            this.grupaDataGridViewTextBoxColumn.HeaderText = "grupa";
            this.grupaDataGridViewTextBoxColumn.Name = "grupaDataGridViewTextBoxColumn";
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
            // rokurodzeniaDataGridViewTextBoxColumn
            // 
            this.rokurodzeniaDataGridViewTextBoxColumn.DataPropertyName = "rok_urodzenia";
            this.rokurodzeniaDataGridViewTextBoxColumn.HeaderText = "rok_urodzenia";
            this.rokurodzeniaDataGridViewTextBoxColumn.Name = "rokurodzeniaDataGridViewTextBoxColumn";
            // 
            // PracownicyStudenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.zakoncz);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.edytuj);
            this.Controls.Add(this.dodaj);
            this.Name = "PracownicyStudenci";
            this.Text = "Studenci";
            this.Load += new System.EventHandler(this.PracownicyStudenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planyDataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button edytuj;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Button zakoncz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PlanyDataSet30 planyDataSet30;
        private System.Windows.Forms.BindingSource studenciBindingSource;
        private PlanyDataSet30TableAdapters.studenciTableAdapter studenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstudenciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkatedraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstypendumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspecjalnoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkierunekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obecnoscdzieciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iledzieciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokurodzeniaDataGridViewTextBoxColumn;
    }
}
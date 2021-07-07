namespace WindowsFormsApplication1.DoctorPages
{
    partial class DoctorMainPage
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
            this.hASTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.hASTATableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.HASTATableAdapter();
            this.muayaneBekHastalarTab = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.muayeneBekleyenHastalarDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bransGroupBox = new System.Windows.Forms.GroupBox();
            this.unvanLabel = new System.Windows.Forms.Label();
            this.bransLabel = new System.Windows.Forms.Label();
            this.poliklinikLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iletisimGroupBox = new System.Windows.Forms.GroupBox();
            this.adresLabel = new System.Windows.Forms.Label();
            this.isTelLabel = new System.Windows.Forms.Label();
            this.cepTelLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.kimlikGroupBox = new System.Windows.Forms.GroupBox();
            this.dogumTarihiLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cinsiyetLabel = new System.Windows.Forms.Label();
            this.tcLabel = new System.Windows.Forms.Label();
            this.soyadLabel = new System.Windows.Forms.Label();
            this.adLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.hastalarDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hASTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.muayaneBekHastalarTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muayeneBekleyenHastalarDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.bransGroupBox.SuspendLayout();
            this.iletisimGroupBox.SuspendLayout();
            this.kimlikGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hASTABindingSource
            // 
            this.hASTABindingSource.DataMember = "HASTA";
            this.hASTABindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hASTATableAdapter
            // 
            this.hASTATableAdapter.ClearBeforeFill = true;
            // 
            // muayaneBekHastalarTab
            // 
            this.muayaneBekHastalarTab.Controls.Add(this.label11);
            this.muayaneBekHastalarTab.Controls.Add(this.muayeneBekleyenHastalarDataGridView);
            this.muayaneBekHastalarTab.Location = new System.Drawing.Point(4, 22);
            this.muayaneBekHastalarTab.Name = "muayaneBekHastalarTab";
            this.muayaneBekHastalarTab.Padding = new System.Windows.Forms.Padding(3);
            this.muayaneBekHastalarTab.Size = new System.Drawing.Size(559, 437);
            this.muayaneBekHastalarTab.TabIndex = 3;
            this.muayaneBekHastalarTab.Text = "Muayene Bekleyen Hastalar";
            this.muayaneBekHastalarTab.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(16, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(439, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Muayeneyi tamamlamak için satırın sol kenarındaki boşluğa tıklayınız!";
            // 
            // muayeneBekleyenHastalarDataGridView
            // 
            this.muayeneBekleyenHastalarDataGridView.AllowUserToAddRows = false;
            this.muayeneBekleyenHastalarDataGridView.AllowUserToDeleteRows = false;
            this.muayeneBekleyenHastalarDataGridView.AllowUserToOrderColumns = true;
            this.muayeneBekleyenHastalarDataGridView.AllowUserToResizeColumns = false;
            this.muayeneBekleyenHastalarDataGridView.AllowUserToResizeRows = false;
            this.muayeneBekleyenHastalarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.muayeneBekleyenHastalarDataGridView.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.muayeneBekleyenHastalarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.muayeneBekleyenHastalarDataGridView.Location = new System.Drawing.Point(19, 63);
            this.muayeneBekleyenHastalarDataGridView.Name = "muayeneBekleyenHastalarDataGridView";
            this.muayeneBekleyenHastalarDataGridView.ReadOnly = true;
            this.muayeneBekleyenHastalarDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.muayeneBekleyenHastalarDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.muayeneBekleyenHastalarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.muayeneBekleyenHastalarDataGridView.Size = new System.Drawing.Size(516, 351);
            this.muayeneBekleyenHastalarDataGridView.TabIndex = 4;
            this.muayeneBekleyenHastalarDataGridView.VirtualMode = true;
            this.muayeneBekleyenHastalarDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.muayeneBekleyenHastalarDataGridView_RowHeaderMouseDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bransGroupBox);
            this.tabPage1.Controls.Add(this.iletisimGroupBox);
            this.tabPage1.Controls.Add(this.kimlikGroupBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(559, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doktor Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bransGroupBox
            // 
            this.bransGroupBox.Controls.Add(this.unvanLabel);
            this.bransGroupBox.Controls.Add(this.bransLabel);
            this.bransGroupBox.Controls.Add(this.poliklinikLabel);
            this.bransGroupBox.Controls.Add(this.label10);
            this.bransGroupBox.Controls.Add(this.label9);
            this.bransGroupBox.Controls.Add(this.label8);
            this.bransGroupBox.Location = new System.Drawing.Point(17, 312);
            this.bransGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.bransGroupBox.Name = "bransGroupBox";
            this.bransGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.bransGroupBox.Size = new System.Drawing.Size(462, 108);
            this.bransGroupBox.TabIndex = 9;
            this.bransGroupBox.TabStop = false;
            this.bransGroupBox.Text = "Branş Bilgileri";
            // 
            // unvanLabel
            // 
            this.unvanLabel.AutoSize = true;
            this.unvanLabel.Location = new System.Drawing.Point(86, 79);
            this.unvanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unvanLabel.Name = "unvanLabel";
            this.unvanLabel.Size = new System.Drawing.Size(63, 13);
            this.unvanLabel.TabIndex = 5;
            this.unvanLabel.Text = "unvanLabel";
            // 
            // bransLabel
            // 
            this.bransLabel.AutoSize = true;
            this.bransLabel.Location = new System.Drawing.Point(87, 54);
            this.bransLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bransLabel.Name = "bransLabel";
            this.bransLabel.Size = new System.Drawing.Size(59, 13);
            this.bransLabel.TabIndex = 4;
            this.bransLabel.Text = "bransLabel";
            // 
            // poliklinikLabel
            // 
            this.poliklinikLabel.AutoSize = true;
            this.poliklinikLabel.Location = new System.Drawing.Point(86, 28);
            this.poliklinikLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.poliklinikLabel.Name = "poliklinikLabel";
            this.poliklinikLabel.Size = new System.Drawing.Size(73, 13);
            this.poliklinikLabel.TabIndex = 3;
            this.poliklinikLabel.Text = "poliklinikLabel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ünvan:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Poliklinik:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Branş:";
            // 
            // iletisimGroupBox
            // 
            this.iletisimGroupBox.Controls.Add(this.adresLabel);
            this.iletisimGroupBox.Controls.Add(this.isTelLabel);
            this.iletisimGroupBox.Controls.Add(this.cepTelLabel);
            this.iletisimGroupBox.Controls.Add(this.label6);
            this.iletisimGroupBox.Controls.Add(this.label7);
            this.iletisimGroupBox.Controls.Add(this.label13);
            this.iletisimGroupBox.Location = new System.Drawing.Point(17, 180);
            this.iletisimGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.iletisimGroupBox.Name = "iletisimGroupBox";
            this.iletisimGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.iletisimGroupBox.Size = new System.Drawing.Size(462, 115);
            this.iletisimGroupBox.TabIndex = 8;
            this.iletisimGroupBox.TabStop = false;
            this.iletisimGroupBox.Text = "İletişim Bilgileri";
            // 
            // adresLabel
            // 
            this.adresLabel.AutoSize = true;
            this.adresLabel.Location = new System.Drawing.Point(86, 76);
            this.adresLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adresLabel.Name = "adresLabel";
            this.adresLabel.Size = new System.Drawing.Size(59, 13);
            this.adresLabel.TabIndex = 19;
            this.adresLabel.Text = "adresLabel";
            // 
            // isTelLabel
            // 
            this.isTelLabel.AutoSize = true;
            this.isTelLabel.Location = new System.Drawing.Point(87, 52);
            this.isTelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isTelLabel.Name = "isTelLabel";
            this.isTelLabel.Size = new System.Drawing.Size(55, 13);
            this.isTelLabel.TabIndex = 17;
            this.isTelLabel.Text = "isTelLabel";
            // 
            // cepTelLabel
            // 
            this.cepTelLabel.AutoSize = true;
            this.cepTelLabel.Location = new System.Drawing.Point(87, 27);
            this.cepTelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cepTelLabel.Name = "cepTelLabel";
            this.cepTelLabel.Size = new System.Drawing.Size(66, 13);
            this.cepTelLabel.TabIndex = 16;
            this.cepTelLabel.Text = "cepTelLabel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cep Telefonu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "İş Telefonu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 76);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Adres:";
            // 
            // kimlikGroupBox
            // 
            this.kimlikGroupBox.Controls.Add(this.dogumTarihiLabel);
            this.kimlikGroupBox.Controls.Add(this.label14);
            this.kimlikGroupBox.Controls.Add(this.cinsiyetLabel);
            this.kimlikGroupBox.Controls.Add(this.tcLabel);
            this.kimlikGroupBox.Controls.Add(this.soyadLabel);
            this.kimlikGroupBox.Controls.Add(this.adLabel);
            this.kimlikGroupBox.Controls.Add(this.label12);
            this.kimlikGroupBox.Controls.Add(this.label1);
            this.kimlikGroupBox.Controls.Add(this.label2);
            this.kimlikGroupBox.Controls.Add(this.label3);
            this.kimlikGroupBox.Location = new System.Drawing.Point(17, 23);
            this.kimlikGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.kimlikGroupBox.Name = "kimlikGroupBox";
            this.kimlikGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.kimlikGroupBox.Size = new System.Drawing.Size(462, 145);
            this.kimlikGroupBox.TabIndex = 7;
            this.kimlikGroupBox.TabStop = false;
            this.kimlikGroupBox.Text = "Kimlik Bilgileri";
            // 
            // dogumTarihiLabel
            // 
            this.dogumTarihiLabel.AutoSize = true;
            this.dogumTarihiLabel.Location = new System.Drawing.Point(89, 115);
            this.dogumTarihiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dogumTarihiLabel.Name = "dogumTarihiLabel";
            this.dogumTarihiLabel.Size = new System.Drawing.Size(91, 13);
            this.dogumTarihiLabel.TabIndex = 16;
            this.dogumTarihiLabel.Text = "dogumTarihiLabel";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 115);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Doğum Tarihi:";
            // 
            // cinsiyetLabel
            // 
            this.cinsiyetLabel.AutoSize = true;
            this.cinsiyetLabel.Location = new System.Drawing.Point(89, 92);
            this.cinsiyetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cinsiyetLabel.Name = "cinsiyetLabel";
            this.cinsiyetLabel.Size = new System.Drawing.Size(68, 13);
            this.cinsiyetLabel.TabIndex = 14;
            this.cinsiyetLabel.Text = "cinsiyetLabel";
            // 
            // tcLabel
            // 
            this.tcLabel.AutoSize = true;
            this.tcLabel.Location = new System.Drawing.Point(89, 68);
            this.tcLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tcLabel.Name = "tcLabel";
            this.tcLabel.Size = new System.Drawing.Size(42, 13);
            this.tcLabel.TabIndex = 13;
            this.tcLabel.Text = "tcLabel";
            // 
            // soyadLabel
            // 
            this.soyadLabel.AutoSize = true;
            this.soyadLabel.Location = new System.Drawing.Point(89, 46);
            this.soyadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(61, 13);
            this.soyadLabel.TabIndex = 12;
            this.soyadLabel.Text = "soyadLabel";
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(89, 24);
            this.adLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(45, 13);
            this.adLabel.TabIndex = 11;
            this.adLabel.Text = "adLabel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 92);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Cinsiyet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.muayaneBekHastalarTab);
            this.tabControl1.Location = new System.Drawing.Point(9, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 463);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.hastalarDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(559, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tüm Hastalar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(14, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hasta seçmek için satırın sol kenarındaki boşluğa tıklayınız!";
            // 
            // hastalarDataGridView
            // 
            this.hastalarDataGridView.AllowUserToAddRows = false;
            this.hastalarDataGridView.AllowUserToDeleteRows = false;
            this.hastalarDataGridView.AllowUserToOrderColumns = true;
            this.hastalarDataGridView.AllowUserToResizeColumns = false;
            this.hastalarDataGridView.AllowUserToResizeRows = false;
            this.hastalarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.hastalarDataGridView.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.hastalarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastalarDataGridView.Location = new System.Drawing.Point(17, 62);
            this.hastalarDataGridView.Name = "hastalarDataGridView";
            this.hastalarDataGridView.ReadOnly = true;
            this.hastalarDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.hastalarDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.hastalarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hastalarDataGridView.Size = new System.Drawing.Size(516, 351);
            this.hastalarDataGridView.TabIndex = 1;
            this.hastalarDataGridView.VirtualMode = true;
            this.hastalarDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.hastalarDataGridView_RowHeaderMouseDoubleClick);
            // 
            // DoctorMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 482);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DoctorMainPage";
            this.Text = "Doktor Anasayfa";
            this.Activated += new System.EventHandler(this.DoctorMainPage_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorMainPage_FormClosed);
            this.Load += new System.EventHandler(this.DoctorMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hASTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.muayaneBekHastalarTab.ResumeLayout(false);
            this.muayaneBekHastalarTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muayeneBekleyenHastalarDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.bransGroupBox.ResumeLayout(false);
            this.bransGroupBox.PerformLayout();
            this.iletisimGroupBox.ResumeLayout(false);
            this.iletisimGroupBox.PerformLayout();
            this.kimlikGroupBox.ResumeLayout(false);
            this.kimlikGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource hASTABindingSource;
        private DataSet1TableAdapters.HASTATableAdapter hASTATableAdapter;
        private System.Windows.Forms.TabPage muayaneBekHastalarTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox bransGroupBox;
        private System.Windows.Forms.Label unvanLabel;
        private System.Windows.Forms.Label bransLabel;
        private System.Windows.Forms.Label poliklinikLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox iletisimGroupBox;
        private System.Windows.Forms.Label adresLabel;
        private System.Windows.Forms.Label isTelLabel;
        private System.Windows.Forms.Label cepTelLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox kimlikGroupBox;
        private System.Windows.Forms.Label dogumTarihiLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label cinsiyetLabel;
        private System.Windows.Forms.Label tcLabel;
        private System.Windows.Forms.Label soyadLabel;
        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView hastalarDataGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView muayeneBekleyenHastalarDataGridView;
    }
}
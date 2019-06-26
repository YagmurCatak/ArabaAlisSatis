namespace AracALisSatis
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIlanAdi = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVitesTuru = new System.Windows.Forms.ComboBox();
            this.cmbYakitTuru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.errorIlanAdi = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtIlanFiyat = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.arabaListele = new System.Windows.Forms.Button();
            this.IlanListele = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSehirGuncel = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRenkGuncelleme = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtyakitturuguncelleme = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtVitesTuru = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtModelGuncel = new System.Windows.Forms.TextBox();
            this.lblmodelguncel = new System.Windows.Forms.Label();
            this.txtmarkaguncel = new System.Windows.Forms.TextBox();
            this.lblmarkaguncel = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtkilometre = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txttarih = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIlan = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.errorIlanAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLAN ADI :";
            // 
            // txtIlanAdi
            // 
            this.txtIlanAdi.Location = new System.Drawing.Point(255, 46);
            this.txtIlanAdi.Name = "txtIlanAdi";
            this.txtIlanAdi.Size = new System.Drawing.Size(348, 22);
            this.txtIlanAdi.TabIndex = 1;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(255, 162);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(121, 22);
            this.txtMarka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "MARKA :";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(482, 162);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 22);
            this.txtModel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "MODEL :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "VİTES TÜRÜ : ";
            // 
            // cmbVitesTuru
            // 
            this.cmbVitesTuru.FormattingEnabled = true;
            this.cmbVitesTuru.Items.AddRange(new object[] {
            "Otomatik",
            "Yarı Otomatik",
            "Manuel"});
            this.cmbVitesTuru.Location = new System.Drawing.Point(255, 200);
            this.cmbVitesTuru.Name = "cmbVitesTuru";
            this.cmbVitesTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbVitesTuru.TabIndex = 7;
            this.cmbVitesTuru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbVitesTuru_KeyPress);
            // 
            // cmbYakitTuru
            // 
            this.cmbYakitTuru.FormattingEnabled = true;
            this.cmbYakitTuru.Items.AddRange(new object[] {
            "Benzin ",
            "Dizel ",
            "Motorin",
            "LPG"});
            this.cmbYakitTuru.Location = new System.Drawing.Point(482, 200);
            this.cmbYakitTuru.Name = "cmbYakitTuru";
            this.cmbYakitTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbYakitTuru.TabIndex = 9;
            this.cmbYakitTuru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbYakitTuru_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "YAKIT TÜRÜ : ";
            // 
            // cmbRenk
            // 
            this.cmbRenk.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbRenk.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbRenk.FormattingEnabled = true;
            this.cmbRenk.Items.AddRange(new object[] {
            "Siyah",
            "Kırmızı",
            "Beyaz",
            "Mavi",
            "Lacivert",
            "Kahverengi",
            "Füme",
            "Gri ",
            "Metal"});
            this.cmbRenk.Location = new System.Drawing.Point(255, 238);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbRenk.Size = new System.Drawing.Size(121, 24);
            this.cmbRenk.TabIndex = 11;
            this.cmbRenk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRenk_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "RENK :";
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Items.AddRange(new object[] {
            "01 Adana",
            "02 Adıyaman",
            "03 Afyon",
            "04 Ağrı",
            "05 Amasya",
            "06 Ankara",
            "07 Antalya",
            "08 Artvin",
            "09 Aydın",
            "10 Balıkesir",
            "11 Bilecik",
            "12 Bingöl",
            "13 Bitlis",
            "14 Bolu",
            "15 Burdur",
            "16 Bursa",
            "17 Çanakkale",
            "18 Çankırı",
            "19 Çorum",
            "20 Denizli",
            "21 Diyarbakır",
            "22 Edirne",
            "23 Elazığ",
            "24 Erzincan",
            "25 Erzurum",
            "26 Eskişehir",
            "27 Gaziantep",
            "28 Giresun",
            "29 Gümüşhane",
            "30 Hakkari",
            "31 Hatay",
            "32 Isparta",
            "33 İçel (Mersin)",
            "34 İstanbul",
            "35 İzmir",
            "36 Kars",
            "37 Kastamonu",
            "38 Kayseri",
            "39 Kırklareli",
            "40 Kırşehir",
            "41 Kocaeli",
            "42 Konya",
            "43 Kütahya",
            "44 Malatya",
            "45 Manisa",
            "46 K.maraş",
            "47 Mardin",
            "48 Muğla",
            "49 Muş",
            "50 Nevşehir",
            "51 Niğde",
            "52 Ordu",
            "53 Rize",
            "54 Sakarya",
            "55 Samsun",
            "56 Siirt",
            "57 Sinop",
            "58 Sivas",
            "59 Tekirdağ",
            "60 Tokat",
            "61 Trabzon",
            "62 Tunceli",
            "63 Şanlıurfa",
            "64 Uşak",
            "65 Van",
            "66 Yozgat",
            "67 Zonguldak",
            "68 Aksaray",
            "69 Bayburt",
            "70 Karaman",
            "71 Kırıkkale",
            "72 Batman",
            "73 Şırnak",
            "74 Bartın",
            "75 Ardahan",
            "76 Iğdır",
            "77 Yalova",
            "78 Karabük",
            "79 Kilis",
            "80 Osmaniye",
            "81 Düzce"});
            this.cmbSehir.Location = new System.Drawing.Point(482, 243);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(121, 24);
            this.cmbSehir.TabIndex = 13;
            this.cmbSehir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSehir_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "ŞEHİR  : ";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(528, 311);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // errorIlanAdi
            // 
            this.errorIlanAdi.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "İLAN FİYATI : ";
            // 
            // txtIlanFiyat
            // 
            this.txtIlanFiyat.Location = new System.Drawing.Point(255, 122);
            this.txtIlanFiyat.Name = "txtIlanFiyat";
            this.txtIlanFiyat.Size = new System.Drawing.Size(121, 22);
            this.txtIlanFiyat.TabIndex = 16;
            this.txtIlanFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIlanFiyat_KeyPress);
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(482, 128);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(121, 22);
            this.txtKm.TabIndex = 18;
            this.txtKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "KM :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "TARİH : ";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(255, 77);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 21;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(7, 83);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(795, 253);
            this.dataGridView.TabIndex = 22;
            // 
            // arabaListele
            // 
            this.arabaListele.Location = new System.Drawing.Point(7, 48);
            this.arabaListele.Name = "arabaListele";
            this.arabaListele.Size = new System.Drawing.Size(119, 23);
            this.arabaListele.TabIndex = 23;
            this.arabaListele.Text = "ArabaListele";
            this.arabaListele.UseVisualStyleBackColor = true;
            this.arabaListele.Click += new System.EventHandler(this.arabaListele_Click);
            // 
            // IlanListele
            // 
            this.IlanListele.Location = new System.Drawing.Point(161, 48);
            this.IlanListele.Name = "IlanListele";
            this.IlanListele.Size = new System.Drawing.Size(119, 23);
            this.IlanListele.TabIndex = 24;
            this.IlanListele.Text = "İlanListele";
            this.IlanListele.UseVisualStyleBackColor = true;
            this.IlanListele.Click += new System.EventHandler(this.IlanListele_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.Location = new System.Drawing.Point(289, 358);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(172, 23);
            this.btnSilme.TabIndex = 25;
            this.btnSilme.Text = "SecilenVeriSilme";
            this.btnSilme.UseVisualStyleBackColor = true;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 491);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbVitesTuru);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtMarka);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtIlanAdi);
            this.tabPage1.Controls.Add(this.txtModel);
            this.tabPage1.Controls.Add(this.dtpTarih);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtKm);
            this.tabPage1.Controls.Add(this.cmbYakitTuru);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtIlanFiyat);
            this.tabPage1.Controls.Add(this.cmbRenk);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnEkle);
            this.tabPage1.Controls.Add(this.cmbSehir);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ekleme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.arabaListele);
            this.tabPage2.Controls.Add(this.btnSilme);
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Controls.Add(this.IlanListele);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(890, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Silme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.txtSehirGuncel);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.txtRenkGuncelleme);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.txtyakitturuguncelleme);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.txtVitesTuru);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txtModelGuncel);
            this.tabPage3.Controls.Add(this.lblmodelguncel);
            this.tabPage3.Controls.Add(this.txtmarkaguncel);
            this.tabPage3.Controls.Add(this.lblmarkaguncel);
            this.tabPage3.Controls.Add(this.btnGuncelle);
            this.tabPage3.Controls.Add(this.txtkilometre);
            this.tabPage3.Controls.Add(this.txtfiyat);
            this.tabPage3.Controls.Add(this.txttarih);
            this.tabPage3.Controls.Add(this.txtad);
            this.tabPage3.Controls.Add(this.txtid);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.lblIlan);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(890, 462);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Güncelleme";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "İlan Tablosu Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSehirGuncel
            // 
            this.txtSehirGuncel.Location = new System.Drawing.Point(248, 170);
            this.txtSehirGuncel.Name = "txtSehirGuncel";
            this.txtSehirGuncel.Size = new System.Drawing.Size(100, 22);
            this.txtSehirGuncel.TabIndex = 46;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(186, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 16);
            this.label18.TabIndex = 45;
            this.label18.Text = "Şehir:";
            // 
            // txtRenkGuncelleme
            // 
            this.txtRenkGuncelleme.Location = new System.Drawing.Point(617, 170);
            this.txtRenkGuncelleme.Name = "txtRenkGuncelleme";
            this.txtRenkGuncelleme.Size = new System.Drawing.Size(100, 22);
            this.txtRenkGuncelleme.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(554, 173);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 16);
            this.label17.TabIndex = 43;
            this.label17.Text = "Renk:";
            // 
            // txtyakitturuguncelleme
            // 
            this.txtyakitturuguncelleme.Location = new System.Drawing.Point(617, 136);
            this.txtyakitturuguncelleme.Name = "txtyakitturuguncelleme";
            this.txtyakitturuguncelleme.Size = new System.Drawing.Size(100, 22);
            this.txtyakitturuguncelleme.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(554, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "YakıtTuru:";
            // 
            // txtVitesTuru
            // 
            this.txtVitesTuru.Location = new System.Drawing.Point(617, 103);
            this.txtVitesTuru.Name = "txtVitesTuru";
            this.txtVitesTuru.Size = new System.Drawing.Size(100, 22);
            this.txtVitesTuru.TabIndex = 40;
            this.txtVitesTuru.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(554, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 16);
            this.label15.TabIndex = 39;
            this.label15.Text = "VitesTuru:";
            this.label15.UseWaitCursor = true;
            // 
            // txtModelGuncel
            // 
            this.txtModelGuncel.Location = new System.Drawing.Point(617, 70);
            this.txtModelGuncel.Name = "txtModelGuncel";
            this.txtModelGuncel.Size = new System.Drawing.Size(100, 22);
            this.txtModelGuncel.TabIndex = 38;
            // 
            // lblmodelguncel
            // 
            this.lblmodelguncel.AutoSize = true;
            this.lblmodelguncel.Location = new System.Drawing.Point(554, 73);
            this.lblmodelguncel.Name = "lblmodelguncel";
            this.lblmodelguncel.Size = new System.Drawing.Size(46, 16);
            this.lblmodelguncel.TabIndex = 37;
            this.lblmodelguncel.Text = "Model: ";
            // 
            // txtmarkaguncel
            // 
            this.txtmarkaguncel.Location = new System.Drawing.Point(617, 39);
            this.txtmarkaguncel.Name = "txtmarkaguncel";
            this.txtmarkaguncel.Size = new System.Drawing.Size(100, 22);
            this.txtmarkaguncel.TabIndex = 36;
            // 
            // lblmarkaguncel
            // 
            this.lblmarkaguncel.AutoSize = true;
            this.lblmarkaguncel.Location = new System.Drawing.Point(554, 39);
            this.lblmarkaguncel.Name = "lblmarkaguncel";
            this.lblmarkaguncel.Size = new System.Drawing.Size(42, 16);
            this.lblmarkaguncel.TabIndex = 35;
            this.lblmarkaguncel.Text = "Marka:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(481, 252);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 34;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtkilometre
            // 
            this.txtkilometre.Location = new System.Drawing.Point(248, 142);
            this.txtkilometre.Name = "txtkilometre";
            this.txtkilometre.Size = new System.Drawing.Size(100, 22);
            this.txtkilometre.TabIndex = 33;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(248, 108);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 22);
            this.txtfiyat.TabIndex = 32;
            // 
            // txttarih
            // 
            this.txttarih.Location = new System.Drawing.Point(248, 72);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(100, 22);
            this.txttarih.TabIndex = 31;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(248, 39);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 22);
            this.txtad.TabIndex = 30;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(429, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(196, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Km: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(192, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Fiyat:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tarih:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "İlan adi: ";
            // 
            // lblIlan
            // 
            this.lblIlan.AutoSize = true;
            this.lblIlan.Location = new System.Drawing.Point(367, 18);
            this.lblIlan.Name = "lblIlan";
            this.lblIlan.Size = new System.Drawing.Size(43, 16);
            this.lblIlan.TabIndex = 24;
            this.lblIlan.Text = "İlan id: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(810, 150);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnFiltrele);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(890, 462);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Filtreleme";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(330, 137);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(116, 24);
            this.btnFiltrele.TabIndex = 1;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(206, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(390, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Filtreleme yapmak için Filtreleme butonuna basarak, ilgili sayfaya geçiş yapınız." +
    "";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(55, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(8, 8);
            this.tabControl2.TabIndex = 27;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(0, 0);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 492);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Araç Alış-Satış Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIlanAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIlanAdi;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVitesTuru;
        private System.Windows.Forms.ComboBox cmbYakitTuru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRenk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ErrorProvider errorIlanAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIlanFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button arabaListele;
        private System.Windows.Forms.Button IlanListele;
        private System.Windows.Forms.Button btnSilme;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtkilometre;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txttarih;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIlan;
        private System.Windows.Forms.TextBox txtmarkaguncel;
        private System.Windows.Forms.Label lblmarkaguncel;
        private System.Windows.Forms.TextBox txtSehirGuncel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRenkGuncelleme;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtyakitturuguncelleme;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtVitesTuru;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtModelGuncel;
        private System.Windows.Forms.Label lblmodelguncel;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Label label19;
    }
}


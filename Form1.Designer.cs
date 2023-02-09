namespace TrenBiletRezervasyon
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
            this.dgwYolcular = new System.Windows.Forms.DataGridView();
            this.lblİsim = new System.Windows.Forms.Label();
            this.lblYaş = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblİletişimNo = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.tbxİsim = new System.Windows.Forms.TextBox();
            this.tbxYaş = new System.Windows.Forms.TextBox();
            this.tbxCinsiyet = new System.Windows.Forms.TextBox();
            this.tbxİletişimNo = new System.Windows.Forms.TextBox();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.gbxYolcuEkle = new System.Windows.Forms.GroupBox();
            this.btnYolcuEkle = new System.Windows.Forms.Button();
            this.gbxYolcuGüncelle = new System.Windows.Forms.GroupBox();
            this.btnKaldır = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.lblİsimGüncelle = new System.Windows.Forms.Label();
            this.tbxAdresGüncelle = new System.Windows.Forms.TextBox();
            this.lblYaşGüncelle = new System.Windows.Forms.Label();
            this.tbxİletişimNoGüncelle = new System.Windows.Forms.TextBox();
            this.lblCinsiyetGüncelle = new System.Windows.Forms.Label();
            this.tbxCinsiyetGüncelle = new System.Windows.Forms.TextBox();
            this.lblİletişimNoGüncelle = new System.Windows.Forms.Label();
            this.tbxYaşGüncelle = new System.Windows.Forms.TextBox();
            this.lblAdresGüncelle = new System.Windows.Forms.Label();
            this.tbxİsimGüncelle = new System.Windows.Forms.TextBox();
            this.gbxSeyahat = new System.Windows.Forms.GroupBox();
            this.btnSeyahatEkle = new System.Windows.Forms.Button();
            this.lblBiniş = new System.Windows.Forms.Label();
            this.lblİniş = new System.Windows.Forms.Label();
            this.tbxSaat = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.tbxTarih = new System.Windows.Forms.TextBox();
            this.lblSaat = new System.Windows.Forms.Label();
            this.tbxİniş = new System.Windows.Forms.TextBox();
            this.tbxBiniş = new System.Windows.Forms.TextBox();
            this.gbxSeyahatGüncelle = new System.Windows.Forms.GroupBox();
            this.btnSeyahatKaldır = new System.Windows.Forms.Button();
            this.btnSeyahatGüncelle = new System.Windows.Forms.Button();
            this.lblBinişGüncelle = new System.Windows.Forms.Label();
            this.lblİnişGüncelle = new System.Windows.Forms.Label();
            this.tbxSaatGüncelle = new System.Windows.Forms.TextBox();
            this.lblTarihGüncelle = new System.Windows.Forms.Label();
            this.tbxTarihGüncelle = new System.Windows.Forms.TextBox();
            this.lblSaatGüncelle = new System.Windows.Forms.Label();
            this.tbxİnişGüncelle = new System.Windows.Forms.TextBox();
            this.tbxBinişGüncelle = new System.Windows.Forms.TextBox();
            this.dgwSeyahat = new System.Windows.Forms.DataGridView();
            this.dgwBilet = new System.Windows.Forms.DataGridView();
            this.gbxBilet = new System.Windows.Forms.GroupBox();
            this.btnBilet = new System.Windows.Forms.Button();
            this.lblBiletFiyat = new System.Windows.Forms.Label();
            this.lblSonFiyat = new System.Windows.Forms.Label();
            this.tbxSonFiyat = new System.Windows.Forms.TextBox();
            this.tbxFiyat = new System.Windows.Forms.TextBox();
            this.gbxBiletGünbelle = new System.Windows.Forms.GroupBox();
            this.btnBiletKaldır = new System.Windows.Forms.Button();
            this.btnBiletGüncelleme = new System.Windows.Forms.Button();
            this.lblBiletGüncelleme = new System.Windows.Forms.Label();
            this.lblSonGüncelleme = new System.Windows.Forms.Label();
            this.tbxSonGüncelleme = new System.Windows.Forms.TextBox();
            this.tbxBiletGüncelleme = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYolcular)).BeginInit();
            this.gbxYolcuEkle.SuspendLayout();
            this.gbxYolcuGüncelle.SuspendLayout();
            this.gbxSeyahat.SuspendLayout();
            this.gbxSeyahatGüncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSeyahat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBilet)).BeginInit();
            this.gbxBilet.SuspendLayout();
            this.gbxBiletGünbelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwYolcular
            // 
            this.dgwYolcular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwYolcular.Location = new System.Drawing.Point(12, 29);
            this.dgwYolcular.Name = "dgwYolcular";
            this.dgwYolcular.Size = new System.Drawing.Size(526, 185);
            this.dgwYolcular.TabIndex = 0;
            this.dgwYolcular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwYolcular_CellClick);
            // 
            // lblİsim
            // 
            this.lblİsim.AutoSize = true;
            this.lblİsim.Location = new System.Drawing.Point(58, 34);
            this.lblİsim.Name = "lblİsim";
            this.lblİsim.Size = new System.Drawing.Size(25, 13);
            this.lblİsim.TabIndex = 1;
            this.lblİsim.Text = "İsim";
            // 
            // lblYaş
            // 
            this.lblYaş.AutoSize = true;
            this.lblYaş.Location = new System.Drawing.Point(58, 61);
            this.lblYaş.Name = "lblYaş";
            this.lblYaş.Size = new System.Drawing.Size(25, 13);
            this.lblYaş.TabIndex = 2;
            this.lblYaş.Text = "Yaş";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(58, 88);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(43, 13);
            this.lblCinsiyet.TabIndex = 3;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // lblİletişimNo
            // 
            this.lblİletişimNo.AutoSize = true;
            this.lblİletişimNo.Location = new System.Drawing.Point(58, 117);
            this.lblİletişimNo.Name = "lblİletişimNo";
            this.lblİletişimNo.Size = new System.Drawing.Size(55, 13);
            this.lblİletişimNo.TabIndex = 4;
            this.lblİletişimNo.Text = "İletişim No";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(58, 144);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 5;
            this.lblAdres.Text = "Adres";
            // 
            // tbxİsim
            // 
            this.tbxİsim.Location = new System.Drawing.Point(140, 27);
            this.tbxİsim.Name = "tbxİsim";
            this.tbxİsim.Size = new System.Drawing.Size(100, 20);
            this.tbxİsim.TabIndex = 6;
            
            // 
            // tbxYaş
            // 
            this.tbxYaş.Location = new System.Drawing.Point(140, 53);
            this.tbxYaş.Name = "tbxYaş";
            this.tbxYaş.Size = new System.Drawing.Size(100, 20);
            this.tbxYaş.TabIndex = 7;
            // 
            // tbxCinsiyet
            // 
            this.tbxCinsiyet.Location = new System.Drawing.Point(140, 80);
            this.tbxCinsiyet.Name = "tbxCinsiyet";
            this.tbxCinsiyet.Size = new System.Drawing.Size(100, 20);
            this.tbxCinsiyet.TabIndex = 8;
            // 
            // tbxİletişimNo
            // 
            this.tbxİletişimNo.Location = new System.Drawing.Point(140, 109);
            this.tbxİletişimNo.Name = "tbxİletişimNo";
            this.tbxİletişimNo.Size = new System.Drawing.Size(100, 20);
            this.tbxİletişimNo.TabIndex = 9;
            // 
            // tbxAdres
            // 
            this.tbxAdres.Location = new System.Drawing.Point(140, 136);
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(100, 20);
            this.tbxAdres.TabIndex = 10;
            // 
            // gbxYolcuEkle
            // 
            this.gbxYolcuEkle.Controls.Add(this.btnYolcuEkle);
            this.gbxYolcuEkle.Controls.Add(this.lblİsim);
            this.gbxYolcuEkle.Controls.Add(this.tbxAdres);
            this.gbxYolcuEkle.Controls.Add(this.lblYaş);
            this.gbxYolcuEkle.Controls.Add(this.tbxİletişimNo);
            this.gbxYolcuEkle.Controls.Add(this.lblCinsiyet);
            this.gbxYolcuEkle.Controls.Add(this.tbxCinsiyet);
            this.gbxYolcuEkle.Controls.Add(this.lblİletişimNo);
            this.gbxYolcuEkle.Controls.Add(this.tbxYaş);
            this.gbxYolcuEkle.Controls.Add(this.lblAdres);
            this.gbxYolcuEkle.Controls.Add(this.tbxİsim);
            this.gbxYolcuEkle.Location = new System.Drawing.Point(552, 29);
            this.gbxYolcuEkle.Name = "gbxYolcuEkle";
            this.gbxYolcuEkle.Size = new System.Drawing.Size(293, 207);
            this.gbxYolcuEkle.TabIndex = 11;
            this.gbxYolcuEkle.TabStop = false;
            this.gbxYolcuEkle.Text = "Yolcu Ekleme";
            // 
            // btnYolcuEkle
            // 
            this.btnYolcuEkle.Location = new System.Drawing.Point(165, 162);
            this.btnYolcuEkle.Name = "btnYolcuEkle";
            this.btnYolcuEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYolcuEkle.TabIndex = 11;
            this.btnYolcuEkle.Text = "Ekle";
            this.btnYolcuEkle.UseVisualStyleBackColor = true;
            this.btnYolcuEkle.Click += new System.EventHandler(this.btnYolcuEkle_Click);
            // 
            // gbxYolcuGüncelle
            // 
            this.gbxYolcuGüncelle.Controls.Add(this.btnKaldır);
            this.gbxYolcuGüncelle.Controls.Add(this.btnGüncelle);
            this.gbxYolcuGüncelle.Controls.Add(this.lblİsimGüncelle);
            this.gbxYolcuGüncelle.Controls.Add(this.tbxAdresGüncelle);
            this.gbxYolcuGüncelle.Controls.Add(this.lblYaşGüncelle);
            this.gbxYolcuGüncelle.Controls.Add(this.tbxİletişimNoGüncelle);
            this.gbxYolcuGüncelle.Controls.Add(this.lblCinsiyetGüncelle);
            this.gbxYolcuGüncelle.Controls.Add(this.tbxCinsiyetGüncelle);
            this.gbxYolcuGüncelle.Controls.Add(this.lblİletişimNoGüncelle);
            this.gbxYolcuGüncelle.Controls.Add(this.tbxYaşGüncelle);
            this.gbxYolcuGüncelle.Controls.Add(this.lblAdresGüncelle);
            this.gbxYolcuGüncelle.Controls.Add(this.tbxİsimGüncelle);
            this.gbxYolcuGüncelle.Location = new System.Drawing.Point(851, 29);
            this.gbxYolcuGüncelle.Name = "gbxYolcuGüncelle";
            this.gbxYolcuGüncelle.Size = new System.Drawing.Size(293, 207);
            this.gbxYolcuGüncelle.TabIndex = 12;
            this.gbxYolcuGüncelle.TabStop = false;
            this.gbxYolcuGüncelle.Text = "Yolcu Güncelle";
            // 
            // btnKaldır
            // 
            this.btnKaldır.Location = new System.Drawing.Point(61, 162);
            this.btnKaldır.Name = "btnKaldır";
            this.btnKaldır.Size = new System.Drawing.Size(75, 23);
            this.btnKaldır.TabIndex = 13;
            this.btnKaldır.Text = "Kaldır";
            this.btnKaldır.UseVisualStyleBackColor = true;
            this.btnKaldır.Click += new System.EventHandler(this.btnKaldır_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(165, 162);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 11;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // lblİsimGüncelle
            // 
            this.lblİsimGüncelle.AutoSize = true;
            this.lblİsimGüncelle.Location = new System.Drawing.Point(58, 34);
            this.lblİsimGüncelle.Name = "lblİsimGüncelle";
            this.lblİsimGüncelle.Size = new System.Drawing.Size(25, 13);
            this.lblİsimGüncelle.TabIndex = 1;
            this.lblİsimGüncelle.Text = "İsim";
            // 
            // tbxAdresGüncelle
            // 
            this.tbxAdresGüncelle.Location = new System.Drawing.Point(140, 136);
            this.tbxAdresGüncelle.Name = "tbxAdresGüncelle";
            this.tbxAdresGüncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxAdresGüncelle.TabIndex = 10;
            // 
            // lblYaşGüncelle
            // 
            this.lblYaşGüncelle.AutoSize = true;
            this.lblYaşGüncelle.Location = new System.Drawing.Point(58, 61);
            this.lblYaşGüncelle.Name = "lblYaşGüncelle";
            this.lblYaşGüncelle.Size = new System.Drawing.Size(25, 13);
            this.lblYaşGüncelle.TabIndex = 2;
            this.lblYaşGüncelle.Text = "Yaş";
            // 
            // tbxİletişimNoGüncelle
            // 
            this.tbxİletişimNoGüncelle.Location = new System.Drawing.Point(140, 109);
            this.tbxİletişimNoGüncelle.Name = "tbxİletişimNoGüncelle";
            this.tbxİletişimNoGüncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxİletişimNoGüncelle.TabIndex = 9;
            // 
            // lblCinsiyetGüncelle
            // 
            this.lblCinsiyetGüncelle.AutoSize = true;
            this.lblCinsiyetGüncelle.Location = new System.Drawing.Point(58, 88);
            this.lblCinsiyetGüncelle.Name = "lblCinsiyetGüncelle";
            this.lblCinsiyetGüncelle.Size = new System.Drawing.Size(43, 13);
            this.lblCinsiyetGüncelle.TabIndex = 3;
            this.lblCinsiyetGüncelle.Text = "Cinsiyet";
            
            // 
            // tbxCinsiyetGüncelle
            // 
            this.tbxCinsiyetGüncelle.Location = new System.Drawing.Point(140, 80);
            this.tbxCinsiyetGüncelle.Name = "tbxCinsiyetGüncelle";
            this.tbxCinsiyetGüncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxCinsiyetGüncelle.TabIndex = 8;
            // 
            // lblİletişimNoGüncelle
            // 
            this.lblİletişimNoGüncelle.AutoSize = true;
            this.lblİletişimNoGüncelle.Location = new System.Drawing.Point(58, 117);
            this.lblİletişimNoGüncelle.Name = "lblİletişimNoGüncelle";
            this.lblİletişimNoGüncelle.Size = new System.Drawing.Size(55, 13);
            this.lblİletişimNoGüncelle.TabIndex = 4;
            this.lblİletişimNoGüncelle.Text = "İletişim No";
            // 
            // tbxYaşGüncelle
            // 
            this.tbxYaşGüncelle.Location = new System.Drawing.Point(140, 53);
            this.tbxYaşGüncelle.Name = "tbxYaşGüncelle";
            this.tbxYaşGüncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxYaşGüncelle.TabIndex = 7;
            // 
            // lblAdresGüncelle
            // 
            this.lblAdresGüncelle.AutoSize = true;
            this.lblAdresGüncelle.Location = new System.Drawing.Point(58, 144);
            this.lblAdresGüncelle.Name = "lblAdresGüncelle";
            this.lblAdresGüncelle.Size = new System.Drawing.Size(34, 13);
            this.lblAdresGüncelle.TabIndex = 5;
            this.lblAdresGüncelle.Text = "Adres";
            // 
            // tbxİsimGüncelle
            // 
            this.tbxİsimGüncelle.Location = new System.Drawing.Point(140, 27);
            this.tbxİsimGüncelle.Name = "tbxİsimGüncelle";
            this.tbxİsimGüncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxİsimGüncelle.TabIndex = 6;
            // 
            // gbxSeyahat
            // 
            this.gbxSeyahat.Controls.Add(this.btnSeyahatEkle);
            this.gbxSeyahat.Controls.Add(this.lblBiniş);
            this.gbxSeyahat.Controls.Add(this.lblİniş);
            this.gbxSeyahat.Controls.Add(this.tbxSaat);
            this.gbxSeyahat.Controls.Add(this.lblTarih);
            this.gbxSeyahat.Controls.Add(this.tbxTarih);
            this.gbxSeyahat.Controls.Add(this.lblSaat);
            this.gbxSeyahat.Controls.Add(this.tbxİniş);
            this.gbxSeyahat.Controls.Add(this.tbxBiniş);
            this.gbxSeyahat.Location = new System.Drawing.Point(552, 271);
            this.gbxSeyahat.Name = "gbxSeyahat";
            this.gbxSeyahat.Size = new System.Drawing.Size(293, 207);
            this.gbxSeyahat.TabIndex = 13;
            this.gbxSeyahat.TabStop = false;
            this.gbxSeyahat.Text = "Seyahat Bilgisi";
            // 
            // btnSeyahatEkle
            // 
            this.btnSeyahatEkle.Location = new System.Drawing.Point(165, 162);
            this.btnSeyahatEkle.Name = "btnSeyahatEkle";
            this.btnSeyahatEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSeyahatEkle.TabIndex = 11;
            this.btnSeyahatEkle.Text = "Ekle";
            this.btnSeyahatEkle.UseVisualStyleBackColor = true;
            this.btnSeyahatEkle.Click += new System.EventHandler(this.btnSeyahatEkle_Click);
            // 
            // lblBiniş
            // 
            this.lblBiniş.AutoSize = true;
            this.lblBiniş.Location = new System.Drawing.Point(58, 34);
            this.lblBiniş.Name = "lblBiniş";
            this.lblBiniş.Size = new System.Drawing.Size(50, 13);
            this.lblBiniş.TabIndex = 1;
            this.lblBiniş.Text = "Biniş Yeri";
            // 
            // lblİniş
            // 
            this.lblİniş.AutoSize = true;
            this.lblİniş.Location = new System.Drawing.Point(58, 61);
            this.lblİniş.Name = "lblİniş";
            this.lblİniş.Size = new System.Drawing.Size(44, 13);
            this.lblİniş.TabIndex = 2;
            this.lblİniş.Text = "İniş Yeri";
            // 
            // tbxSaat
            // 
            this.tbxSaat.Location = new System.Drawing.Point(140, 109);
            this.tbxSaat.Name = "tbxSaat";
            this.tbxSaat.Size = new System.Drawing.Size(100, 20);
            this.tbxSaat.TabIndex = 9;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(58, 88);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "Tarih";
            // 
            // tbxTarih
            // 
            this.tbxTarih.Location = new System.Drawing.Point(140, 80);
            this.tbxTarih.Name = "tbxTarih";
            this.tbxTarih.Size = new System.Drawing.Size(100, 20);
            this.tbxTarih.TabIndex = 8;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(58, 117);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(29, 13);
            this.lblSaat.TabIndex = 4;
            this.lblSaat.Text = "Saat";
            // 
            // tbxİniş
            // 
            this.tbxİniş.Location = new System.Drawing.Point(140, 53);
            this.tbxİniş.Name = "tbxİniş";
            this.tbxİniş.Size = new System.Drawing.Size(100, 20);
            this.tbxİniş.TabIndex = 7;
            // 
            // tbxBiniş
            // 
            this.tbxBiniş.Location = new System.Drawing.Point(140, 27);
            this.tbxBiniş.Name = "tbxBiniş";
            this.tbxBiniş.Size = new System.Drawing.Size(100, 20);
            this.tbxBiniş.TabIndex = 6;
            // 
            // gbxSeyahatGüncelle
            // 
            this.gbxSeyahatGüncelle.Controls.Add(this.btnSeyahatKaldır);
            this.gbxSeyahatGüncelle.Controls.Add(this.btnSeyahatGüncelle);
            this.gbxSeyahatGüncelle.Controls.Add(this.lblBinişGüncelle);
            this.gbxSeyahatGüncelle.Controls.Add(this.lblİnişGüncelle);
            this.gbxSeyahatGüncelle.Controls.Add(this.tbxSaatGüncelle);
            this.gbxSeyahatGüncelle.Controls.Add(this.lblTarihGüncelle);
            this.gbxSeyahatGüncelle.Controls.Add(this.tbxTarihGüncelle);
            this.gbxSeyahatGüncelle.Controls.Add(this.lblSaatGüncelle);
            this.gbxSeyahatGüncelle.Controls.Add(this.tbxİnişGüncelle);
            this.gbxSeyahatGüncelle.Controls.Add(this.tbxBinişGüncelle);
            this.gbxSeyahatGüncelle.Location = new System.Drawing.Point(851, 271);
            this.gbxSeyahatGüncelle.Name = "gbxSeyahatGüncelle";
            this.gbxSeyahatGüncelle.Size = new System.Drawing.Size(293, 207);
            this.gbxSeyahatGüncelle.TabIndex = 14;
            this.gbxSeyahatGüncelle.TabStop = false;
            this.gbxSeyahatGüncelle.Text = "Seyahat Güncelle-";
            // 
            // btnSeyahatKaldır
            // 
            this.btnSeyahatKaldır.Location = new System.Drawing.Point(61, 162);
            this.btnSeyahatKaldır.Name = "btnSeyahatKaldır";
            this.btnSeyahatKaldır.Size = new System.Drawing.Size(75, 23);
            this.btnSeyahatKaldır.TabIndex = 13;
            this.btnSeyahatKaldır.Text = "Kaldır";
            this.btnSeyahatKaldır.UseVisualStyleBackColor = true;
            this.btnSeyahatKaldır.Click += new System.EventHandler(this.btnSeyahatKaldır_Click);
            // 
            // btnSeyahatGüncelle
            // 
            this.btnSeyahatGüncelle.Location = new System.Drawing.Point(165, 162);
            this.btnSeyahatGüncelle.Name = "btnSeyahatGüncelle";
            this.btnSeyahatGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnSeyahatGüncelle.TabIndex = 11;
            this.btnSeyahatGüncelle.Text = "Güncelle";
            this.btnSeyahatGüncelle.UseVisualStyleBackColor = true;
            this.btnSeyahatGüncelle.Click += new System.EventHandler(this.btnSeyahatGüncelle_Click);
            // 
            // lblBinişGüncelle
            // 
            this.lblBinişGüncelle.AutoSize = true;
            this.lblBinişGüncelle.Location = new System.Drawing.Point(58, 34);
            this.lblBinişGüncelle.Name = "lblBinişGüncelle";
            this.lblBinişGüncelle.Size = new System.Drawing.Size(50, 13);
            this.lblBinişGüncelle.TabIndex = 1;
            this.lblBinişGüncelle.Text = "Biniş Yeri";
            // 
            // lblİnişGüncelle
            // 
            this.lblİnişGüncelle.AutoSize = true;
            this.lblİnişGüncelle.Location = new System.Drawing.Point(58, 61);
            this.lblİnişGüncelle.Name = "lblİnişGüncelle";
            this.lblİnişGüncelle.Size = new System.Drawing.Size(44, 13);
            this.lblİnişGüncelle.TabIndex = 2;
            this.lblİnişGüncelle.Text = "İniş Yeri";
            // 
            // tbxSaatGüncelle
            // 
            this.tbxSaatGüncelle.Location = new System.Drawing.Point(140, 109);
            this.tbxSaatGüncelle.Name = "tbxSaatGüncelle";
            this.tbxSaatGüncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxSaatGüncelle.TabIndex = 9;
            // 
            // lblTarihGüncelle
            // 
            this.lblTarihGüncelle.AutoSize = true;
            this.lblTarihGüncelle.Location = new System.Drawing.Point(58, 88);
            this.lblTarihGüncelle.Name = "lblTarihGüncelle";
            this.lblTarihGüncelle.Size = new System.Drawing.Size(31, 13);
            this.lblTarihGüncelle.TabIndex = 3;
            this.lblTarihGüncelle.Text = "Tarih";
            // 
            // tbxTarihGüncelle
            // 
            this.tbxTarihGüncelle.Location = new System.Drawing.Point(140, 80);
            this.tbxTarihGüncelle.Name = "tbxTarihGüncelle";
            this.tbxTarihGüncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxTarihGüncelle.TabIndex = 8;
            // 
            // lblSaatGüncelle
            // 
            this.lblSaatGüncelle.AutoSize = true;
            this.lblSaatGüncelle.Location = new System.Drawing.Point(58, 117);
            this.lblSaatGüncelle.Name = "lblSaatGüncelle";
            this.lblSaatGüncelle.Size = new System.Drawing.Size(29, 13);
            this.lblSaatGüncelle.TabIndex = 4;
            this.lblSaatGüncelle.Text = "Saat";
            // 
            // tbxİnişGüncelle
            // 
            this.tbxİnişGüncelle.Location = new System.Drawing.Point(140, 53);
            this.tbxİnişGüncelle.Name = "tbxİnişGüncelle";
            this.tbxİnişGüncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxİnişGüncelle.TabIndex = 7;
            // 
            // tbxBinişGüncelle
            // 
            this.tbxBinişGüncelle.Location = new System.Drawing.Point(140, 27);
            this.tbxBinişGüncelle.Name = "tbxBinişGüncelle";
            this.tbxBinişGüncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxBinişGüncelle.TabIndex = 6;
            // 
            // dgwSeyahat
            // 
            this.dgwSeyahat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSeyahat.Location = new System.Drawing.Point(12, 271);
            this.dgwSeyahat.Name = "dgwSeyahat";
            this.dgwSeyahat.Size = new System.Drawing.Size(526, 130);
            this.dgwSeyahat.TabIndex = 15;
            this.dgwSeyahat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSeyahat_CellClick);
            // 
            // dgwBilet
            // 
            this.dgwBilet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBilet.Location = new System.Drawing.Point(12, 500);
            this.dgwBilet.Name = "dgwBilet";
            this.dgwBilet.Size = new System.Drawing.Size(526, 125);
            this.dgwBilet.TabIndex = 16;
            this.dgwBilet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBilet_CellClick);
            // 
            // gbxBilet
            // 
            this.gbxBilet.Controls.Add(this.btnBilet);
            this.gbxBilet.Controls.Add(this.lblBiletFiyat);
            this.gbxBilet.Controls.Add(this.lblSonFiyat);
            this.gbxBilet.Controls.Add(this.tbxSonFiyat);
            this.gbxBilet.Controls.Add(this.tbxFiyat);
            this.gbxBilet.Location = new System.Drawing.Point(552, 500);
            this.gbxBilet.Name = "gbxBilet";
            this.gbxBilet.Size = new System.Drawing.Size(293, 125);
            this.gbxBilet.TabIndex = 17;
            this.gbxBilet.TabStop = false;
            this.gbxBilet.Text = "Bilet";
            // 
            // btnBilet
            // 
            this.btnBilet.Location = new System.Drawing.Point(165, 79);
            this.btnBilet.Name = "btnBilet";
            this.btnBilet.Size = new System.Drawing.Size(75, 23);
            this.btnBilet.TabIndex = 11;
            this.btnBilet.Text = "Ekle";
            this.btnBilet.UseVisualStyleBackColor = true;
            this.btnBilet.Click += new System.EventHandler(this.btnBilet_Click);
            // 
            // lblBiletFiyat
            // 
            this.lblBiletFiyat.AutoSize = true;
            this.lblBiletFiyat.Location = new System.Drawing.Point(58, 34);
            this.lblBiletFiyat.Name = "lblBiletFiyat";
            this.lblBiletFiyat.Size = new System.Drawing.Size(54, 13);
            this.lblBiletFiyat.TabIndex = 1;
            this.lblBiletFiyat.Text = "Bilet Fiyatı";
            // 
            // lblSonFiyat
            // 
            this.lblSonFiyat.AutoSize = true;
            this.lblSonFiyat.Location = new System.Drawing.Point(58, 61);
            this.lblSonFiyat.Name = "lblSonFiyat";
            this.lblSonFiyat.Size = new System.Drawing.Size(51, 13);
            this.lblSonFiyat.TabIndex = 2;
            this.lblSonFiyat.Text = "Son Fiyat";
            // 
            // tbxSonFiyat
            // 
            this.tbxSonFiyat.Location = new System.Drawing.Point(140, 53);
            this.tbxSonFiyat.Name = "tbxSonFiyat";
            this.tbxSonFiyat.Size = new System.Drawing.Size(100, 20);
            this.tbxSonFiyat.TabIndex = 7;
            // 
            // tbxFiyat
            // 
            this.tbxFiyat.Location = new System.Drawing.Point(140, 27);
            this.tbxFiyat.Name = "tbxFiyat";
            this.tbxFiyat.Size = new System.Drawing.Size(100, 20);
            this.tbxFiyat.TabIndex = 6;
            // 
            // gbxBiletGünbelle
            // 
            this.gbxBiletGünbelle.Controls.Add(this.btnBiletKaldır);
            this.gbxBiletGünbelle.Controls.Add(this.btnBiletGüncelleme);
            this.gbxBiletGünbelle.Controls.Add(this.lblBiletGüncelleme);
            this.gbxBiletGünbelle.Controls.Add(this.lblSonGüncelleme);
            this.gbxBiletGünbelle.Controls.Add(this.tbxSonGüncelleme);
            this.gbxBiletGünbelle.Controls.Add(this.tbxBiletGüncelleme);
            this.gbxBiletGünbelle.Location = new System.Drawing.Point(851, 500);
            this.gbxBiletGünbelle.Name = "gbxBiletGünbelle";
            this.gbxBiletGünbelle.Size = new System.Drawing.Size(293, 125);
            this.gbxBiletGünbelle.TabIndex = 18;
            this.gbxBiletGünbelle.TabStop = false;
            this.gbxBiletGünbelle.Text = "Bilet Güncelleme";
            // 
            // btnBiletKaldır
            // 
            this.btnBiletKaldır.Location = new System.Drawing.Point(61, 79);
            this.btnBiletKaldır.Name = "btnBiletKaldır";
            this.btnBiletKaldır.Size = new System.Drawing.Size(75, 23);
            this.btnBiletKaldır.TabIndex = 13;
            this.btnBiletKaldır.Text = "Kaldır";
            this.btnBiletKaldır.UseVisualStyleBackColor = true;
            this.btnBiletKaldır.Click += new System.EventHandler(this.btnBiletKaldır_Click);
            // 
            // btnBiletGüncelleme
            // 
            this.btnBiletGüncelleme.Location = new System.Drawing.Point(165, 79);
            this.btnBiletGüncelleme.Name = "btnBiletGüncelleme";
            this.btnBiletGüncelleme.Size = new System.Drawing.Size(75, 23);
            this.btnBiletGüncelleme.TabIndex = 11;
            this.btnBiletGüncelleme.Text = "Güncelle";
            this.btnBiletGüncelleme.UseVisualStyleBackColor = true;
            this.btnBiletGüncelleme.Click += new System.EventHandler(this.btnBiletGüncelleme_Click);
            // 
            // lblBiletGüncelleme
            // 
            this.lblBiletGüncelleme.AutoSize = true;
            this.lblBiletGüncelleme.Location = new System.Drawing.Point(58, 34);
            this.lblBiletGüncelleme.Name = "lblBiletGüncelleme";
            this.lblBiletGüncelleme.Size = new System.Drawing.Size(54, 13);
            this.lblBiletGüncelleme.TabIndex = 1;
            this.lblBiletGüncelleme.Text = "Bilet Fiyatı";
            // 
            // lblSonGüncelleme
            // 
            this.lblSonGüncelleme.AutoSize = true;
            this.lblSonGüncelleme.Location = new System.Drawing.Point(58, 61);
            this.lblSonGüncelleme.Name = "lblSonGüncelleme";
            this.lblSonGüncelleme.Size = new System.Drawing.Size(51, 13);
            this.lblSonGüncelleme.TabIndex = 2;
            this.lblSonGüncelleme.Text = "Son Fiyat";
            // 
            // tbxSonGüncelleme
            // 
            this.tbxSonGüncelleme.Location = new System.Drawing.Point(140, 53);
            this.tbxSonGüncelleme.Name = "tbxSonGüncelleme";
            this.tbxSonGüncelleme.Size = new System.Drawing.Size(100, 20);
            this.tbxSonGüncelleme.TabIndex = 7;
            // 
            // tbxBiletGüncelleme
            // 
            this.tbxBiletGüncelleme.Location = new System.Drawing.Point(140, 27);
            this.tbxBiletGüncelleme.Name = "tbxBiletGüncelleme";
            this.tbxBiletGüncelleme.Size = new System.Drawing.Size(100, 20);
            this.tbxBiletGüncelleme.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 684);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 91);
            this.dataGridView1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 752);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1156, 813);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxBiletGünbelle);
            this.Controls.Add(this.gbxBilet);
            this.Controls.Add(this.dgwBilet);
            this.Controls.Add(this.dgwSeyahat);
            this.Controls.Add(this.gbxSeyahatGüncelle);
            this.Controls.Add(this.gbxSeyahat);
            this.Controls.Add(this.gbxYolcuGüncelle);
            this.Controls.Add(this.gbxYolcuEkle);
            this.Controls.Add(this.dgwYolcular);
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgwYolcular)).EndInit();
            this.gbxYolcuEkle.ResumeLayout(false);
            this.gbxYolcuEkle.PerformLayout();
            this.gbxYolcuGüncelle.ResumeLayout(false);
            this.gbxYolcuGüncelle.PerformLayout();
            this.gbxSeyahat.ResumeLayout(false);
            this.gbxSeyahat.PerformLayout();
            this.gbxSeyahatGüncelle.ResumeLayout(false);
            this.gbxSeyahatGüncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSeyahat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBilet)).EndInit();
            this.gbxBilet.ResumeLayout(false);
            this.gbxBilet.PerformLayout();
            this.gbxBiletGünbelle.ResumeLayout(false);
            this.gbxBiletGünbelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridView dgwYolcular;
        private System.Windows.Forms.Label lblİsim;
        private System.Windows.Forms.Label lblYaş;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblİletişimNo;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox tbxİsim;
        private System.Windows.Forms.TextBox tbxYaş;
        private System.Windows.Forms.TextBox tbxCinsiyet;
        private System.Windows.Forms.TextBox tbxİletişimNo;
        private System.Windows.Forms.TextBox tbxAdres;
        private System.Windows.Forms.GroupBox gbxYolcuEkle;
        private System.Windows.Forms.Button btnYolcuEkle;
        private System.Windows.Forms.GroupBox gbxYolcuGüncelle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label lblİsimGüncelle;
        private System.Windows.Forms.TextBox tbxAdresGüncelle;
        private System.Windows.Forms.Label lblYaşGüncelle;
        private System.Windows.Forms.TextBox tbxİletişimNoGüncelle;
        private System.Windows.Forms.Label lblCinsiyetGüncelle;
        private System.Windows.Forms.TextBox tbxCinsiyetGüncelle;
        private System.Windows.Forms.Label lblİletişimNoGüncelle;
        private System.Windows.Forms.TextBox tbxYaşGüncelle;
        private System.Windows.Forms.Label lblAdresGüncelle;
        private System.Windows.Forms.TextBox tbxİsimGüncelle;
        private System.Windows.Forms.Button btnKaldır;
        private System.Windows.Forms.GroupBox gbxSeyahat;
        private System.Windows.Forms.Button btnSeyahatEkle;
        private System.Windows.Forms.Label lblBiniş;
        private System.Windows.Forms.Label lblİniş;
        private System.Windows.Forms.TextBox tbxSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox tbxTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.TextBox tbxİniş;
        private System.Windows.Forms.TextBox tbxBiniş;
        private System.Windows.Forms.GroupBox gbxSeyahatGüncelle;
        private System.Windows.Forms.Button btnSeyahatKaldır;
        private System.Windows.Forms.Button btnSeyahatGüncelle;
        private System.Windows.Forms.Label lblBinişGüncelle;
        private System.Windows.Forms.Label lblİnişGüncelle;
        private System.Windows.Forms.TextBox tbxSaatGüncelle;
        private System.Windows.Forms.Label lblTarihGüncelle;
        private System.Windows.Forms.TextBox tbxTarihGüncelle;
        private System.Windows.Forms.Label lblSaatGüncelle;
        private System.Windows.Forms.TextBox tbxİnişGüncelle;
        private System.Windows.Forms.TextBox tbxBinişGüncelle;
        private System.Windows.Forms.DataGridView dgwSeyahat;
        private System.Windows.Forms.DataGridView dgwBilet;
        private System.Windows.Forms.GroupBox gbxBilet;
        private System.Windows.Forms.Button btnBilet;
        private System.Windows.Forms.Label lblBiletFiyat;
        private System.Windows.Forms.Label lblSonFiyat;
        private System.Windows.Forms.TextBox tbxSonFiyat;
        private System.Windows.Forms.TextBox tbxFiyat;
        private System.Windows.Forms.GroupBox gbxBiletGünbelle;
        private System.Windows.Forms.Button btnBiletKaldır;
        private System.Windows.Forms.Button btnBiletGüncelleme;
        private System.Windows.Forms.Label lblBiletGüncelleme;
        private System.Windows.Forms.Label lblSonGüncelleme;
        private System.Windows.Forms.TextBox tbxSonGüncelleme;
        private System.Windows.Forms.TextBox tbxBiletGüncelleme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }

}
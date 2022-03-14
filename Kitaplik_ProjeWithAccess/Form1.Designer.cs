namespace Kitaplık_ProjeAccess
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblKitapAdı = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtYazar = new System.Windows.Forms.TextBox();
            this.LblYazar = new System.Windows.Forms.Label();
            this.TxtSayfa = new System.Windows.Forms.TextBox();
            this.LblSayfa = new System.Windows.Forms.Label();
            this.CmbTur = new System.Windows.Forms.ComboBox();
            this.RbikinciEl = new System.Windows.Forms.RadioButton();
            this.RbYeni = new System.Windows.Forms.RadioButton();
            this.LblTur = new System.Windows.Forms.Label();
            this.LblDurum = new System.Windows.Forms.Label();
            this.LblKitapid = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtKitapAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LblKitapAdı
            // 
            this.LblKitapAdı.AutoSize = true;
            this.LblKitapAdı.Location = new System.Drawing.Point(40, 71);
            this.LblKitapAdı.Name = "LblKitapAdı";
            this.LblKitapAdı.Size = new System.Drawing.Size(103, 23);
            this.LblKitapAdı.TabIndex = 1;
            this.LblKitapAdı.Text = "Kitap Adı :";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(158, 70);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(197, 29);
            this.TxtAd.TabIndex = 2;
            // 
            // TxtYazar
            // 
            this.TxtYazar.Location = new System.Drawing.Point(158, 106);
            this.TxtYazar.Name = "TxtYazar";
            this.TxtYazar.Size = new System.Drawing.Size(197, 29);
            this.TxtYazar.TabIndex = 4;
            // 
            // LblYazar
            // 
            this.LblYazar.AutoSize = true;
            this.LblYazar.Location = new System.Drawing.Point(74, 106);
            this.LblYazar.Name = "LblYazar";
            this.LblYazar.Size = new System.Drawing.Size(69, 23);
            this.LblYazar.TabIndex = 3;
            this.LblYazar.Text = "Yazar :";
            // 
            // TxtSayfa
            // 
            this.TxtSayfa.Location = new System.Drawing.Point(158, 141);
            this.TxtSayfa.Name = "TxtSayfa";
            this.TxtSayfa.Size = new System.Drawing.Size(197, 29);
            this.TxtSayfa.TabIndex = 6;
            // 
            // LblSayfa
            // 
            this.LblSayfa.AutoSize = true;
            this.LblSayfa.Location = new System.Drawing.Point(76, 141);
            this.LblSayfa.Name = "LblSayfa";
            this.LblSayfa.Size = new System.Drawing.Size(67, 23);
            this.LblSayfa.TabIndex = 5;
            this.LblSayfa.Text = "Sayfa :";
            // 
            // CmbTur
            // 
            this.CmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTur.FormattingEnabled = true;
            this.CmbTur.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir",
            "Tiyatro"});
            this.CmbTur.Location = new System.Drawing.Point(158, 177);
            this.CmbTur.Name = "CmbTur";
            this.CmbTur.Size = new System.Drawing.Size(197, 31);
            this.CmbTur.TabIndex = 7;
            // 
            // RbikinciEl
            // 
            this.RbikinciEl.AutoSize = true;
            this.RbikinciEl.Location = new System.Drawing.Point(156, 223);
            this.RbikinciEl.Name = "RbikinciEl";
            this.RbikinciEl.Size = new System.Drawing.Size(99, 27);
            this.RbikinciEl.TabIndex = 8;
            this.RbikinciEl.TabStop = true;
            this.RbikinciEl.Text = "İkinci El";
            this.RbikinciEl.UseVisualStyleBackColor = true;
            this.RbikinciEl.CheckedChanged += new System.EventHandler(this.RbikinciEl_CheckedChanged);
            // 
            // RbYeni
            // 
            this.RbYeni.AutoSize = true;
            this.RbYeni.Location = new System.Drawing.Point(287, 223);
            this.RbYeni.Name = "RbYeni";
            this.RbYeni.Size = new System.Drawing.Size(66, 27);
            this.RbYeni.TabIndex = 9;
            this.RbYeni.TabStop = true;
            this.RbYeni.Text = "Yeni";
            this.RbYeni.UseVisualStyleBackColor = true;
            this.RbYeni.CheckedChanged += new System.EventHandler(this.RbYeni_CheckedChanged);
            // 
            // LblTur
            // 
            this.LblTur.AutoSize = true;
            this.LblTur.Location = new System.Drawing.Point(91, 182);
            this.LblTur.Name = "LblTur";
            this.LblTur.Size = new System.Drawing.Size(52, 23);
            this.LblTur.TabIndex = 10;
            this.LblTur.Text = "Tür :";
            // 
            // LblDurum
            // 
            this.LblDurum.AutoSize = true;
            this.LblDurum.Location = new System.Drawing.Point(61, 223);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(82, 23);
            this.LblDurum.TabIndex = 11;
            this.LblDurum.Text = "Durum :";
            // 
            // LblKitapid
            // 
            this.LblKitapid.AutoSize = true;
            this.LblKitapid.Location = new System.Drawing.Point(53, 29);
            this.LblKitapid.Name = "LblKitapid";
            this.LblKitapid.Size = new System.Drawing.Size(90, 23);
            this.LblKitapid.TabIndex = 12;
            this.LblKitapid.Text = "Kitap id :";
            // 
            // Txtid
            // 
            this.Txtid.Enabled = false;
            this.Txtid.Location = new System.Drawing.Point(158, 29);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(195, 29);
            this.Txtid.TabIndex = 13;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(402, 29);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(112, 37);
            this.btnListele.TabIndex = 14;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(402, 77);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 37);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(402, 125);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 37);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(402, 175);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(112, 37);
            this.btnGüncelle.TabIndex = 17;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(559, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // TxtKitapAra
            // 
            this.TxtKitapAra.Enabled = false;
            this.TxtKitapAra.Location = new System.Drawing.Point(576, 227);
            this.TxtKitapAra.Name = "TxtKitapAra";
            this.TxtKitapAra.Size = new System.Drawing.Size(204, 29);
            this.TxtKitapAra.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kitap Adı :";
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(634, 262);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(80, 33);
            this.BtnAra.TabIndex = 21;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(797, 562);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TxtKitapAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.LblKitapid);
            this.Controls.Add(this.LblDurum);
            this.Controls.Add(this.LblTur);
            this.Controls.Add(this.RbYeni);
            this.Controls.Add(this.RbikinciEl);
            this.Controls.Add(this.CmbTur);
            this.Controls.Add(this.TxtSayfa);
            this.Controls.Add(this.LblSayfa);
            this.Controls.Add(this.TxtYazar);
            this.Controls.Add(this.LblYazar);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.LblKitapAdı);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblKitapAdı;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtYazar;
        private System.Windows.Forms.Label LblYazar;
        private System.Windows.Forms.TextBox TxtSayfa;
        private System.Windows.Forms.Label LblSayfa;
        private System.Windows.Forms.ComboBox CmbTur;
        private System.Windows.Forms.RadioButton RbikinciEl;
        private System.Windows.Forms.RadioButton RbYeni;
        private System.Windows.Forms.Label LblTur;
        private System.Windows.Forms.Label LblDurum;
        private System.Windows.Forms.Label LblKitapid;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtKitapAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAra;
    }
}


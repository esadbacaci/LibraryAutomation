
namespace PresentationLayer
{
    partial class kitapislem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.combokitap = new System.Windows.Forms.ComboBox();
            this.datagrid_kitap = new System.Windows.Forms.DataGridView();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_kitapekle = new System.Windows.Forms.Button();
            this.btn_kitapguncelle = new System.Windows.Forms.Button();
            this.btn_kitapsil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtkitapad = new System.Windows.Forms.TextBox();
            this.txtkitapyazari = new System.Windows.Forms.TextBox();
            this.txtkitapyayinevi = new System.Windows.Forms.TextBox();
            this.txtkitapsayfa = new System.Windows.Forms.TextBox();
            this.txtkitapadet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gcombobox = new System.Windows.Forms.ComboBox();
            this.gtxtkitapad = new System.Windows.Forms.TextBox();
            this.gtxtkitapadet = new System.Windows.Forms.TextBox();
            this.gtxtsayfasayisi = new System.Windows.Forms.TextBox();
            this.gtxtyayinevi = new System.Windows.Forms.TextBox();
            this.gtxtkitapyazari = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_kitap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 34);
            this.label1.TabIndex = 48;
            this.label1.Text = "Kitap İşlemleri";
            // 
            // combokitap
            // 
            this.combokitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combokitap.FormattingEnabled = true;
            this.combokitap.Items.AddRange(new object[] {
            "Anı",
            "Anlatı",
            "Araştırma-İnceleme",
            "Bilim",
            "Biyografi",
            "Çizgi Roman",
            "Çocuk Kitapları",
            "Deneme",
            "Dini",
            "Dünya Klasikleri",
            "Edebiyat",
            "Eğitim",
            "Felsefe",
            "Gençlik",
            "Gezi",
            "Hikaye",
            "Hobi",
            "İnceleme",
            "İş Ekonomi - Hukuk",
            "Kişisel Gelişim",
            "Konuşmalar",
            "Masal",
            "Mektup",
            "Mizah",
            "Öykü",
            "Polisiye",
            "Psikoloji",
            "Resimli Öykü",
            "Roman",
            "Sağlık",
            "Sanat - Tasarım",
            "Sanat- Müzik",
            "Sinema Tarihi",
            "Söyleşi",
            "Suç",
            "Şiir",
            "Tarih",
            "Yemek Kitapları"});
            this.combokitap.Location = new System.Drawing.Point(160, 116);
            this.combokitap.Name = "combokitap";
            this.combokitap.Size = new System.Drawing.Size(245, 24);
            this.combokitap.TabIndex = 62;
            // 
            // datagrid_kitap
            // 
            this.datagrid_kitap.AllowUserToAddRows = false;
            this.datagrid_kitap.AllowUserToDeleteRows = false;
            this.datagrid_kitap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_kitap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_kitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_kitap.Location = new System.Drawing.Point(20, 424);
            this.datagrid_kitap.Name = "datagrid_kitap";
            this.datagrid_kitap.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_kitap.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid_kitap.RowHeadersVisible = false;
            this.datagrid_kitap.RowHeadersWidth = 51;
            this.datagrid_kitap.RowTemplate.Height = 24;
            this.datagrid_kitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_kitap.Size = new System.Drawing.Size(1275, 332);
            this.datagrid_kitap.TabIndex = 84;
            this.datagrid_kitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_kitap_CellClick);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_id.Location = new System.Drawing.Point(581, 36);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(19, 20);
            this.label_id.TabIndex = 98;
            this.label_id.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(881, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(372, 22);
            this.textBox1.TabIndex = 100;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_kitapekle
            // 
            this.btn_kitapekle.BackColor = System.Drawing.Color.White;
            this.btn_kitapekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitapekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_kitapekle.FlatAppearance.BorderSize = 0;
            this.btn_kitapekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_kitapekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_kitapekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapekle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapekle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btn_kitapekle.Location = new System.Drawing.Point(160, 333);
            this.btn_kitapekle.Name = "btn_kitapekle";
            this.btn_kitapekle.Size = new System.Drawing.Size(245, 50);
            this.btn_kitapekle.TabIndex = 102;
            this.btn_kitapekle.Text = "Kitap Ekle";
            this.btn_kitapekle.UseVisualStyleBackColor = false;
            this.btn_kitapekle.Click += new System.EventHandler(this.btn_kitapekle_Click);
            // 
            // btn_kitapguncelle
            // 
            this.btn_kitapguncelle.BackColor = System.Drawing.Color.White;
            this.btn_kitapguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitapguncelle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_kitapguncelle.FlatAppearance.BorderSize = 0;
            this.btn_kitapguncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_kitapguncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_kitapguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapguncelle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapguncelle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btn_kitapguncelle.Location = new System.Drawing.Point(585, 333);
            this.btn_kitapguncelle.Name = "btn_kitapguncelle";
            this.btn_kitapguncelle.Size = new System.Drawing.Size(245, 50);
            this.btn_kitapguncelle.TabIndex = 103;
            this.btn_kitapguncelle.Text = "Kitap Güncelle";
            this.btn_kitapguncelle.UseVisualStyleBackColor = false;
            this.btn_kitapguncelle.Click += new System.EventHandler(this.btn_kitapguncelle_Click);
            // 
            // btn_kitapsil
            // 
            this.btn_kitapsil.BackColor = System.Drawing.Color.White;
            this.btn_kitapsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitapsil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_kitapsil.FlatAppearance.BorderSize = 0;
            this.btn_kitapsil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_kitapsil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_kitapsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapsil.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapsil.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btn_kitapsil.Location = new System.Drawing.Point(881, 333);
            this.btn_kitapsil.Name = "btn_kitapsil";
            this.btn_kitapsil.Size = new System.Drawing.Size(245, 50);
            this.btn_kitapsil.TabIndex = 104;
            this.btn_kitapsil.Text = "Kitap Sil";
            this.btn_kitapsil.UseVisualStyleBackColor = false;
            this.btn_kitapsil.Click += new System.EventHandler(this.btn_kitapsil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::PresentationLayer.Properties.Resources.Close_64px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1232, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 62);
            this.button1.TabIndex = 105;
            this.button1.Text = "\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtkitapad
            // 
            this.txtkitapad.Location = new System.Drawing.Point(160, 73);
            this.txtkitapad.Name = "txtkitapad";
            this.txtkitapad.Size = new System.Drawing.Size(245, 22);
            this.txtkitapad.TabIndex = 106;
            // 
            // txtkitapyazari
            // 
            this.txtkitapyazari.Location = new System.Drawing.Point(160, 156);
            this.txtkitapyazari.Name = "txtkitapyazari";
            this.txtkitapyazari.Size = new System.Drawing.Size(245, 22);
            this.txtkitapyazari.TabIndex = 107;
            // 
            // txtkitapyayinevi
            // 
            this.txtkitapyayinevi.Location = new System.Drawing.Point(160, 200);
            this.txtkitapyayinevi.Name = "txtkitapyayinevi";
            this.txtkitapyayinevi.Size = new System.Drawing.Size(245, 22);
            this.txtkitapyayinevi.TabIndex = 108;
            // 
            // txtkitapsayfa
            // 
            this.txtkitapsayfa.Location = new System.Drawing.Point(160, 239);
            this.txtkitapsayfa.Name = "txtkitapsayfa";
            this.txtkitapsayfa.Size = new System.Drawing.Size(245, 22);
            this.txtkitapsayfa.TabIndex = 109;
            // 
            // txtkitapadet
            // 
            this.txtkitapadet.Location = new System.Drawing.Point(160, 282);
            this.txtkitapadet.Name = "txtkitapadet";
            this.txtkitapadet.Size = new System.Drawing.Size(245, 22);
            this.txtkitapadet.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 111;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 112;
            this.label3.Text = "Kitap Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 113;
            this.label4.Text = "Kitap Yazarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 114;
            this.label5.Text = "Yayınevi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 22);
            this.label6.TabIndex = 115;
            this.label6.Text = "Sayfa Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 116;
            this.label7.Text = "Kitap Adet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(446, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 22);
            this.label8.TabIndex = 122;
            this.label8.Text = "Kitap Adet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(446, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 22);
            this.label9.TabIndex = 121;
            this.label9.Text = "Sayfa Sayısı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(446, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 22);
            this.label10.TabIndex = 120;
            this.label10.Text = "Yayınevi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(446, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 22);
            this.label11.TabIndex = 119;
            this.label11.Text = "Kitap Yazarı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(446, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 22);
            this.label12.TabIndex = 118;
            this.label12.Text = "Kitap Türü";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(446, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 22);
            this.label13.TabIndex = 117;
            this.label13.Text = "Kitap Adı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(446, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 22);
            this.label14.TabIndex = 123;
            this.label14.Text = "ID";
            // 
            // gcombobox
            // 
            this.gcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcombobox.FormattingEnabled = true;
            this.gcombobox.Items.AddRange(new object[] {
            "Anı",
            "Anlatı",
            "Araştırma-İnceleme",
            "Bilim",
            "Biyografi",
            "Çizgi Roman",
            "Çocuk Kitapları",
            "Deneme",
            "Dini",
            "Dünya Klasikleri",
            "Edebiyat",
            "Eğitim",
            "Felsefe",
            "Gençlik",
            "Gezi",
            "Hikaye",
            "Hobi",
            "İnceleme",
            "İş Ekonomi - Hukuk",
            "Kişisel Gelişim",
            "Konuşmalar",
            "Masal",
            "Mektup",
            "Mizah",
            "Öykü",
            "Polisiye",
            "Psikoloji",
            "Resimli Öykü",
            "Roman",
            "Sağlık",
            "Sanat - Tasarım",
            "Sanat- Müzik",
            "Sinema Tarihi",
            "Söyleşi",
            "Suç",
            "Şiir",
            "Tarih",
            "Yemek Kitapları"});
            this.gcombobox.Location = new System.Drawing.Point(585, 116);
            this.gcombobox.Name = "gcombobox";
            this.gcombobox.Size = new System.Drawing.Size(245, 24);
            this.gcombobox.TabIndex = 94;
            // 
            // gtxtkitapad
            // 
            this.gtxtkitapad.Location = new System.Drawing.Point(585, 73);
            this.gtxtkitapad.Name = "gtxtkitapad";
            this.gtxtkitapad.Size = new System.Drawing.Size(245, 22);
            this.gtxtkitapad.TabIndex = 124;
            // 
            // gtxtkitapadet
            // 
            this.gtxtkitapadet.Location = new System.Drawing.Point(585, 282);
            this.gtxtkitapadet.Name = "gtxtkitapadet";
            this.gtxtkitapadet.Size = new System.Drawing.Size(245, 22);
            this.gtxtkitapadet.TabIndex = 128;
            // 
            // gtxtsayfasayisi
            // 
            this.gtxtsayfasayisi.Location = new System.Drawing.Point(585, 239);
            this.gtxtsayfasayisi.Name = "gtxtsayfasayisi";
            this.gtxtsayfasayisi.Size = new System.Drawing.Size(245, 22);
            this.gtxtsayfasayisi.TabIndex = 127;
            // 
            // gtxtyayinevi
            // 
            this.gtxtyayinevi.Location = new System.Drawing.Point(585, 200);
            this.gtxtyayinevi.Name = "gtxtyayinevi";
            this.gtxtyayinevi.Size = new System.Drawing.Size(245, 22);
            this.gtxtyayinevi.TabIndex = 126;
            // 
            // gtxtkitapyazari
            // 
            this.gtxtkitapyazari.Location = new System.Drawing.Point(585, 156);
            this.gtxtkitapyazari.Name = "gtxtkitapyazari";
            this.gtxtkitapyazari.Size = new System.Drawing.Size(245, 22);
            this.gtxtkitapyazari.TabIndex = 125;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(878, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(371, 18);
            this.label15.TabIndex = 129;
            this.label15.Text = "Aramak istediğiniz kitabın adını veya ID\'sini giriniz";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(878, 299);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 18);
            this.label16.TabIndex = 130;
            this.label16.Text = "Seçtiğiniz Kitabı Silin";
            // 
            // kitapislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1307, 768);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gtxtkitapadet);
            this.Controls.Add(this.gtxtsayfasayisi);
            this.Controls.Add(this.gtxtyayinevi);
            this.Controls.Add(this.gtxtkitapyazari);
            this.Controls.Add(this.gtxtkitapad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkitapadet);
            this.Controls.Add(this.txtkitapsayfa);
            this.Controls.Add(this.txtkitapyayinevi);
            this.Controls.Add(this.txtkitapyazari);
            this.Controls.Add(this.txtkitapad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_kitapsil);
            this.Controls.Add(this.btn_kitapguncelle);
            this.Controls.Add(this.btn_kitapekle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.gcombobox);
            this.Controls.Add(this.datagrid_kitap);
            this.Controls.Add(this.combokitap);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kitapislem";
            this.Text = "kitapislem";
            this.Load += new System.EventHandler(this.kitapislem_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kitapislem_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kitapislem_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.kitapislem_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_kitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combokitap;
        private System.Windows.Forms.DataGridView datagrid_kitap;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_kitapekle;
        private System.Windows.Forms.Button btn_kitapguncelle;
        private System.Windows.Forms.Button btn_kitapsil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtkitapad;
        private System.Windows.Forms.TextBox txtkitapyazari;
        private System.Windows.Forms.TextBox txtkitapyayinevi;
        private System.Windows.Forms.TextBox txtkitapsayfa;
        private System.Windows.Forms.TextBox txtkitapadet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox gcombobox;
        private System.Windows.Forms.TextBox gtxtkitapad;
        private System.Windows.Forms.TextBox gtxtkitapadet;
        private System.Windows.Forms.TextBox gtxtsayfasayisi;
        private System.Windows.Forms.TextBox gtxtyayinevi;
        private System.Windows.Forms.TextBox gtxtkitapyazari;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}
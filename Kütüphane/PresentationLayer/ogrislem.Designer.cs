
namespace PresentationLayer
{
    partial class ogrislem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cinsiyetbox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gcombobox = new System.Windows.Forms.ComboBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_ogrekle = new System.Windows.Forms.Button();
            this.btn_ogrguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtbolum = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtokuno = new System.Windows.Forms.TextBox();
            this.gtxtokulno = new System.Windows.Forms.TextBox();
            this.gtxttc = new System.Windows.Forms.TextBox();
            this.gtxtbolum = new System.Windows.Forms.TextBox();
            this.gtxtsoyad = new System.Windows.Forms.TextBox();
            this.gtxtad = new System.Windows.Forms.TextBox();
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
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 34);
            this.label1.TabIndex = 47;
            this.label1.Text = "Öğrenci Bilgileri";
            // 
            // cinsiyetbox
            // 
            this.cinsiyetbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinsiyetbox.FormattingEnabled = true;
            this.cinsiyetbox.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.cinsiyetbox.Location = new System.Drawing.Point(113, 286);
            this.cinsiyetbox.Name = "cinsiyetbox";
            this.cinsiyetbox.Size = new System.Drawing.Size(245, 24);
            this.cinsiyetbox.TabIndex = 68;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 303);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gcombobox
            // 
            this.gcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcombobox.FormattingEnabled = true;
            this.gcombobox.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.gcombobox.Location = new System.Drawing.Point(532, 286);
            this.gcombobox.Name = "gcombobox";
            this.gcombobox.Size = new System.Drawing.Size(245, 24);
            this.gcombobox.TabIndex = 82;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_id.Location = new System.Drawing.Point(528, 43);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(19, 20);
            this.label_id.TabIndex = 84;
            this.label_id.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(813, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 22);
            this.textBox1.TabIndex = 89;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            // 
            // btn_ogrekle
            // 
            this.btn_ogrekle.BackColor = System.Drawing.Color.White;
            this.btn_ogrekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ogrekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ogrekle.FlatAppearance.BorderSize = 0;
            this.btn_ogrekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_ogrekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ogrekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ogrekle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrekle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btn_ogrekle.Location = new System.Drawing.Point(113, 319);
            this.btn_ogrekle.Name = "btn_ogrekle";
            this.btn_ogrekle.Size = new System.Drawing.Size(245, 50);
            this.btn_ogrekle.TabIndex = 103;
            this.btn_ogrekle.Text = "Öğrenci Ekle";
            this.btn_ogrekle.UseVisualStyleBackColor = false;
            this.btn_ogrekle.Click += new System.EventHandler(this.btn_ogrekle_Click);
            // 
            // btn_ogrguncelle
            // 
            this.btn_ogrguncelle.BackColor = System.Drawing.Color.White;
            this.btn_ogrguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ogrguncelle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ogrguncelle.FlatAppearance.BorderSize = 0;
            this.btn_ogrguncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_ogrguncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ogrguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ogrguncelle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrguncelle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btn_ogrguncelle.Location = new System.Drawing.Point(532, 319);
            this.btn_ogrguncelle.Name = "btn_ogrguncelle";
            this.btn_ogrguncelle.Size = new System.Drawing.Size(245, 50);
            this.btn_ogrguncelle.TabIndex = 104;
            this.btn_ogrguncelle.Text = "Öğrenci Güncelle";
            this.btn_ogrguncelle.UseVisualStyleBackColor = false;
            this.btn_ogrguncelle.Click += new System.EventHandler(this.btn_ogrguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnsil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnsil.Location = new System.Drawing.Point(851, 319);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(277, 50);
            this.btnsil.TabIndex = 105;
            this.btnsil.Text = "Öğrenci Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(113, 80);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(245, 22);
            this.txtad.TabIndex = 106;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(113, 121);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(245, 22);
            this.txtsoyad.TabIndex = 107;
            // 
            // txtbolum
            // 
            this.txtbolum.Location = new System.Drawing.Point(113, 163);
            this.txtbolum.Name = "txtbolum";
            this.txtbolum.Size = new System.Drawing.Size(245, 22);
            this.txtbolum.TabIndex = 108;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(113, 204);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(245, 22);
            this.txttc.TabIndex = 109;
            // 
            // txtokuno
            // 
            this.txtokuno.Location = new System.Drawing.Point(113, 245);
            this.txtokuno.Name = "txtokuno";
            this.txtokuno.Size = new System.Drawing.Size(245, 22);
            this.txtokuno.TabIndex = 110;
            // 
            // gtxtokulno
            // 
            this.gtxtokulno.Location = new System.Drawing.Point(532, 247);
            this.gtxtokulno.Name = "gtxtokulno";
            this.gtxtokulno.Size = new System.Drawing.Size(245, 22);
            this.gtxtokulno.TabIndex = 115;
            // 
            // gtxttc
            // 
            this.gtxttc.Location = new System.Drawing.Point(532, 206);
            this.gtxttc.Name = "gtxttc";
            this.gtxttc.Size = new System.Drawing.Size(245, 22);
            this.gtxttc.TabIndex = 114;
            // 
            // gtxtbolum
            // 
            this.gtxtbolum.Location = new System.Drawing.Point(532, 165);
            this.gtxtbolum.Name = "gtxtbolum";
            this.gtxtbolum.Size = new System.Drawing.Size(245, 22);
            this.gtxtbolum.TabIndex = 113;
            // 
            // gtxtsoyad
            // 
            this.gtxtsoyad.Location = new System.Drawing.Point(532, 123);
            this.gtxtsoyad.Name = "gtxtsoyad";
            this.gtxtsoyad.Size = new System.Drawing.Size(245, 22);
            this.gtxtsoyad.TabIndex = 112;
            // 
            // gtxtad
            // 
            this.gtxtad.Location = new System.Drawing.Point(532, 82);
            this.gtxtad.Name = "gtxtad";
            this.gtxtad.Size = new System.Drawing.Size(245, 22);
            this.gtxtad.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 22);
            this.label2.TabIndex = 116;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 117;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 118;
            this.label4.Text = "Bölüm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 22);
            this.label5.TabIndex = 119;
            this.label5.Text = "Tc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 120;
            this.label6.Text = "Okul No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(13, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 121;
            this.label7.Text = "Cinsiyet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(432, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 127;
            this.label8.Text = "Cinsiyet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(431, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 22);
            this.label9.TabIndex = 126;
            this.label9.Text = "Okul No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(432, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 22);
            this.label10.TabIndex = 125;
            this.label10.Text = "Tc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(432, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 22);
            this.label11.TabIndex = 124;
            this.label11.Text = "Bölüm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(431, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 22);
            this.label12.TabIndex = 123;
            this.label12.Text = "Soyad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(431, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 22);
            this.label13.TabIndex = 122;
            this.label13.Text = "Ad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(432, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 22);
            this.label14.TabIndex = 128;
            this.label14.Text = "ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(809, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(404, 18);
            this.label15.TabIndex = 129;
            this.label15.Text = "Aramak istediğiniz öğrencinin adını veya TC\'sini giriniz";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(848, 290);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(280, 18);
            this.label16.TabIndex = 130;
            this.label16.Text = "Seçili Öğrenciyi Silmek İçin Tıklayınız";
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
            this.button1.Location = new System.Drawing.Point(1173, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 62);
            this.button1.TabIndex = 131;
            this.button1.Text = "\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ogrislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1248, 706);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
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
            this.Controls.Add(this.gtxtokulno);
            this.Controls.Add(this.gtxttc);
            this.Controls.Add(this.gtxtbolum);
            this.Controls.Add(this.gtxtsoyad);
            this.Controls.Add(this.gtxtad);
            this.Controls.Add(this.txtokuno);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtbolum);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btn_ogrguncelle);
            this.Controls.Add(this.btn_ogrekle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.gcombobox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cinsiyetbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ogrislem";
            this.Text = "ogrislem";
            this.Load += new System.EventHandler(this.ogrislem_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ogrislem_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ogrislem_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ogrislem_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cinsiyetbox;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox gcombobox;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ogrekle;
        private System.Windows.Forms.Button btn_ogrguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtbolum;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtokuno;
        private System.Windows.Forms.TextBox gtxtokulno;
        private System.Windows.Forms.TextBox gtxttc;
        private System.Windows.Forms.TextBox gtxtbolum;
        private System.Windows.Forms.TextBox gtxtsoyad;
        private System.Windows.Forms.TextBox gtxtad;
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
    }
}
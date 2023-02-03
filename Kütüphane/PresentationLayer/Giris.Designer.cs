
namespace PresentationLayer
{
    partial class Giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grafik = new System.Windows.Forms.Button();
            this.oduncliste = new System.Windows.Forms.Button();
            this.kitapislem = new System.Windows.Forms.Button();
            this.ogrislem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(621, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 44);
            this.label1.TabIndex = 26;
            this.label1.Text = "HOŞGELDİNİZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Sienna;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(-1, 590);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Muhammed Esad Bacacı";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::PresentationLayer.Properties.Resources.read_online_64px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(563, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(406, 90);
            this.button2.TabIndex = 39;
            this.button2.Text = "Öğrencinin Aldığı Kitaplar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.button1.Location = new System.Drawing.Point(898, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 62);
            this.button1.TabIndex = 37;
            this.button1.Text = "\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grafik
            // 
            this.grafik.BackColor = System.Drawing.Color.LightSeaGreen;
            this.grafik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grafik.FlatAppearance.BorderSize = 0;
            this.grafik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.grafik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grafik.ForeColor = System.Drawing.Color.White;
            this.grafik.Image = global::PresentationLayer.Properties.Resources.graph_64px;
            this.grafik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grafik.Location = new System.Drawing.Point(563, 526);
            this.grafik.Name = "grafik";
            this.grafik.Size = new System.Drawing.Size(406, 81);
            this.grafik.TabIndex = 36;
            this.grafik.Text = "Grafik";
            this.grafik.UseVisualStyleBackColor = false;
            this.grafik.Click += new System.EventHandler(this.grafik_Click);
            // 
            // oduncliste
            // 
            this.oduncliste.BackColor = System.Drawing.Color.LightSeaGreen;
            this.oduncliste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oduncliste.FlatAppearance.BorderSize = 0;
            this.oduncliste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.oduncliste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oduncliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oduncliste.ForeColor = System.Drawing.Color.White;
            this.oduncliste.Image = global::PresentationLayer.Properties.Resources.student_male2_64px;
            this.oduncliste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oduncliste.Location = new System.Drawing.Point(563, 262);
            this.oduncliste.Name = "oduncliste";
            this.oduncliste.Size = new System.Drawing.Size(406, 90);
            this.oduncliste.TabIndex = 35;
            this.oduncliste.Text = "Ödünç Listesi";
            this.oduncliste.UseVisualStyleBackColor = false;
            this.oduncliste.Click += new System.EventHandler(this.oduncliste_Click);
            // 
            // kitapislem
            // 
            this.kitapislem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.kitapislem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapislem.FlatAppearance.BorderSize = 0;
            this.kitapislem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.kitapislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapislem.ForeColor = System.Drawing.Color.White;
            this.kitapislem.Image = global::PresentationLayer.Properties.Resources.book_64px;
            this.kitapislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitapislem.Location = new System.Drawing.Point(563, 178);
            this.kitapislem.Name = "kitapislem";
            this.kitapislem.Size = new System.Drawing.Size(406, 90);
            this.kitapislem.TabIndex = 34;
            this.kitapislem.Text = "Kitap İşlemleri";
            this.kitapislem.UseVisualStyleBackColor = false;
            this.kitapislem.Click += new System.EventHandler(this.kitapislem_Click);
            // 
            // ogrislem
            // 
            this.ogrislem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ogrislem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogrislem.FlatAppearance.BorderSize = 0;
            this.ogrislem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.ogrislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrislem.ForeColor = System.Drawing.Color.White;
            this.ogrislem.Image = global::PresentationLayer.Properties.Resources.student_registration_64px;
            this.ogrislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ogrislem.Location = new System.Drawing.Point(563, 91);
            this.ogrislem.Name = "ogrislem";
            this.ogrislem.Size = new System.Drawing.Size(406, 90);
            this.ogrislem.TabIndex = 33;
            this.ogrislem.Text = "Öğrenci İşlemleri";
            this.ogrislem.UseVisualStyleBackColor = false;
            this.ogrislem.Click += new System.EventHandler(this.ogrislem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.kütüphane;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 621);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::PresentationLayer.Properties.Resources.booklist_64px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(563, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(406, 90);
            this.button3.TabIndex = 40;
            this.button3.Text = "Kitabı Alanlar Bilgisi";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(968, 611);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grafik);
            this.Controls.Add(this.oduncliste);
            this.Controls.Add(this.kitapislem);
            this.Controls.Add(this.ogrislem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ogrislem;
        private System.Windows.Forms.Button grafik;
        private System.Windows.Forms.Button oduncliste;
        private System.Windows.Forms.Button kitapislem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}



namespace PresentationLayer
{
    partial class ogrencialdigikitaplar
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
            this.datagridogr = new System.Windows.Forms.DataGridView();
            this.datagridalinan = new System.Windows.Forms.DataGridView();
            this.label_bilgilendirme = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridogr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridalinan)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridogr
            // 
            this.datagridogr.AllowUserToAddRows = false;
            this.datagridogr.AllowUserToDeleteRows = false;
            this.datagridogr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datagridogr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridogr.Location = new System.Drawing.Point(12, 80);
            this.datagridogr.Name = "datagridogr";
            this.datagridogr.ReadOnly = true;
            this.datagridogr.RowHeadersVisible = false;
            this.datagridogr.RowHeadersWidth = 51;
            this.datagridogr.RowTemplate.Height = 24;
            this.datagridogr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridogr.Size = new System.Drawing.Size(1095, 176);
            this.datagridogr.TabIndex = 73;
            this.datagridogr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridogr_CellClick);
            this.datagridogr.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridogr_CellDoubleClick);
            // 
            // datagridalinan
            // 
            this.datagridalinan.AllowUserToAddRows = false;
            this.datagridalinan.AllowUserToDeleteRows = false;
            this.datagridalinan.AllowUserToResizeColumns = false;
            this.datagridalinan.AllowUserToResizeRows = false;
            this.datagridalinan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datagridalinan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridalinan.Location = new System.Drawing.Point(12, 288);
            this.datagridalinan.Name = "datagridalinan";
            this.datagridalinan.ReadOnly = true;
            this.datagridalinan.RowHeadersVisible = false;
            this.datagridalinan.RowHeadersWidth = 51;
            this.datagridalinan.RowTemplate.Height = 24;
            this.datagridalinan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridalinan.Size = new System.Drawing.Size(609, 275);
            this.datagridalinan.TabIndex = 74;
            // 
            // label_bilgilendirme
            // 
            this.label_bilgilendirme.AutoSize = true;
            this.label_bilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bilgilendirme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_bilgilendirme.Location = new System.Drawing.Point(627, 322);
            this.label_bilgilendirme.Name = "label_bilgilendirme";
            this.label_bilgilendirme.Size = new System.Drawing.Size(48, 25);
            this.label_bilgilendirme.TabIndex = 75;
            this.label_bilgilendirme.Text = "Bilgi";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(716, 288);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 17);
            this.label_id.TabIndex = 76;
            this.label_id.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Öğrencinin aldığı kitapları görüntülemek için öğrenciye çift tıklayınız";
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
            this.button1.Location = new System.Drawing.Point(1044, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 62);
            this.button1.TabIndex = 77;
            this.button1.Text = "\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "Öğrenci ID :";
            // 
            // ogrencialdigikitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1119, 575);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_bilgilendirme);
            this.Controls.Add(this.datagridalinan);
            this.Controls.Add(this.datagridogr);
            this.Name = "ogrencialdigikitaplar";
            this.Text = "ogrencialdigikitaplar";
            this.Load += new System.EventHandler(this.ogrencialdigikitaplar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ogrencialdigikitaplar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ogrencialdigikitaplar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ogrencialdigikitaplar_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.datagridogr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridalinan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridogr;
        private System.Windows.Forms.DataGridView datagridalinan;
        private System.Windows.Forms.Label label_bilgilendirme;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
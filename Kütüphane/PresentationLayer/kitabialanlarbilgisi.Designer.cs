
namespace PresentationLayer
{
    partial class kitabialanlarbilgisi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_bilgilendirme = new System.Windows.Forms.Label();
            this.datagridalinanktp = new System.Windows.Forms.DataGridView();
            this.datagridktp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridalinanktp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridktp)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Kitap ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Kitabı bugüne kadar alan öğrencileri görmek için kitaba çift tıklayınız";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(710, 281);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 17);
            this.label_id.TabIndex = 83;
            this.label_id.Text = "ID";
            // 
            // label_bilgilendirme
            // 
            this.label_bilgilendirme.AutoSize = true;
            this.label_bilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bilgilendirme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_bilgilendirme.Location = new System.Drawing.Point(621, 315);
            this.label_bilgilendirme.Name = "label_bilgilendirme";
            this.label_bilgilendirme.Size = new System.Drawing.Size(48, 25);
            this.label_bilgilendirme.TabIndex = 82;
            this.label_bilgilendirme.Text = "Bilgi";
            // 
            // datagridalinanktp
            // 
            this.datagridalinanktp.AllowUserToAddRows = false;
            this.datagridalinanktp.AllowUserToDeleteRows = false;
            this.datagridalinanktp.AllowUserToResizeColumns = false;
            this.datagridalinanktp.AllowUserToResizeRows = false;
            this.datagridalinanktp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datagridalinanktp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridalinanktp.Location = new System.Drawing.Point(6, 281);
            this.datagridalinanktp.Name = "datagridalinanktp";
            this.datagridalinanktp.ReadOnly = true;
            this.datagridalinanktp.RowHeadersVisible = false;
            this.datagridalinanktp.RowHeadersWidth = 51;
            this.datagridalinanktp.RowTemplate.Height = 24;
            this.datagridalinanktp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridalinanktp.Size = new System.Drawing.Size(609, 281);
            this.datagridalinanktp.TabIndex = 81;
            // 
            // datagridktp
            // 
            this.datagridktp.AllowUserToAddRows = false;
            this.datagridktp.AllowUserToDeleteRows = false;
            this.datagridktp.AllowUserToResizeColumns = false;
            this.datagridktp.AllowUserToResizeRows = false;
            this.datagridktp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datagridktp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridktp.Location = new System.Drawing.Point(6, 79);
            this.datagridktp.Name = "datagridktp";
            this.datagridktp.ReadOnly = true;
            this.datagridktp.RowHeadersVisible = false;
            this.datagridktp.RowHeadersWidth = 51;
            this.datagridktp.RowTemplate.Height = 24;
            this.datagridktp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridktp.Size = new System.Drawing.Size(1095, 179);
            this.datagridktp.TabIndex = 80;
            this.datagridktp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridktp_CellClick);
            this.datagridktp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridktp_CellDoubleClick);
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
            this.button1.TabIndex = 86;
            this.button1.Text = "\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kitabialanlarbilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1119, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_bilgilendirme);
            this.Controls.Add(this.datagridalinanktp);
            this.Controls.Add(this.datagridktp);
            this.Name = "kitabialanlarbilgisi";
            this.Text = "kitabialanlarbilgisi";
            this.Load += new System.EventHandler(this.kitabialanlarbilgisi_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kitabialanlarbilgisi_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kitabialanlarbilgisi_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.kitabialanlarbilgisi_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.datagridalinanktp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridktp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_bilgilendirme;
        private System.Windows.Forms.DataGridView datagridalinanktp;
        private System.Windows.Forms.DataGridView datagridktp;
        private System.Windows.Forms.Button button1;
    }
}
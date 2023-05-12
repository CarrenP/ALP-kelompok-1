namespace ALP_kelompok_1
{
    partial class Detail_order
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
            this.cb_title = new System.Windows.Forms.ComboBox();
            this.tb_namaLengkap = new System.Windows.Forms.TextBox();
            this.lbl_KetNama = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_ketEmail = new System.Windows.Forms.Label();
            this.cb_kodenegara = new System.Windows.Forms.ComboBox();
            this.lbl_kodenegara = new System.Windows.Forms.Label();
            this.lbl_kodenegara2 = new System.Windows.Forms.Label();
            this.tb_noTelp = new System.Windows.Forms.TextBox();
            this.lbl_ketNoTelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_title
            // 
            this.cb_title.FormattingEnabled = true;
            this.cb_title.Location = new System.Drawing.Point(12, 29);
            this.cb_title.Name = "cb_title";
            this.cb_title.Size = new System.Drawing.Size(143, 28);
            this.cb_title.TabIndex = 0;
            this.cb_title.Text = "         Title";
            // 
            // tb_namaLengkap
            // 
            this.tb_namaLengkap.Location = new System.Drawing.Point(268, 29);
            this.tb_namaLengkap.Name = "tb_namaLengkap";
            this.tb_namaLengkap.Size = new System.Drawing.Size(491, 26);
            this.tb_namaLengkap.TabIndex = 1;
            this.tb_namaLengkap.Text = "        Nama Lengkap";
            this.tb_namaLengkap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_KetNama
            // 
            this.lbl_KetNama.AutoSize = true;
            this.lbl_KetNama.Location = new System.Drawing.Point(264, 67);
            this.lbl_KetNama.Name = "lbl_KetNama";
            this.lbl_KetNama.Size = new System.Drawing.Size(442, 20);
            this.lbl_KetNama.TabIndex = 2;
            this.lbl_KetNama.Text = " Isi Sesuai KTP/  Paspor/ SIM (Tanpa Tanda Baca atau Gelar)";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(12, 127);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(747, 26);
            this.tb_email.TabIndex = 3;
            this.tb_email.Text = "Alama Email";
            this.tb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ketEmail
            // 
            this.lbl_ketEmail.AutoSize = true;
            this.lbl_ketEmail.Location = new System.Drawing.Point(12, 173);
            this.lbl_ketEmail.Name = "lbl_ketEmail";
            this.lbl_ketEmail.Size = new System.Drawing.Size(323, 20);
            this.lbl_ketEmail.TabIndex = 4;
            this.lbl_ketEmail.Text = "E-ticket anda akan dikirim ke alamat email ini";
            // 
            // cb_kodenegara
            // 
            this.cb_kodenegara.FormattingEnabled = true;
            this.cb_kodenegara.Location = new System.Drawing.Point(16, 251);
            this.cb_kodenegara.Name = "cb_kodenegara";
            this.cb_kodenegara.Size = new System.Drawing.Size(139, 28);
            this.cb_kodenegara.TabIndex = 5;
            // 
            // lbl_kodenegara
            // 
            this.lbl_kodenegara.AutoSize = true;
            this.lbl_kodenegara.Location = new System.Drawing.Point(25, 241);
            this.lbl_kodenegara.Name = "lbl_kodenegara";
            this.lbl_kodenegara.Size = new System.Drawing.Size(102, 20);
            this.lbl_kodenegara.TabIndex = 6;
            this.lbl_kodenegara.Text = "Kode Negara";
            // 
            // lbl_kodenegara2
            // 
            this.lbl_kodenegara2.AutoSize = true;
            this.lbl_kodenegara2.Location = new System.Drawing.Point(25, 305);
            this.lbl_kodenegara2.Name = "lbl_kodenegara2";
            this.lbl_kodenegara2.Size = new System.Drawing.Size(102, 20);
            this.lbl_kodenegara2.TabIndex = 7;
            this.lbl_kodenegara2.Text = "Kode Negara";
            // 
            // tb_noTelp
            // 
            this.tb_noTelp.Location = new System.Drawing.Point(235, 253);
            this.tb_noTelp.Name = "tb_noTelp";
            this.tb_noTelp.Size = new System.Drawing.Size(333, 26);
            this.tb_noTelp.TabIndex = 8;
            this.tb_noTelp.Text = "Nomor Telepon";
            this.tb_noTelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ketNoTelp
            // 
            this.lbl_ketNoTelp.AutoSize = true;
            this.lbl_ketNoTelp.Location = new System.Drawing.Point(264, 305);
            this.lbl_ketNoTelp.Name = "lbl_ketNoTelp";
            this.lbl_ketNoTelp.Size = new System.Drawing.Size(117, 20);
            this.lbl_ketNoTelp.TabIndex = 9;
            this.lbl_ketNoTelp.Text = "Nomor Telepon";
            // 
            // Detail_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ketNoTelp);
            this.Controls.Add(this.tb_noTelp);
            this.Controls.Add(this.lbl_kodenegara2);
            this.Controls.Add(this.lbl_kodenegara);
            this.Controls.Add(this.cb_kodenegara);
            this.Controls.Add(this.lbl_ketEmail);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_KetNama);
            this.Controls.Add(this.tb_namaLengkap);
            this.Controls.Add(this.cb_title);
            this.Name = "Detail_order";
            this.Text = "Detail_order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_title;
        private System.Windows.Forms.TextBox tb_namaLengkap;
        private System.Windows.Forms.Label lbl_KetNama;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_ketEmail;
        private System.Windows.Forms.ComboBox cb_kodenegara;
        private System.Windows.Forms.Label lbl_kodenegara;
        private System.Windows.Forms.Label lbl_kodenegara2;
        private System.Windows.Forms.TextBox tb_noTelp;
        private System.Windows.Forms.Label lbl_ketNoTelp;
    }
}
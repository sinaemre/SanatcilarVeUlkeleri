namespace SanatciVeUlkeleri2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSanatcininUlkesi = new System.Windows.Forms.ComboBox();
            this.btnSanatciEkle = new System.Windows.Forms.Button();
            this.txtSanatciAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUlkeSil = new System.Windows.Forms.Button();
            this.lstSanatcilar = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUlke = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUlkeEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUlkeAd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbSanatcininUlkesi);
            this.groupBox1.Controls.Add(this.btnSanatciEkle);
            this.groupBox1.Controls.Add(this.txtSanatciAdı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(247, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 347);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sanatçı Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ülkesi";
            // 
            // cmbSanatcininUlkesi
            // 
            this.cmbSanatcininUlkesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSanatcininUlkesi.FormattingEnabled = true;
            this.cmbSanatcininUlkesi.Location = new System.Drawing.Point(6, 108);
            this.cmbSanatcininUlkesi.Name = "cmbSanatcininUlkesi";
            this.cmbSanatcininUlkesi.Size = new System.Drawing.Size(198, 21);
            this.cmbSanatcininUlkesi.TabIndex = 6;
            // 
            // btnSanatciEkle
            // 
            this.btnSanatciEkle.Location = new System.Drawing.Point(129, 143);
            this.btnSanatciEkle.Name = "btnSanatciEkle";
            this.btnSanatciEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSanatciEkle.TabIndex = 5;
            this.btnSanatciEkle.Text = "Ekle";
            this.btnSanatciEkle.UseVisualStyleBackColor = true;
            this.btnSanatciEkle.Click += new System.EventHandler(this.btnSanatciEkle_Click);
            // 
            // txtSanatciAdı
            // 
            this.txtSanatciAdı.Location = new System.Drawing.Point(6, 54);
            this.txtSanatciAdı.Name = "txtSanatciAdı";
            this.txtSanatciAdı.Size = new System.Drawing.Size(198, 20);
            this.txtSanatciAdı.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sanatçı Adı";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnUlkeSil);
            this.groupBox3.Controls.Add(this.lstSanatcilar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbUlke);
            this.groupBox3.Location = new System.Drawing.Point(488, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 347);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sanatçılar";
            // 
            // btnUlkeSil
            // 
            this.btnUlkeSil.Location = new System.Drawing.Point(229, 51);
            this.btnUlkeSil.Name = "btnUlkeSil";
            this.btnUlkeSil.Size = new System.Drawing.Size(75, 23);
            this.btnUlkeSil.TabIndex = 8;
            this.btnUlkeSil.Text = "Ulke Sil";
            this.btnUlkeSil.UseVisualStyleBackColor = true;
            this.btnUlkeSil.Click += new System.EventHandler(this.btnUlkeSil_Click);
            // 
            // lstSanatcilar
            // 
            this.lstSanatcilar.FormattingEnabled = true;
            this.lstSanatcilar.Location = new System.Drawing.Point(9, 108);
            this.lstSanatcilar.Name = "lstSanatcilar";
            this.lstSanatcilar.Size = new System.Drawing.Size(195, 212);
            this.lstSanatcilar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sanatçılar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ülke";
            // 
            // cmbUlke
            // 
            this.cmbUlke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUlke.FormattingEnabled = true;
            this.cmbUlke.Location = new System.Drawing.Point(6, 53);
            this.cmbUlke.Name = "cmbUlke";
            this.cmbUlke.Size = new System.Drawing.Size(198, 21);
            this.cmbUlke.TabIndex = 8;
            this.cmbUlke.SelectedIndexChanged += new System.EventHandler(this.cmbUlke_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnUlkeEkle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtUlkeAd);
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 347);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ülke Ekle";
            // 
            // btnUlkeEkle
            // 
            this.btnUlkeEkle.Location = new System.Drawing.Point(132, 90);
            this.btnUlkeEkle.Name = "btnUlkeEkle";
            this.btnUlkeEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUlkeEkle.TabIndex = 2;
            this.btnUlkeEkle.Text = "Ekle";
            this.btnUlkeEkle.UseVisualStyleBackColor = true;
            this.btnUlkeEkle.Click += new System.EventHandler(this.btnUlkeEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ülke Adı";
            // 
            // txtUlkeAd
            // 
            this.txtUlkeAd.Location = new System.Drawing.Point(9, 54);
            this.txtUlkeAd.Name = "txtUlkeAd";
            this.txtUlkeAd.Size = new System.Drawing.Size(198, 20);
            this.txtUlkeAd.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSanatcininUlkesi;
        private System.Windows.Forms.Button btnSanatciEkle;
        private System.Windows.Forms.TextBox txtSanatciAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUlkeSil;
        private System.Windows.Forms.ListBox lstSanatcilar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUlke;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUlkeEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUlkeAd;
    }
}


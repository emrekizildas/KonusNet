namespace Alpha_Web
{
    partial class ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayarlar));
            this.label1 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mailadres = new System.Windows.Forms.TextBox();
            this.backnot = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rapor = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ana Sayfa Adresi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(197, 52);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(342, 20);
            this.adres.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.label2.Location = new System.Drawing.Point(46, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-Posta Sayfası:";
            // 
            // mailadres
            // 
            this.mailadres.Location = new System.Drawing.Point(197, 94);
            this.mailadres.Name = "mailadres";
            this.mailadres.Size = new System.Drawing.Size(342, 20);
            this.mailadres.TabIndex = 8;
            // 
            // backnot
            // 
            this.backnot.AutoSize = true;
            this.backnot.BackColor = System.Drawing.Color.White;
            this.backnot.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.backnot.Location = new System.Drawing.Point(46, 136);
            this.backnot.Name = "backnot";
            this.backnot.Size = new System.Drawing.Size(166, 29);
            this.backnot.TabIndex = 9;
            this.backnot.Text = "Sesli Geri Bildirim";
            this.backnot.UseVisualStyleBackColor = false;
            this.backnot.CheckedChanged += new System.EventHandler(this.backnot_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 7);
            this.label3.TabIndex = 11;
            this.label3.Text = "© KızılSoft - 4.4.4.0001";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::Alpha_Web.Properties.Resources.ok_shield_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(456, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "KAYDET";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rapor
            // 
            this.rapor.AutoSize = true;
            this.rapor.BackColor = System.Drawing.Color.White;
            this.rapor.Checked = true;
            this.rapor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rapor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rapor.Location = new System.Drawing.Point(99, 221);
            this.rapor.Name = "rapor";
            this.rapor.Size = new System.Drawing.Size(209, 17);
            this.rapor.TabIndex = 13;
            this.rapor.Text = "Kullanıcı Raporumu KızılSoft\'a Bildir";
            this.rapor.UseVisualStyleBackColor = false;
            this.rapor.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Alpha_Web.Properties.Resources.Mikrofon;
            this.pictureBox1.Location = new System.Drawing.Point(421, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.komutlar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Alpha_Web.Properties.Resources.Dur;
            this.pictureBox2.Location = new System.Drawing.Point(537, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Alpha_Web.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(25, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "KonuşNet Ayarları";
            // 
            // ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 257);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rapor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backnot);
            this.Controls.Add(this.mailadres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KonuşNet Ayarları";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailadres;
        private System.Windows.Forms.CheckBox backnot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox rapor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
    }
}
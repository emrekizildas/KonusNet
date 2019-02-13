namespace Alpha_Web
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.yukleme = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yenileBtn = new System.Windows.Forms.ToolStripButton();
            this.geriBtn = new System.Windows.Forms.ToolStripButton();
            this.dur = new System.Windows.Forms.ToolStripButton();
            this.adrescubugu = new System.Windows.Forms.ToolStripTextBox();
            this.youtube = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.muzikBtn = new System.Windows.Forms.ToolStripButton();
            this.ayarlarBtn = new System.Windows.Forms.ToolStripButton();
            this.anasayfaBtn = new System.Windows.Forms.ToolStripButton();
            this.algilama = new System.Windows.Forms.ToolStripLabel();
            this.konusma = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hakkindaBtn = new System.Windows.Forms.ToolStripButton();
            this.tarayici = new Gecko.GeckoWebBrowser();
            this.algisure = new System.Windows.Forms.Timer(this.components);
            this.raportime = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yukleme,
            this.toolStripSeparator1,
            this.yenileBtn,
            this.geriBtn,
            this.dur,
            this.adrescubugu,
            this.youtube,
            this.toolStripButton1,
            this.muzikBtn,
            this.ayarlarBtn,
            this.anasayfaBtn,
            this.algilama,
            this.konusma,
            this.toolStripSeparator2,
            this.hakkindaBtn});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // yukleme
            // 
            this.yukleme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yukleme.Enabled = false;
            this.yukleme.Image = global::Alpha_Web.Properties.Resources.algilama;
            this.yukleme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yukleme.Name = "yukleme";
            this.yukleme.Size = new System.Drawing.Size(23, 22);
            this.yukleme.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // yenileBtn
            // 
            this.yenileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yenileBtn.Image = global::Alpha_Web.Properties.Resources.Yenile;
            this.yenileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yenileBtn.Name = "yenileBtn";
            this.yenileBtn.Size = new System.Drawing.Size(23, 22);
            this.yenileBtn.Text = "Yenile";
            this.yenileBtn.Click += new System.EventHandler(this.yenileBtn_Click);
            // 
            // geriBtn
            // 
            this.geriBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.geriBtn.Image = global::Alpha_Web.Properties.Resources.Geri;
            this.geriBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.geriBtn.Name = "geriBtn";
            this.geriBtn.Size = new System.Drawing.Size(23, 22);
            this.geriBtn.Text = "Önceki";
            this.geriBtn.Click += new System.EventHandler(this.geriBtn_Click);
            this.geriBtn.MouseLeave += new System.EventHandler(this.geriBtn_MouseLeave);
            this.geriBtn.MouseHover += new System.EventHandler(this.geriBtn_MouseHover);
            // 
            // dur
            // 
            this.dur.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dur.Image = global::Alpha_Web.Properties.Resources.Dur;
            this.dur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dur.Name = "dur";
            this.dur.Size = new System.Drawing.Size(23, 22);
            this.dur.Text = "Dur";
            this.dur.Click += new System.EventHandler(this.dur_Click);
            this.dur.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.dur.MouseLeave += new System.EventHandler(this.dur_MouseLeave);
            // 
            // adrescubugu
            // 
            this.adrescubugu.Name = "adrescubugu";
            this.adrescubugu.Size = new System.Drawing.Size(300, 25);
            this.adrescubugu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adrescubugu_KeyPress);
            // 
            // youtube
            // 
            this.youtube.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.youtube.Image = global::Alpha_Web.Properties.Resources.youtube_icon;
            this.youtube.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.youtube.Name = "youtube";
            this.youtube.Size = new System.Drawing.Size(23, 22);
            this.youtube.Text = "MP3 İndir";
            this.youtube.Visible = false;
            this.youtube.Click += new System.EventHandler(this.youtube_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.button2_Click);
            // 
            // muzikBtn
            // 
            this.muzikBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.muzikBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.muzikBtn.Image = global::Alpha_Web.Properties.Resources.multiply_icon;
            this.muzikBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.muzikBtn.Name = "muzikBtn";
            this.muzikBtn.Size = new System.Drawing.Size(23, 22);
            this.muzikBtn.Text = "Müziği Kapat";
            this.muzikBtn.Visible = false;
            this.muzikBtn.Click += new System.EventHandler(this.muzikBtn_Click);
            // 
            // ayarlarBtn
            // 
            this.ayarlarBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ayarlarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ayarlarBtn.Image = global::Alpha_Web.Properties.Resources.ayarlar;
            this.ayarlarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ayarlarBtn.Name = "ayarlarBtn";
            this.ayarlarBtn.Size = new System.Drawing.Size(23, 22);
            this.ayarlarBtn.Text = "Ayarlar";
            this.ayarlarBtn.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // anasayfaBtn
            // 
            this.anasayfaBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.anasayfaBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.anasayfaBtn.Image = global::Alpha_Web.Properties.Resources.AnaSayfa;
            this.anasayfaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.anasayfaBtn.Name = "anasayfaBtn";
            this.anasayfaBtn.Size = new System.Drawing.Size(23, 22);
            this.anasayfaBtn.Text = "Ana Sayfa";
            this.anasayfaBtn.Visible = false;
            this.anasayfaBtn.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // algilama
            // 
            this.algilama.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.algilama.Name = "algilama";
            this.algilama.Size = new System.Drawing.Size(10, 22);
            this.algilama.Text = " ";
            // 
            // konusma
            // 
            this.konusma.Name = "konusma";
            this.konusma.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hakkindaBtn
            // 
            this.hakkindaBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.hakkindaBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hakkindaBtn.Image = global::Alpha_Web.Properties.Resources.logo;
            this.hakkindaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hakkindaBtn.Name = "hakkindaBtn";
            this.hakkindaBtn.Size = new System.Drawing.Size(23, 22);
            this.hakkindaBtn.Text = "Hakkımızda";
            this.hakkindaBtn.Click += new System.EventHandler(this.hakkindaBtn_Click);
            // 
            // tarayici
            // 
            this.tarayici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarayici.Location = new System.Drawing.Point(0, 25);
            this.tarayici.Name = "tarayici";
            this.tarayici.Size = new System.Drawing.Size(924, 480);
            this.tarayici.TabIndex = 1;
            this.tarayici.UseHttpActivityObserver = false;
            this.tarayici.Navigating += new System.EventHandler<Gecko.Events.GeckoNavigatingEventArgs>(this.tarayici_Navigating);
            this.tarayici.Navigated += new System.EventHandler<Gecko.GeckoNavigatedEventArgs>(this.tarayici_Navigated);
            this.tarayici.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(this.tarayici_DocumentCompleted);
            this.tarayici.DocumentTitleChanged += new System.EventHandler(this.tarayici_DocumentTitleChanged);
            this.tarayici.NSSError += new System.EventHandler<Gecko.Events.GeckoNSSErrorEventArgs>(this.tarayici_NSSError);
            // 
            // algisure
            // 
            this.algisure.Interval = 1200;
            this.algisure.Tick += new System.EventHandler(this.algisure_Tick_1);
            // 
            // raportime
            // 
            this.raportime.Interval = 5500;
            this.raportime.Tick += new System.EventHandler(this.raportime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 505);
            this.Controls.Add(this.tarayici);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KonuşNet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton yukleme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton yenileBtn;
        private System.Windows.Forms.ToolStripLabel algilama;
        private System.Windows.Forms.ToolStripButton dur;
        private System.Windows.Forms.Timer algisure;
        private System.Windows.Forms.ToolStripTextBox adrescubugu;
        private System.Windows.Forms.ToolStripButton geriBtn;
        private System.Windows.Forms.ToolStripButton youtube;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton ayarlarBtn;
        private System.Windows.Forms.ToolStripButton anasayfaBtn;
        private System.Windows.Forms.ToolStripTextBox konusma;
        private System.Windows.Forms.ToolStripButton muzikBtn;
        private System.Windows.Forms.Timer raportime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton hakkindaBtn;
        public Gecko.GeckoWebBrowser tarayici;

    }
}


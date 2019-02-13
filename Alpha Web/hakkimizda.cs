using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Alpha_Web
{
    public partial class hakkimizda : Form
    {
        public hakkimizda()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Dur_go;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Dur;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        public void GuncelKontrol()
        {
            string guncelsurumweb;
            
                try
                {

                    XmlTextReader okumaGorunumg = new XmlTextReader("http://tvcheck.zz.mu/surum/surum.xml");
                    while (okumaGorunumg.Read())
                    {
                        if (okumaGorunumg.NodeType == XmlNodeType.Element)
                        {
                            switch (okumaGorunumg.Name)
                            {
                                case "surumid":
                                    guncelsurumweb = okumaGorunumg.ReadString().ToString();
                                    if (guncelsurumweb == "4.4.4")
                                    {
                                        kontrolImage.Image = Properties.Resources.Web_Image;
                                        kontrolText.Text = "Yazılımınız güncel!";

                                    }
                                    else
                                    {

                                        kontrolImage.Image = Properties.Resources.Dur2_go;
                                        kontrolText.Text = "Yazılımınız güncel değil!("+guncelsurumweb+")";
                                    }
                                    okumaGorunumg.Close();
                                    break;

                            }
                        }
                    }
                }
                catch (Exception)
                {
                    kontrolImage.Image = Properties.Resources.Dur2_go;
                    kontrolText.Text = "Kontrol edilemiyor!";
                }

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
            form.tarayici.Navigate("http://konusnet.blogspot.com.tr/p/gizlilik-politikas.html");
        }

        private void kontrol_Tick(object sender, EventArgs e)
        {
            GuncelKontrol();
            kontrol.Stop();
            kontrol.Enabled = false;
        }

        private void hakkimizda_Load(object sender, EventArgs e)
        {
            kontrol.Start();
        }
    }
}

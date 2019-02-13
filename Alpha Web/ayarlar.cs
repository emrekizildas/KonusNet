using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Alpha_Web
{
    public partial class ayarlar : Form
    {



        public ayarlar()
        {
            InitializeComponent();
        }

        private void ayarlar_Load(object sender, EventArgs e)
        {

            StreamReader oku = new StreamReader(Application.StartupPath + @"\\xulrunner\\site.knet");

            
            adres.Text = oku.ReadLine();
            oku.Close();

            StreamReader oku2 = new StreamReader(Application.StartupPath + @"\\xulrunner\\mail.knet");


            mailadres.Text = oku2.ReadLine();
            oku2.Close();

            StreamReader oku3 = new StreamReader(Application.StartupPath + @"\\xulrunner\\backnot.knet");
            StreamReader oku4 = new StreamReader(Application.StartupPath + @"\\xulrunner\\rapor.knet");

            if (oku3.ReadLine() == "1")
            {
                backnot.CheckState = CheckState.Checked;
            }
            else if (oku3.ReadLine() == "0")
            {
                backnot.CheckState = CheckState.Unchecked;
            }
           

            
            else if (oku4.ReadLine() == "1")
            {
                rapor.CheckState = CheckState.Checked;
            }
            else if (oku4.ReadLine() == "0")
            {
                rapor.CheckState = CheckState.Unchecked;
            }
            oku3.Close();
            oku4.Close();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                StreamWriter yaz = new StreamWriter(Application.StartupPath + @"\\xulrunner\\site.knet");// dosyaya yazma kodu
                yaz.WriteLine(adres.Text);//veri değişkenindeki değerleri dosyaya yazdıran kod
                yaz.Close();// yazmak için açılan değişkeni kapatıyor


                StreamWriter yaz2 = new StreamWriter(Application.StartupPath + @"\\xulrunner\\mail.knet");// dosyaya yazma kodu
                yaz2.WriteLine(mailadres.Text);//veri değişkenindeki değerleri dosyaya yazdıran kod
                yaz2.Close();// yazmak için açılan değişkeni kapatıyor


                if (backnot.Checked == true)
                {
                    StreamWriter yaz3 = new StreamWriter(Application.StartupPath + @"\\xulrunner\\backnot.knet");// dosyaya yazma kodu
                    yaz3.WriteLine("1");//veri değişkenindeki değerleri dosyaya yazdıran kod
                    yaz3.Close();// yazmak için açılan değişkeni kapatıyor
                }
                else if (backnot.Checked == false)
                {
                    StreamWriter yaz4 = new StreamWriter(Application.StartupPath + @"\\xulrunner\\backnot.knet");// dosyaya yazma kodu
                    yaz4.WriteLine("0");//veri değişkenindeki değerleri dosyaya yazdıran kod
                    yaz4.Close();// yazmak için açılan değişkeni kapatıyor
                }

                 if (rapor.Checked == true)
                {
                    StreamWriter yaz3 = new StreamWriter(Application.StartupPath + @"\\xulrunner\\rapor.knet");// dosyaya yazma kodu
                    yaz3.WriteLine("1");//veri değişkenindeki değerleri dosyaya yazdıran kod
                    yaz3.Close();// yazmak için açılan değişkeni kapatıyor
                }
                else if (rapor.Checked == false)
                {
                    StreamWriter yaz4 = new StreamWriter(Application.StartupPath + @"\\xulrunner\\rapor.knet");// dosyaya yazma kodu
                    yaz4.WriteLine("0");//veri değişkenindeki değerleri dosyaya yazdıran kod
                    yaz4.Close();// yazmak için açılan değişkeni kapatıyor
                }

                this.Close();
            
            
              
            
        }

        private void backnot_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void komutlar_Click(object sender, EventArgs e)
        {
            StreamWriter yaz = new StreamWriter(Application.StartupPath + @"\\xulrunner\\site.knet");// dosyaya yazma kodu
            yaz.WriteLine(adres.Text);//veri değişkenindeki değerleri dosyaya yazdıran kod
            yaz.Close();// yazmak için açılan değişkeni kapatıyor


            StreamWriter yaz2 = new StreamWriter(Application.StartupPath + @"\\xulrunner\\mail.knet");// dosyaya yazma kodu
            yaz2.WriteLine(mailadres.Text);//veri değişkenindeki değerleri dosyaya yazdıran kod
            yaz2.Close();// yazmak için açılan değişkeni kapatıyor


            if (backnot.Checked == true)
            {
                StreamWriter yaz3 = new StreamWriter(Application.StartupPath + @"\\xulrunner\\backnot.knet");// dosyaya yazma kodu
                yaz3.WriteLine("1");//veri değişkenindeki değerleri dosyaya yazdıran kod
                yaz3.Close();// yazmak için açılan değişkeni kapatıyor
            }
            else if (backnot.Checked == false)
            {
                StreamWriter yaz4 = new StreamWriter(Application.StartupPath + @"\\xulrunner\\backnot.knet");// dosyaya yazma kodu
                yaz4.WriteLine("0");//veri değişkenindeki değerleri dosyaya yazdıran kod
                yaz4.Close();// yazmak için açılan değişkeni kapatıyor
            }

             if (rapor.Checked == true)
            {
                StreamWriter yaz3 = new StreamWriter(Application.StartupPath + @"\\xulrunner\\rapor.knet");// dosyaya yazma kodu
                yaz3.WriteLine("1");//veri değişkenindeki değerleri dosyaya yazdıran kod
                yaz3.Close();// yazmak için açılan değişkeni kapatıyor
            }
            else if (rapor.Checked == false)
            {
                StreamWriter yaz4 = new StreamWriter(Application.StartupPath + @"\\xulrunner\\rapor.knet");// dosyaya yazma kodu
                yaz4.WriteLine("0");//veri değişkenindeki değerleri dosyaya yazdıran kod
                yaz4.Close();// yazmak için açılan değişkeni kapatıyor
            }
            this.Close();

            komutlar komutlar = new komutlar();
            komutlar.Show();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Alpha_Web.Properties.Resources.Dur_go;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Alpha_Web.Properties.Resources.Dur;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

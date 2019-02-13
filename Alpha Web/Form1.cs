using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;
using SpeechLib;
using System.Net.NetworkInformation;
using System.Xml;
using Alpha_Web.Properties;
using Microsoft.Win32;
using Gecko;
using Gecko.DOM;
using Gecko.Certificates;
using System.Net;
using System.Windows.Shapes;
using System.IO;
using System.Net.Mail;

namespace Alpha_Web
{
    public partial class Form1 : Form
    {
        int bagli;
  
        string backnot;
        Gecko.GeckoWebBrowser muzik = new GeckoWebBrowser();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        SpVoice seslendirici = new SpVoice();


        private void SiteAc()
        {
            string key = @"http\shell\open\command";
            RegistryKey registryKey =
            Registry.ClassesRoot.OpenSubKey(key, false);
            // Varsayılan tarayıcının yolunu al. 
            // Aldığımız değer salt olarak programın 
            // yolu olmadığı için biraz işlememiz gerekiyor.
            string defaultbrowserpath =
            ((string)registryKey.GetValue(null, null)).Split('"')[1];
            //Process.Start ile başlat
            Process.Start(defaultbrowserpath, "https://sourceforge.net/projects/alphaweb/files/latest/download?source=navbar");
        }


        private void KomutlariOlustur()
        {
            string[] komutlar = new string[] { "una-suyfa", "twit-ter", "face-book", "Youtube", "a-postau", "Suipar-Leag", 
                "muziic deenlee", "How are you?", "Hello", "What is your name?", "What are you doing?","muziiei kuput",
                "How weadur today?","Bugüin hava nasul?"
                };
            Choices insChoices = new Choices(komutlar);
            GrammarBuilder insGrammarBuilder = new GrammarBuilder(insChoices);
            insGrammarBuilder.Culture = System.Globalization.CultureInfo.GetCultureInfo("en");
            Grammar insGrammar = new Grammar(insGrammarBuilder);
            sre.LoadGrammar(insGrammar);
        }


        public void Bagli()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    bagli = 1;
                }
            }
            catch
            {
                bagli = 0;
            }
        }

        public Form1()
        {
            Gecko.Xpcom.Initialize(@"xulrunner");
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.tarayici.Navigating += new EventHandler<Gecko.Events.GeckoNavigatingEventArgs>(tarayici_Navigating);
            tarayici.DocumentTitleChanged += new EventHandler(tarayici_DocumentTitleChanged);

            // string sUserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:31.0.0) Gecko/20100101 KonusNet/4.1";
         //   string sUserAgent = "Mozilla/5.0 (Linux; U; Android 4.4; tr-tr) AppleWebkit/534.30 (KHTML, like Gecko) Version/4.0 Mobile Safari/534.30";
            string sUserAgent = "Mozilla/5.0 ( rv:34.0) Gecko/20100101 Firefox/34.0/KonusNet/4.1";
            GeckoPreferences.User["general.useragent.override"] = sUserAgent;
            tarayici.DomContextMenu += new EventHandler<DomMouseEventArgs>(tarayici_DomContextMenu);
            
            Bagli();
            KomutlariOlustur();

            
      //      sre.RecognizeAsync(RecognizeMode.Multiple);
            sre.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(sre_SpeechDetected);
            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
            sre.RecognizeCompleted += new EventHandler<RecognizeCompletedEventArgs>(sre_RecognizeCompleted);
            sre.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(sre_SpeechRecognitionRejected);
            Thread t = new Thread(delegate() { sre.SetInputToDefaultAudioDevice(); sre.RecognizeAsync(RecognizeMode.Single); });
            t.Start();
        }
       
        void tarayici_DomContextMenu(object sender, DomMouseEventArgs e)
        {
            
        }

        void tarayici_DocumentTitleChanged(object sender, EventArgs e)
        {
            //anasayfa.Text = tarayici.Document.Title;
            this.Text = tarayici.Document.Title;

        }
        void tarayici_Navigating(object sender, Gecko.Events.GeckoNavigatingEventArgs e)
        {
            if (bagli == 1)
            {
                yukleme.Visible = true;

                yenileBtn.Visible = false;
                dur.Visible = true;
               // guvenli.Visible = false;

            }
            else
            {
                tarayici.Document.Body.InnerHtml = @" <html><title>Bağlantı Yok - KonuşNet</title>
 <body >
         <center>
		 <br/><br/><br/><img src='"+Application.StartupPath+@"/xulrunner/jsto/internetsiz.png'  /><br/><br/>
		 
		 <img src='"+Application.StartupPath+@"/xulrunner/jsto/logo.png' width='64' height='64' />
		 </center>
		 </body>
     </html>";
               
                
            }
        }



        void sre_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            
                // yukleme.Visible = false;
                algilama.Text = "Ses algılanamadı.";
                algilama.Visible = true;
                // algisure.Enabled = true;
                algisure.Start();
            

        }
        void sre_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
     sre.RecognizeAsync();
                // yukleme.Visible = false;


        }



        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            

                if (e.Result.Text == "una-suyfa")
                {
                    StreamReader oku = new StreamReader(Application.StartupPath + @"\\xulrunner\\site.knet");
                    tarayici.Navigate(oku.ReadLine());
                    oku.Close();
                    StreamReader oku2 = new StreamReader(Application.StartupPath + @"\\xulrunner\\backnot.knet");
                    if (oku2.ReadLine() == "1")
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = Application.StartupPath + @"\\xulrunner\\wav\\anasayfa.wav";
                        player.Play();
                        oku2.Close();
                    }
                    algilama.Text = "Ana Sayfa 'ya bağlanıyor...";
                    algilama.Visible = true;
                    algisure.Enabled = true;
                    algisure.Start();
                }
                else if (e.Result.Text == "twit-ter")
                {
                    tarayici.Navigate("http://www.twitter.com");
                    algilama.Text = "Twitter 'a bağlanıyor...";
                    algilama.Visible = true;
                    algisure.Enabled = true;
                    algisure.Start();
                }

                else if (e.Result.Text == "face-book")
                {
                    tarayici.Navigate("http://www.facebook.com");
                    algilama.Text = "Facebook 'a bağlanıyor...";
                    StreamReader oku = new StreamReader(Application.StartupPath + @"\\xulrunner\\backnot.knet");
                    if (oku.ReadLine() == "1")
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = Application.StartupPath + @"\\xulrunner\\wav\\facebook.wav";
                        player.Play();
                        oku.Close();
                    }
                    algilama.Visible = true;
                    algisure.Enabled = true;
                    algisure.Start();

                }
                else if (e.Result.Text == "Youtube")
                {
                    tarayici.Navigate("http://www.youtube.com");
                    algilama.Text = "Youtube 'a bağlanıyor...";
                    StreamReader oku = new StreamReader(Application.StartupPath + @"\\xulrunner\\backnot.knet");
                    if (oku.ReadLine() == "1")
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = Application.StartupPath + @"\\xulrunner\\wav\\youtube.wav";
                        player.Play();
                        oku.Close();
                    }
                    algilama.Visible = true;
                    algisure.Enabled = true;
                    algisure.Start();

                }
                else if (e.Result.Text == "a-postau")
                {
                    StreamReader oku = new StreamReader(Application.StartupPath + @"\\xulrunner\\mail.knet");
                    tarayici.Navigate(oku.ReadLine());
                    oku.Close();
                    algilama.Text = "Mail'e bağlanıyor...";
                    StreamReader oku2 = new StreamReader(Application.StartupPath + @"\\xulrunner\\backnot.knet");
                    if (oku2.ReadLine() == "1")
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = Application.StartupPath + @"\\xulrunner\\wav\\mail.wav";
                        player.Play();
                        oku2.Close();
                    }
                    algilama.Visible = true;
                    algisure.Enabled = true;
                    algisure.Start();

                }
                else if (e.Result.Text == "Suipar-Leag")
                {
                    tarayici.Navigate("http://www.tff.org/Default.aspx?pageID=198");
                    algilama.Text = "Süper Lig'e bağlanıyor...";
                    StreamReader oku = new StreamReader(Application.StartupPath + @"\\xulrunner\\backnot.knet");
                    if (oku.ReadLine() == "1")
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = Application.StartupPath + @"\\xulrunner\\wav\\superlig.wav";
                        player.Play();
                        oku.Close();
                    }
                    algilama.Visible = true;
                    algisure.Enabled = true;
                    algisure.Start();

                }
                //muziic
                else if (e.Result.Text == "muziic deenlee")
                {

                    muzik.Navigate("http://palstation106.com/webplayer/palstation_dinle.html");
                    algilama.Text = "Müziğe bağlanıyor...";
                    muzikBtn.Visible = true;
                    StreamReader oku = new StreamReader(Application.StartupPath + @"\\xulrunner\\backnot.knet");
                    if (oku.ReadLine() == "1")
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = Application.StartupPath + @"\\xulrunner\\wav\\muzik.wav";
                        player.Play();
                        oku.Close();
                    }
                    algilama.Visible = true;
                    algisure.Enabled = true;
                    algisure.Start();

                }

                else if (e.Result.Text == "How are you?")
                {

                    SpVoice seslendirici = new SpVoice();
                    seslendirici.Speak("Fine! You?", SpeechVoiceSpeakFlags.SVSFDefault);
                    algilama.Text = "Fine! You?";
                    algilama.Visible = true;
                    algisure.Enabled = true;
                    algisure.Start();

                }

                else if (e.Result.Text == "Hello")
                {

                    SpVoice seslendirici = new SpVoice();
                    seslendirici.Speak("Hi!", SpeechVoiceSpeakFlags.SVSFDefault);
                    algilama.Text = "Hi!";
                    algilama.Visible = true;
                    algisure.Enabled = true;
                    algisure.Start();

                }

                else if (e.Result.Text == "What is your name?")
                {

                    SpVoice seslendirici = new SpVoice();
                    seslendirici.Speak("My name is Browser!", SpeechVoiceSpeakFlags.SVSFDefault);
                    algilama.Text = "My name is Browser!";
                    algilama.Visible = true;
                    algisure.Enabled = true;
                    algisure.Start();

                }



                else if (e.Result.Text == "What are you doing?")
                {

                    SpVoice seslendirici = new SpVoice();
                    seslendirici.Speak("I'm listening to you.", SpeechVoiceSpeakFlags.SVSFDefault);
                    algilama.Text = "I'm listening to you.";
                    algilama.Visible = true;
                    algisure.Enabled = true;
                    algisure.Start();

                }
                //muziiei kuput
                else if (e.Result.Text == "muziiei kuput")
                {

                    muzik.Navigate("about:blank");
                    muzikBtn.Visible = false;
                    algilama.Text = "Müzik kapatıldı!";
                    algilama.Visible = true;
                    algisure.Enabled = true;
                    algisure.Start();

                }
            //Howv weather today?
                else if (e.Result.Text == "How weadur today?" || e.Result.Text == "Bugüin hava nasul?")
                {

                    SpVoice seslendirici = new SpVoice();
                    seslendirici.Speak("Please wait, I'm looking..", SpeechVoiceSpeakFlags.SVSFDefault);
                    algilama.Text = "Please wait, I'm looking..";
                    tarayici.Navigate("https://www.google.com.tr/?gfe_rd=cr&ei=waQ8Vee1NM-z8wfmzICgCA#q=hava+durumu");
                  
                    algilama.Visible = true;
                    algisure.Enabled = true;
                    algisure.Start();

                }

        }

        void sre_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
           
                algilama.Text = "Ses algılanıyor...";
                algilama.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                tarayici.Navigate(adrescubugu.Text);
            

            
            
        }

        void Form1_Load(object sender, EventArgs e)
        {
            raportime.Start();

            GuncelKontrol();
            tarayici.NoDefaultContextMenu = true;
           // sagBrowser.NoDefaultContextMenu = true;
                tarayici.NSSError += new EventHandler<Gecko.Events.GeckoNSSErrorEventArgs>(tarayici_NSSError);

                StreamReader oku = new StreamReader(Application.StartupPath + @"\\xulrunner\\site.knet");
                tarayici.Navigate(oku.ReadLine());
                oku.Close();

                StreamReader oku2 = new StreamReader(Application.StartupPath + @"\\xulrunner\\backnot.knet");
                backnot = oku2.ReadLine();
                oku2.Close();
                    
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();

                    if (backnot == "1")
                    {
                        player.SoundLocation = Application.StartupPath + @"\\xulrunner\\wav\\hos.wav";
                        player.Play();
                    }
            
        }

        void tarayici_NSSError(object sender, Gecko.Events.GeckoNSSErrorEventArgs eargs)
        {
            CertOverrideService.RememberRecentBadCert(eargs.Uri);
            Uri refUrl = tarayici.Url;
            tarayici.Navigate(eargs.Uri.AbsoluteUri, GeckoLoadFlags.FirstLoad, refUrl != null ? refUrl.AbsoluteUri : null, null);
            eargs.Handled = true;
        }




        private void button2_Click(object sender, EventArgs e)
        {
           SpVoice seslendirici = new SpVoice();
           seslendirici.Speak(konusma.Text, SpeechVoiceSpeakFlags.SVSFDefault);

           

           }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tarayici.Refresh();
        }








    



       private void pictureBox1_MouseEnter(object sender, EventArgs e)
       {
           dur.Image = Alpha_Web.Properties.Resources.Dur_go;
       }

       private void dur_MouseLeave(object sender, EventArgs e)
       {
           dur.Image = Alpha_Web.Properties.Resources.Dur;
       }

       private void geriBtn_Click(object sender, EventArgs e)
       {
           tarayici.GoBack();
       }

       private void yenileBtn_Click(object sender, EventArgs e)
       {
           tarayici.Reload();
       }

       private void dur_Click(object sender, EventArgs e)
       {
           tarayici.Stop();
       }


       public void GuncelKontrol()
       {
           string guncelsurumweb;
           if (bagli == 1)
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
                                   if (guncelsurumweb == "4.3.4")
                                   {
                                      

                                   }
                                   else
                                   {
                                     //  DialogResult sonucu;
                                    //  MessageBox.Show("Alpha Web'in güncel bir sürümü mevcut.Güncel sürümü yüklemek ister misiniz ? \nSürümünüz: " + guncelsurum + "  Güncel sürüm: " + guncelsurumweb, "Alpha Web Güncellemesi", MessageBoxButtons.YesNo);
                                      

                                       if ( MessageBox.Show("KonuşNet'in güncel bir sürümü mevcut.Güncel sürümü yüklemek ister misiniz ? \nSürümünüz: 4.3.4 Güncel sürüm: " + guncelsurumweb, "KonuşNet Güncellemesi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                       {
                                        //   yeniSekme("http://www.alphayazilim.net/");
                                           SiteAc();
                                           Application.Exit();

                                       }

                                   }
                                   okumaGorunumg.Close();
                                   break;
                                  
                           }
                       }
                   }
               }
               catch (Exception)
               {
               }

       }


       private void adrescubugu_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (e.KeyChar == (char)13)
           {
               tarayici.Navigate(adrescubugu.Text);
           }
       }

 

       private void geriBtn_MouseHover(object sender, EventArgs e)
       {
           geriBtn.Checked = true;
       }

       private void geriBtn_MouseLeave(object sender, EventArgs e)
       {
           geriBtn.Checked = false;
       }


       private void tarayici_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
       {
           
               adrescubugu.Text = tarayici.Url.ToString();
               yenileBtn.Visible = true;
               dur.Visible = false;
               //guvenli.Visible = true;
           

           
           //lblDurum.Visible = false;

           yukleme.Visible = false;
       }

       private void youtube_Click(object sender, EventArgs e)
       {

           tarayici.Navigate("http://www.youtube-mp3.org/?e=t_exp&r=true#v="+adrescubugu.Text.Substring(31,11));
            //tarayici.Navigate("http://2conv.com/yt_"+adrescubugu.Text.Substring(31,11));
       }


       private void tarayici_Navigated(object sender, GeckoNavigatedEventArgs e)
       {
           if (e.Uri.ToString().Contains("watch?") == true)
           {
               youtube.Visible = true;
           }
           else
           {
               youtube.Visible = false;
           }
       }

       


       private void algisure_Tick(object sender, EventArgs e)
       {
           
       }

       private void algisure_Tick_1(object sender, EventArgs e)
       {
           algilama.Visible = false;
           algilama.Text = "algıalma";
       }

       private void toolStripButton2_Click(object sender, EventArgs e)
       {
           ayarlar ayarlar = new ayarlar();
           ayarlar.Show();
       }

       private void toolStripButton3_Click(object sender, EventArgs e)
       {
           StreamReader oku = new StreamReader(Application.StartupPath + @"\\xulrunner\\site.knet");


           tarayici.Navigate( oku.ReadLine());
           oku.Close();
       }
       
       

       private void muzikBtn_Click(object sender, EventArgs e)
       {
           muzik.Navigate("about:blank");
           muzikBtn.Visible = false;
       }

       private void raportime_Tick(object sender, EventArgs e)
       {

           raportime.Stop();
           raportime.Enabled = false;
           
       }

       private void Form1_FormClosing(object sender, FormClosingEventArgs e)
       {
           muzik.Navigate("about:blank");
           tarayici.Navigate("about:blank");
       }

       private void hakkindaBtn_Click(object sender, EventArgs e)
       {
           hakkimizda hakk = new hakkimizda();
           hakk.Show();
       }


      
       
       
       

    }
}

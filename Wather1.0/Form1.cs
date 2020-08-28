using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Wather1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread thread1;
        int durum = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            //var lists = new List<Adds>()
            //{
            //    new Adds(){Url="http://halic.edu.tr/tr"},
            //    new Adds(){Url="http://saglikbilimleriyuksekokulu.halic.edu.tr/tr"},
            //};
            //Task t = Task.Run(() =>
            //  {
            //      ChromeTest("http://halic.edu.tr/tr");
            //  });

            // foreach (var item in lists)
            // {
            //    var res = ChromeTest(item.Url);
            //    textBox1.Text = res.ToString();
            //      Console.WriteLine(ChromeTest(item.Url));
            //     Console.WriteLine(FirefowTest(item.Url));
            //}
            //var r = ChromeTest("http://halic.edu.tr/tr");
            //textBox1.Text = r.ToString();

        }

        //public static string ChromeTest(string url)
        //{

        //    //var time1 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        //    //var options = new ChromeOptions();
        //    //options.AddArguments("headless");
        //    //var driverChrome = new ChromeDriver(options);
        //    //driverChrome.Url = url;
        //    //var time2 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond; //600000
        //    ////if (time2 > 60000)
        //    ////{
        //    ////    string path = string.Format(@"c:\log\ScreenShotAT{0:d_M_yyyy_HH_mm_ss}.png", DateTime.Now);
        //    ////    ITakesScreenshot screenshotHandler = driverChrome as ITakesScreenshot;
        //    ////    Screenshot screenshot = screenshotHandler.GetScreenshot();
        //    ////    screenshot.SaveAsFile(path, ScreenshotImageFormat.Jpeg);
        //    ////}

        //    //var result = "-----------------------" + url + "Chorome Sayfa Yanıt Süresi: " + (time2 - time1);
        //    //return result;
        //}

        //public static string FirefowTest(string url)
        //{
        //    var time3 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        //    FirefoxOptions foptions = new FirefoxOptions();
        //    foptions.AddArguments("--headless");
        //    var driverFirefox = new FirefoxDriver(foptions);
        //    //driverFirefox.Navigate().GoToUrl(url);

        //    driverFirefox.Quit();
        //    var time4 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

        //    var result = "-----------------------" + url + "Firefox Sayfa Yanıt Süresi: " + (time4 - time3);
        //    return result;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(new ThreadStart(Baslat));
            thread1.IsBackground = true;
            thread1.Start();
            dataGridView1.ColumnCount = 3;
            void Baslat()
            {
                for (; ; )
                {
                    if (durum == 0)
                    {
                        break;
                    }
                    var time1 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                    var options = new ChromeOptions();
                    options.AddArguments("headless");
                    var driverChrome = new ChromeDriver(options);
                    driverChrome.Url = "http://www.halic.edu.tr/tr";
                    var time2 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                    string[] row = new string[] { "http://www.halic.edu.tr/tr", "Chorome Sayfa Yanıt Süresi: ", Convert.ToString(time2 - time1) };
                    dataGridView1.Invoke(new System.Action(() => { dataGridView1.Rows.Add(row); }));
                    Thread.Sleep(1000);
                }

                //if (backgroundWorker1.IsBusy != true)
                //{
                //    /* Eğer backgroundWorker1 meşgul değilse yani işlem yapmıyorsa, butona bastığımda asenkron olacak bu işlemi başlatsın. 
                //     Asenkron işlem başlatmak yeni bir thread açmaktır yani basitçe açıklayacak olursak çalışan hiçbir farklı
                //     işlemi beklemeden kullanıcının istediği anda işlemin başlamasıdır. */
                //    backgroundWorker1.RunWorkerAsync();
                //}
            }
        }
        private void stop_Click(object sender, EventArgs e)
        {
            durum = 0;
            //if (backgroundWorker1.WorkerSupportsCancellation == true)
            //{
            //    /* Eğer backgroundWorker1 için durdurulabilme özelliği de aktifse ki başta aktif ettim, butona
            //     bastığımda backgroundWorker'in durdurulmasını istedim. Yanlış anlaşılmasın burada işlemi durdurmadım sadece
            //     durdurulmasını istedim */
            //    backgroundWorker1.CancelAsync();
            //}
        }
        //Thread olustur;
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //var r= ChromeTest("http://halic.edu.tr/tr");
            //textBox1.Text = r.ToString();
            //BackgroundWorker worker = sender as BackgroundWorker;

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (worker.CancellationPending == true)
            //    {
            //        Eğer yapılan işlemi durdumak için istek gönderildiyse, DoWork olayını durdur ve döngüden çık.
            //        e.Cancel = true;
            //        break;
            //    }
            //    else
            //    {

                   // olustur = new Thread(new ThreadStart(ChromeTest("http://halic.edu.tr/tr"));
                    //olustur.Start();
                    // Durdurma isteği gönderilmediyse işlemi gerçekleştirmeye devam et ve rapor et.

            //    }
            //}
            
            //Task t = Task.Run(() =>
            //{
            //  ChromeTest("http://halic.edu.tr/tr");
            //});

        }
        

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if (e.Cancelled == true)
            //{
            //    sonucLabel.Text = "Durduruldu!";
            //}
            //else if (e.Error != null)
            //{
            //    sonucLabel.Text = "Hata: " + e.Error.Message;
            //}
            //else
            //{
            //    sonucLabel.Text = "Tamamlandı!";
            //}
        }
    }
    public class Adds
    {
        public string Url { get; set; }
    }
}


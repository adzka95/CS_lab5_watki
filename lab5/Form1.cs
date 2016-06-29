using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace lab5
{
    public partial class Form1 : Form
    {

        private String odp1;
        private String odp2;
        private String odp3;
        delegate void delegat(int n, int k);
        delegate double delegatDwa(int i);

        public Form1()
        {
            odp1 = "";
            odp2 = "";
            odp3 = "";
            InitializeComponent();
        }

        private void delegaty(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int k = int.Parse(textBox2.Text);
            timer1.Start();
            delegat funkcja = new delegat(liczDelegaty);
            funkcja.BeginInvoke(n, k, null, null);
        }

        private void liczDelegaty(int n, int k){
            delegatDwa a = new delegatDwa(silniaDelegaty);
            delegatDwa b = new delegatDwa(silniaDelegaty);
            delegatDwa c = new delegatDwa(silniaDelegaty);
            IAsyncResult odpA= a.BeginInvoke(n, null, null);
            IAsyncResult odpB=b.BeginInvoke(k, null, null);
            IAsyncResult odpC=c.BeginInvoke(n - k, null, null);

            double wynik = a.EndInvoke(odpA)/(b.EndInvoke(odpB)*c.EndInvoke(odpC));
            odp2=wynik.ToString();
        }

        private double silniaDelegaty(int n) {
            double k = (double)n;
            double wynik = 1;
            Thread.Sleep(2000);
            for(double i=k; i>1; i--){
                wynik*=i;            
            }
            return wynik;       
        
        }

        private void taski(object sender, EventArgs e)
        {
            int n=int.Parse(textBox1.Text);
            int k= int.Parse(textBox2.Text);
            timer1.Start();
            Task wynik=Task.Run(()=>oblicz(n, k));
        }

        private void oblicz(int n, int k) {
            Task<double> a =  silnia(n);
            Task<double> b = silnia(k);
            Task<double> c =  silnia(n-k);
            a.Wait();
            b.Wait();
            c.Wait();
            Console.Write( (a.Result / (b.Result * c.Result)).ToString());
            odp1 = (a.Result / (b.Result * c.Result)).ToString();
        }

        private Task<double> silnia(double a) {
            double wynik = 1;
            Thread.Sleep(2000);
            for (double i = a; i > 1; i--) {
                wynik *= i;            
            }
            return Task.FromResult(wynik);
        
        }

        private void asynch(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int k = int.Parse(textBox2.Text);
            timer1.Start();
            Task wynik = Task.Run(() => obliczAsynch(n, k));  
        }

        async void obliczAsynch(int n, int k) {
            Task<double> a = silnia(n);
            Task<double> b = silnia(k);
            Task<double> c = silnia(n - k);
            double wynik = await a;
            wynik /= await b;
            wynik /= await c;
            odp3 = wynik.ToString();
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void liczFibbo(object sender, EventArgs e)
        {
            int a=int.Parse(textBox3.Text);
            backgroundWorker1.RunWorkerAsync(a);
            
        }
        private void pracaWorkera(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = obliczFibo((int)e.Argument, worker);
        }

        private long obliczFibo(int i, BackgroundWorker w)
        {
            long wynik = 1;
            long wczesniejszy = 0;
            long temp;
            for (int a = 1; a <= i; a++)
            {
                Thread.Sleep(20);
                temp = wynik;
                wynik += wczesniejszy;
                wczesniejszy = temp;
                w.ReportProgress((int)(100.0 * a / i));
            }
            return wynik;
        }

        private void zmiana(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void koniecWorkera(object sender, RunWorkerCompletedEventArgs e)
        {
            wynikFibbo.Text = e.Result.ToString();
        }
        

        private void kopresuj(object sender, EventArgs e)
        {
            FolderBrowserDialog okienko = new FolderBrowserDialog();
            var cos = okienko.ShowDialog();
            DirectoryInfo katalog = new DirectoryInfo(okienko.SelectedPath);
            foreach(FileInfo plik in katalog.GetFiles()) { 
                Task konw=Task.Run(()=>kompresujPlik(plik));
            }
        }

        private void kompresujPlik(FileInfo plik) {
            using (FileStream strumien = plik.OpenRead())
            {
                using (FileStream zkompresowany = File.Create(plik.FullName + ".gz"))
                {
                    using (GZipStream compressionStream = new GZipStream(zkompresowany,
                       CompressionMode.Compress))
                    {
                        strumien.CopyTo(compressionStream);

                    }
                }
            } 
        }

        private void dekompresuj(object sender, EventArgs e)
        {
            FolderBrowserDialog okienko = new FolderBrowserDialog();
            var cos = okienko.ShowDialog();
            DirectoryInfo katalog = new DirectoryInfo(okienko.SelectedPath);
            foreach (FileInfo plik in katalog.GetFiles().Where(piczek=>piczek.Extension==".gz"))
            {
                Task konw = Task.Run(() => dekompresujPlik(plik));
            }
        }
        private void dekompresujPlik(FileInfo plik) {
            using (FileStream strumien = plik.OpenRead())
            {
                string nazwaPliku = plik.FullName;
                string noweImie = nazwaPliku.Remove(nazwaPliku.Length - plik.Extension.Length);

                using (FileStream zkompresowanyStrumien = File.Create(noweImie))
                {
                    using (GZipStream decompressionStream = new GZipStream(strumien, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(zkompresowanyStrumien);
                        Console.WriteLine("Decompressed: {0}", plik.Name);
                    }
                }
            }
        
        
        
        
        }

        private void liczbylosowe(object sender, EventArgs e)
        {
            Random generator = new Random();
            double i = generator.Next();
            odpLiczbyLosowe.Text =i.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] hostNames = { "www.microsoft.com",
                                "www.apple.com", "www.google.com",
                                "www.ibm.com", "cisco.netacad.net",
                                "www.oracle.com", "www.nokia.com",
                                "www.hp.com", "www.dell.com",
                                "www.samsung.com", "www.toshiba.com",
                                "www.siemens.com", "www.amazon.com",
                                "www.sony.com", "www.canon.com", "www.alcatel-lucent.com", "www.acer.com", "www.motorola.com"};

            String napis="";
            Object blokada = new Object();
           
            hostNames.AsParallel<string>().ForAll(cos =>
            {
                lock (blokada)
                {
                    napis += cos + " => " + Dns.GetHostAddresses(cos)[0].ToString() + "\n";
                }
                
            });
            richTextBox1.Text = napis;


        }

        private void klik(object sender, EventArgs e)
        {
            odpTas.Text = odp1;
            odpDelegaty.Text = odp2;
            odpAsynch.Text = odp3;
        }  
        
    }
}

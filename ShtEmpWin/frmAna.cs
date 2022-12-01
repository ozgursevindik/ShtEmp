using ShtEmpWin.Sources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShtEmpWin
{
    public partial class frmAna : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        Thread _thread;
        public frmAna()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            t.Interval = 1000;
            t.Tick += T_Tick;
            t.Start();


            
            _thread = new Thread(new ThreadStart( SaveGame )); 
            _thread.Start();
        }

        public void SaveGame()
        {
            while (true)
            {
                for (int i = 0; i < 2000; i++)
                {
                    lblStatus.Text = i.ToString() + " Kb";
                    lblStatus.Refresh();
                }
                
                lblStatus.Text = "Saved: " + DateTime.Now.ToString();
                Thread.Sleep(2000);
            }
            
        }

        private void T_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void frmAna_Load(object sender, EventArgs e)
        { 
            Program.dukkan.oda_sayisi = 3;
            Program.dukkan.OdalariOlustur();     
        }

        private void Refresh()
        {
            

            panel1.BackColor = Color.Wheat;
            panel2.BackColor = Color.Wheat;
            panel3.BackColor = Color.Wheat;
            if (!Program.dukkan.odalar[0].oda_musaitlik)
                panel1.BackColor = Color.Orange;
            if (!Program.dukkan.odalar[1].oda_musaitlik)
                panel2.BackColor = Color.Orange;
            if (!Program.dukkan.odalar[2].oda_musaitlik)
                panel3.BackColor = Color.Orange;

            lblOda1Musaitlik.Text = "Müsait: " + Program.dukkan.odalar[0].oda_musaitlik.ToString();
            lblOda2Musaitlik.Text = "Müsait: " + Program.dukkan.odalar[1].oda_musaitlik.ToString();
            lblOda3Musaitlik.Text = "Müsait: " + Program.dukkan.odalar[2].oda_musaitlik.ToString();
            lblAnlikInsan.Text = "Insan Sayısı: " + Program.dukkan.anlik_insan_adedi.ToString();
            lblOda1AnlikNumune.Text = "An Num: " + Program.dukkan.odalar[0].anlik_numune_adedi.ToString();
            lblOda2AnlikNumune.Text = "An Num: " + Program.dukkan.odalar[1].anlik_numune_adedi.ToString();
            lblOda3AnlikNumune.Text = "An Num: " + Program.dukkan.odalar[2].anlik_numune_adedi.ToString();
            lblKasa.Text = "Kasa: " + Program.dukkan.Kasa.ToString() + " TL";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Insan insan = new Insan();
            insan.tip = Enums.enumInsanTipi.Cocuk;
            Program.dukkan.InsanGirdi(insan);

        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Program.dukkan.odalar[0].Temizle();
        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Program.dukkan.odalar[1].Temizle();
        }

        private void panel3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Program.dukkan.odalar[2].Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aloha");
        }

        private void frmAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _thread.Abort();                
            }
            catch
            {
            }
            Environment.Exit(Environment.ExitCode);

        }

        private void frmAna_FormClosed(object sender, FormClosedEventArgs e)
        {
             
        }
    }
}

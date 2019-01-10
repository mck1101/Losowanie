using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SprawdzDokument
{
    public partial class TesterAutentycznosci : Form
    {
        int x;
        Random random = new Random();
        public TesterAutentycznosci()
        {
            InitializeComponent();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = random.Next(0, 100);
            this.timer1.Start();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = random.Next(0, 100);
            this.timer2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = random.Next(0, 100);
            this.timer3.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = random.Next(0, 100);
            this.timer4.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = random.Next(0, 100);
            this.timer5.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = random.Next(0, 100);
            this.timer6.Start();
        }



        private void button7_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.timer2.Stop();
            this.timer3.Stop();
            this.timer4.Stop();
            this.timer5.Stop();
            this.timer6.Stop();
            wynik.Text = "";
            progressBar1.Value = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                this.timer1.Stop();
                if (x<=60) { wynik.Text = "Dokument AUTENTYCZNY"; } else { wynik.Text = "Dokument PODROBIONY"; }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.progressBar1.Increment(1);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                this.timer1.Stop();
                if (x <= 50) { wynik.Text = "Dokument AUTENTYCZNY"; } else { wynik.Text = "Dokument PODROBIONY"; }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                this.timer1.Stop();
                if (x <= 70) { wynik.Text = "Dokument AUTENTYCZNY"; } else { wynik.Text = "Dokument PODROBIONY"; }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                this.timer1.Stop();
                if (x <= 80) { wynik.Text = "Dokument AUTENTYCZNY"; } else { wynik.Text = "Dokument PODROBIONY"; }
            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                this.timer1.Stop();
                if (x <= 90) { wynik.Text = "Dokument AUTENTYCZNY"; } else { wynik.Text = "Dokument PODROBIONY"; }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                this.timer1.Stop();
                if (x <= 95) { wynik.Text = "Dokument AUTENTYCZNY"; } else { wynik.Text = "Dokument PODROBIONY"; }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

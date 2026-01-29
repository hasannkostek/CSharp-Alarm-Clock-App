using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Saati_Uygulaması
{
    public partial class Form1: Form
    {
        int saat = 0;
        int dakika = 0;
        int saniye = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBasla_Click(object sender, EventArgs e)
        {
            saat = (int)numericUpDownSaat.Value;
            dakika = (int)numericUpDownDakika.Value;
            saniye = (int)numericUpDownSaniye.Value;
            timerZaman.Start();
        }

        private void timerZaman_Tick(object sender, EventArgs e)
        {
            
            if(saniye ==0 && dakika ==0)
            {
                if(saat > 0)
                {
                    saat--;
                    dakika = 59;
                    saniye = 59;
                }
            }
            if (saniye == 0)
            {
                if(dakika > 0)
                {
                    dakika--;
                    saniye = 59;
                }
            }
            labelZaman.Text = string.Format("{0:00}:{1:00}:{2:00}",saat,dakika,saniye);

            if(saat==0 && dakika==0 && saniye == 0)
            {
                timerZaman.Stop();
                MessageBox.Show("Alarm Bitti!");
            }
            saniye--;
        }

        private void buttonDurdur_Click(object sender, EventArgs e)
        {
            timerZaman.Stop();
            saat = 0;
            dakika = 0;
            saniye = 0;
            labelZaman.Text = string.Format("{0:00}:{1:00}:{2:00}", saat, dakika, saniye);
        }
    }
}

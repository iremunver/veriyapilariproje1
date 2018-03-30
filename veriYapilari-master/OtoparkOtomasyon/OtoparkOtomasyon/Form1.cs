using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class Form1 : Form
    {
        Otopark o = new Otopark(15);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Araba a = new Araba(o.SureHesapla());
            a.Plaka = txtPlaka.Text;
            o.Ekle(a);
            lBoxListele.Items.Clear();
            lBoxListele.Items.Add(o.Listele());
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            o.Cikar();
            lBoxListele.Items.RemoveAt(0);
            lBoxListele.Items.Clear();
            lBoxListele.Items.Add(o.Listele());
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lBoxListele.Items.Clear();
            lBoxListele.Items.Add(o.Listele());
        }

        private void btnOncelik_Click(object sender, EventArgs e)
        {
            o.OncelikliCikar();
            lBoxListele.Items.Clear();
            lBoxListele.Items.Add(o.Listele());
        }       
    }
}

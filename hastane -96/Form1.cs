using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane__96
{
    public partial class Form1 : Form
    {
        Hasta hasta = new Hasta();
        int sayac = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            sayac++;
            lbBilgiler.Items.Add(sayac + " .HASTA");

            hasta.ad = txtAd.Text;
            lbBilgiler.Items.Add(hasta.ad);

            hasta.soyad = txtSoyad.Text;
            lbBilgiler.Items.Add(hasta.soyad);

            hasta.tel = txtTel.Text;
            lbBilgiler.Items.Add(hasta.tel);

            hasta.tc = txtTc.Text;
            lbBilgiler.Items.Add(hasta.tc);

            if (rbHastalikVar.Checked)
            {
                hasta.kronikHastalik = true;
            }
            else
            {
                hasta.kronikHastalik = false;
            }
            lbBilgiler.Items.Add(hasta.kronikHastalik);

            hasta.kanGrup = cmbKan.Text;
            lbBilgiler.Items.Add(hasta.kanGrup);

            hasta.dtarih = dtpTarih.Value;
            lbBilgiler.Items.Add(hasta.dtarih);

            txtAd.Clear();
            txtSoyad.Clear();
            txtTc.Clear();
            txtTel.Clear();
            cmbKan.Update();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            hasta.ad = "Hilal";
            hasta.soyad = "De Souza";
            hasta.tel = "12345678901";
            hasta.kronikHastalik = false;
            hasta.kanGrup = "0Rh+";
            hasta.dtarih = new DateTime(2007, 12, 01);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BİLGİLERİNİZ KAYDEDİLMİŞTİR");
        }
    }
}       

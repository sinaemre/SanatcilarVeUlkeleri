using SanatciVeUlkeleri2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanatciVeUlkeleri2
{
    public partial class Form1 : Form
    {
        UygulamaDbContext db = new UygulamaDbContext();
        public Form1()
        {
            InitializeComponent();
            UlkeleriListele();
        }

        private void UlkeleriListele()
        {
            cmbSanatcininUlkesi.DataSource = db.Ulkeler.ToList();
            cmbSanatcininUlkesi.DisplayMember = "Ad";
            cmbSanatcininUlkesi.ValueMember = "Id";
            cmbUlke.DataSource = db.Ulkeler.ToList();
            cmbUlke.DisplayMember = "Ad";

            cmbUlke.SelectedIndex = -1;
        }

        private void cmbUlke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUlke.SelectedIndex == -1)
            {
                lstSanatcilar.DataSource = null;
                return;
            }
            Ulke ulke = (Ulke)cmbUlke.SelectedItem;
            lstSanatcilar.DataSource = ulke.Sanatcilar.ToList();
            lstSanatcilar.DisplayMember = "Ad";
            lstSanatcilar.ValueMember = "Id";
        }

        private void btnUlkeEkle_Click(object sender, EventArgs e)
        {
            string ulkeAd = txtUlkeAd.Text;
            if (ulkeAd == "") return;

            db.Ulkeler.Add(new Ulke() { Ad = ulkeAd });
            db.SaveChanges();
            txtUlkeAd.Clear();
            UlkeleriListele();
        }

        private void btnSanatciEkle_Click(object sender, EventArgs e)
        {
            Ulke ulke = (Ulke)cmbSanatcininUlkesi.SelectedItem;
            string sanatciAd = txtSanatciAdı.Text.Trim();

            if (sanatciAd == "" || ulke == null) return;

            Sanatci sanatci = new Sanatci()
            {
                Ad = sanatciAd,
                Ulke = ulke
            };

            db.Sanatcilar.Add(sanatci);
            db.SaveChanges();
            txtSanatciAdı.Clear();
            UlkeleriListele();
        }

        private void btnUlkeSil_Click(object sender, EventArgs e)
        {
            Ulke ulke = (Ulke)cmbUlke.SelectedItem;
            if (ulke == null) return;

            db.Ulkeler.Remove(ulke);
            db.SaveChanges();
            UlkeleriListele();
        }

    }
}

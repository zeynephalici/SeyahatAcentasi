using SeyahatAcentasi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyahatAcentasi
{
    public partial class Sefer : Form
    {
        public Sefer()
        {
            InitializeComponent();
        }

        //Global degiskenler:
        private string _hataMesaji;
        public Models.Personel _personelClass;
        public Structs.Personel _personelStruct;

        //Form ici fonksiyonlar:
        private void yeni()
        {
            lblId.Text = "";
            txtAciklama.Text = "";
            txtKalkisYeri.Text = "";
            txtVarisYeri.Text = "";
            dtpKalkisTarihSaati.Value= DateTime.Now;

            txtAciklama.Focus();
        }

        private void kaydet()
        {
            Models.Sefer _sefer = new Models.Sefer();
            _sefer.aciklama = txtAciklama.Text;
            _sefer.kalkisyeri = txtKalkisYeri.Text;
            _sefer.varisyeri = txtVarisYeri.Text;
            _sefer.kalkistarihsaati = dtpKalkisTarihSaati.Value;

            _hataMesaji = "";

            if (lblId.Text == "") //ekle
            {
                bool sonuc = _sefer.ekle(ref _hataMesaji);

                if (sonuc == false || (_hataMesaji != null && _hataMesaji != ""))
                {
                    mesajVer(_hataMesaji);
                }
                else
                {
                    yenileGrid();
                }
            }
            else //guncelle
            {
                _sefer.id = int.Parse(lblId.Text);

                bool sonuc = _sefer.guncelle(ref _hataMesaji);

                if (sonuc == false || (_hataMesaji != null && _hataMesaji != ""))
                {
                    mesajVer(_hataMesaji);
                }
                else
                {
                    yenileGrid();
                }
            }
        }

        private void sil()
        {
            Models.Sefer _sefer = new Models.Sefer();
            _hataMesaji = "";

            if (lblId.Text == "")
            {
                _hataMesaji = "Silinecek kayıt bulunamadı!";
                mesajVer(_hataMesaji);
            }
            else
            {
                DialogResult _dr = MessageBox.Show(lblId.Text + " numaralı kayıt silinecek. Devam edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dr.ToString() == "Yes")
                {
                    _sefer.id = int.Parse(lblId.Text);

                    bool sonuc = _sefer.sil(ref _hataMesaji);

                    if (sonuc == false || (_hataMesaji != null && _hataMesaji != ""))
                    {
                        mesajVer(_hataMesaji);
                    }
                    else
                    {
                        yenileGrid();
                    }
                }
            }
        }

        private void yenileGrid()
        {
            Models.Sefer _sefer = new Models.Sefer();
            _hataMesaji = "";
            dataGridView1.DataSource = _sefer.listele(tsTxtAra.Text, ref _hataMesaji);
            if (dataGridView1.Rows.Count > 0)
            {
                yenileForm(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                lblId.Text = "";
                txtAciklama.Text = "";
                txtKalkisYeri.Text = "";
                txtVarisYeri.Text = "";
                dtpKalkisTarihSaati.Value = DateTime.Now;
            }

            if (_hataMesaji != null && _hataMesaji != "")
            {
                mesajVer(_hataMesaji);
            }
        }

        private void yenileForm(int seciliRowIndex)
        {
            Models.Sefer _sefer = new Models.Sefer();
            _sefer.id = int.Parse(dataGridView1.Rows[seciliRowIndex].Cells["id"].Value.ToString());
            
            _hataMesaji = "";
            _sefer.ara(ref _hataMesaji);

            if (_hataMesaji == "")
            {
                lblId.Text = _sefer.id.ToString();
                txtAciklama.Text = _sefer.aciklama;
                txtKalkisYeri.Text = _sefer.kalkisyeri;
                txtVarisYeri.Text = _sefer.varisyeri;
                dtpKalkisTarihSaati.Value = _sefer.kalkistarihsaati;
            }
            else
            {
                lblId.Text = "";
                txtAciklama.Text = "";
                txtKalkisYeri.Text = "";
                txtVarisYeri.Text = "";
                dtpKalkisTarihSaati.Value = DateTime.Now;

                mesajVer(_hataMesaji);
            }
        }

        private void mesajVer(string _hataMesaji)
        {
            MessageBox.Show(_hataMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Form olaylari
        private void Kullanici_Load(object sender, EventArgs e)
        {
            yenileGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            yenileForm(e.RowIndex);
        }

        private void tsbYeni_Click(object sender, EventArgs e)
        {
            yeni();
        }

        private void tsbKaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void tsbYenile_Click(object sender, EventArgs e)
        {
            yenileGrid();
        }

        private void tsbSil_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void tsbAra_Click(object sender, EventArgs e)
        {
            yenileGrid();
        }
    }
}

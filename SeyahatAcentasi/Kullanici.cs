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
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }

        //Global degiskenler:
        private string _hataMesaji;

        //Form ici fonksiyonlar:
        private void yeni()
        {
            lblId.Text = "";
            txtAdi.Text = "";
            txtSoyadi.Text = "";

            txtAdi.Focus();
        }

        private void kaydet()
        {
            Personel _personel = new Personel();
            _personel.adi = txtAdi.Text;
            _personel.soyadi = txtSoyadi.Text;
            _hataMesaji = "";

            if (lblId.Text == "") //ekle
            {
                bool sonuc = _personel.ekle(ref _hataMesaji);

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
                _personel.id = int.Parse(lblId.Text);

                bool sonuc = _personel.guncelle(ref _hataMesaji);

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
            Personel _personel = new Personel();
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
                    _personel.id = int.Parse(lblId.Text);

                    bool sonuc = _personel.sil(ref _hataMesaji);

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
            Personel _personel = new Personel();
            _hataMesaji = "";
            dataGridView1.DataSource = _personel.listele(tsTxtAra.Text, ref _hataMesaji);
            if (dataGridView1.Rows.Count > 0)
            {
                yenileForm(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                lblId.Text = "";
                txtAdi.Text = "";
                txtSoyadi.Text = "";
            }

            if (_hataMesaji != null && _hataMesaji != "")
            {
                mesajVer(_hataMesaji);
            }
        }

        private void yenileForm(int seciliRowIndex)
        {
            Personel _personel = new Personel();
            _personel.id = int.Parse(dataGridView1.Rows[seciliRowIndex].Cells["id"].Value.ToString());
            _hataMesaji = "";
            _personel.kullaniciAdi = "";
            _personel.sifresi = "";

            _personel.ara(ref _hataMesaji);

            if (_hataMesaji == "")
            {
                lblId.Text = _personel.id.ToString();
                txtAdi.Text = _personel.adi;
                txtSoyadi.Text = _personel.soyadi;
                pictureBox1.ImageLocation = _personel.profilResimYolu;
            }
            else
            {
                lblId.Text = "";
                txtAdi.Text = "";
                txtSoyadi.Text = "";
                pictureBox1.ImageLocation = "";

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

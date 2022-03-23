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
    public partial class Bilet : Form
    {
        public Bilet()
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
            cbSefer.SelectedIndex = -1; //secili item kaldiriliyor
            txtKoltukNo.Text = "";
            lblBiletSatisTarihSaati.Text = "";
            txtSeriNo.Text = "";
            txtYolcuAdi.Text = "";
            txtYolcuSoyadi.Text = "";

            cbSefer.Focus(); //kontrole yonlendiriliyor
        }

        private void kaydet()
        {
            Models.Bilet _bilet = new Models.Bilet();
            _bilet.sefer_id = int.Parse(cbSefer.SelectedValue.ToString());
            _bilet.koltukno = int.Parse(txtKoltukNo.Text);
            _bilet.biletsatistarihsaati = DateTime.Now;
            _bilet.serino = txtSeriNo.Text;
            _bilet.yolcuadi = txtYolcuAdi.Text;
            _bilet.yolcusoyadi = txtYolcuSoyadi.Text;

            _hataMesaji = "";

            _bilet.id = int.Parse(lblId.Text);

            bool sonuc = _bilet.guncelle(ref _hataMesaji);

            if (sonuc == false || (_hataMesaji != null && _hataMesaji != ""))
            {
                mesajVer(_hataMesaji);
            }
            else
            {
                yenileGrid();
            }
            //if (lblId.Text == "") //ekle
            //{
            //    bool sonuc = _bilet.ekle(ref _hataMesaji);

            //    if (sonuc == false || (_hataMesaji != null && _hataMesaji != ""))
            //    {
            //        mesajVer(_hataMesaji);
            //    }
            //    else
            //    {
            //        yenileGrid();
            //    }
            //}
            //else //guncelle
            //{
            //    _bilet.id = int.Parse(lblId.Text);

            //    bool sonuc = _bilet.guncelle(ref _hataMesaji);

            //    if (sonuc == false || (_hataMesaji != null && _hataMesaji != ""))
            //    {
            //        mesajVer(_hataMesaji);
            //    }
            //    else
            //    {
            //        yenileGrid();
            //    }
            //}
        }

        private void sil()
        {
            Models.Bilet _bilet = new Models.Bilet();
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
                    _bilet.id = int.Parse(lblId.Text);

                    bool sonuc = _bilet.sil(ref _hataMesaji);

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
            Models.Bilet _bilet = new Models.Bilet();
            _hataMesaji = "";
            int seciliSeferValue = 0;
            if (cbSeferGrid.SelectedIndex >= 0)
            {
                seciliSeferValue = int.Parse(cbSeferGrid.SelectedValue.ToString());
            }
            dataGridView1.DataSource = _bilet.listele(tsTxtAra.Text, seciliSeferValue, ref _hataMesaji);
            if (dataGridView1.Rows.Count > 0)
            {
                yenileForm(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                lblId.Text = "";
                cbSefer.SelectedIndex = -1;
                txtKoltukNo.Text = "";
                lblBiletSatisTarihSaati.Text = "";
                txtSeriNo.Text = "";
                txtYolcuAdi.Text = "";
                txtYolcuSoyadi.Text = "";
            }

            if (_hataMesaji != null && _hataMesaji != "")
            {
                mesajVer(_hataMesaji);
            }
        }

        private void yenileForm(int seciliRowIndex)
        {
            Models.Bilet _bilet = new Models.Bilet();
            _bilet.id = int.Parse(dataGridView1.Rows[seciliRowIndex].Cells["id"].Value.ToString());

            _hataMesaji = "";
            _bilet.ara(ref _hataMesaji);

            if (_hataMesaji == "")
            {
                lblId.Text = _bilet.id.ToString();
                cbSefer.SelectedValue = _bilet.sefer_id;
                txtKoltukNo.Text = _bilet.koltukno.ToString();
                lblBiletSatisTarihSaati.Text = _bilet.biletsatistarihsaati.ToString();
                txtSeriNo.Text = _bilet.serino;
                txtYolcuAdi.Text = _bilet.yolcuadi;
                txtYolcuSoyadi.Text = _bilet.yolcusoyadi;
            }
            else
            {
                lblId.Text = "";
                cbSefer.SelectedIndex = -1;
                txtKoltukNo.Text = "";
                lblBiletSatisTarihSaati.Text = "";
                txtSeriNo.Text = "";
                txtYolcuAdi.Text = "";
                txtYolcuSoyadi.Text = "";

                mesajVer(_hataMesaji);
            }
        }

        private void yenileSefer(ref ComboBox _cb)
        {
            Models.Sefer _sefer = new Models.Sefer();
            DataTable dtSefer = _sefer.listele("", ref _hataMesaji);
            _cb.ValueMember = "id";
            _cb.DisplayMember = "aciklama";
            _cb.DataSource = dtSefer;
            _cb.SelectedIndex = -1;
        }

        private void mesajVer(string _hataMesaji)
        {
            MessageBox.Show(_hataMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Form olaylari
        private void Kullanici_Load(object sender, EventArgs e)
        {
            yenileSefer(ref cbSeferGrid);
            yenileSefer(ref cbSefer);

            yenileGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            yenileForm(e.RowIndex);
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

        private void cbSeferGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //yenileGrid();
            tsbYenile_Click(null, null);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyahatAcentasi
{
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }

        //Global degiskenler:
        private string _hataMesaji;
        public Models.Personel _personelClass;
        public Structs.Personel _personelStruct;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "") //kullani adi kontrolu
            {
                if (textBox1.Text == _personelClass.sifresi) //eski sifre kontrolu
                {
                    if (textBox2.Text == textBox3.Text) //yeni sifre ve tekrari kontrolu
                    {
                        if (textBox2.Text.Length >= 3) //sifre belirleme kriteri (tek kriter)
                        {
                            _personelClass.kullaniciAdi = textBox4.Text;
                            _personelClass.sifresi = textBox2.Text;
                            _personelStruct.kullaniciAdi = _personelClass.kullaniciAdi;
                            _personelStruct.sifresi = _personelClass.sifresi;

                            _hataMesaji = "";
                            bool sonuc = _personelClass.sifreDegistir(ref _hataMesaji);

                            if (sonuc == false || _hataMesaji != "")
                            {
                                MessageBox.Show("Şifre değiştiriemedi, bir hata oluştu (" + _hataMesaji + ")!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Şifre en az 3 karakter olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yeni şifre ve tekrarı tutarlı olmalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Eski şifre hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            textBox4.Text = _personelClass.kullaniciAdi;
        }

      
    }
}

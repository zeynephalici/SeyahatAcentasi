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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel _personel = new Personel(textBox1.Text, textBox2.Text);
            string _hataMesaji = "";
            _personel.ara(ref _hataMesaji);
            if (_personel.id > 0)
            {
                Structs.Personel _sPersonel = new Structs.Personel();
                _sPersonel.id = _personel.id;
                _sPersonel.kullaniciAdi = textBox1.Text;
                _sPersonel.sifresi= textBox2.Text;

                Anasayfa _anasayfa = new Anasayfa();
                _anasayfa._personelClass = _personel;
                _anasayfa._personelStruct = _sPersonel;
                _anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(_hataMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

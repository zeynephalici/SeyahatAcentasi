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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        //Global degiskenler:
        public Models.Personel _personelClass;
        public Structs.Personel _personelStruct;

        private void tsmiKullanici_Click(object sender, EventArgs e)
        {
            Kullanici _frmKullanici = new Kullanici();
            _frmKullanici.MdiParent= this;
            _frmKullanici.Show();
        }

        private void tsmiOturumuSonlandir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiSifreDegistir_Click(object sender, EventArgs e)
        {
            SifreDegistir _frmSifreDegistir = new SifreDegistir();
            _frmSifreDegistir._personelClass= _personelClass;
            _frmSifreDegistir._personelStruct= _personelStruct;
            _frmSifreDegistir.MdiParent= this;
            _frmSifreDegistir.Show();
        }

        private void tsmiSefer_Click(object sender, EventArgs e)
        {
            Sefer _frmSefer = new Sefer();
            _frmSefer._personelClass = _personelClass;
            _frmSefer._personelStruct = _personelStruct;
            _frmSefer.MdiParent = this;
            _frmSefer.Show();
        }

        private void tsmiBilet_Click(object sender, EventArgs e)
        {
            Bilet _frmBilet = new Bilet();
            _frmBilet._personelClass = _personelClass;
            _frmBilet._personelStruct = _personelStruct;
            _frmBilet.MdiParent = this;
            _frmBilet.Show();
        }

        private void tsmiSeferRapor_Click(object sender, EventArgs e)
        {
            SeferRapor _seferrapor= new SeferRapor();
           //_seferrapor._personelClass = _personelClass;
           //_seferrapor._personelStruct = _personelStruct;
            _seferrapor.MdiParent = this;
            _seferrapor.Show();
        }

        private void tsmiBiletRapor_Click(object sender, EventArgs e)
        {
            BiletRapor _biletRapor = new BiletRapor();
            _biletRapor.MdiParent = this;
            _biletRapor.Show();
        }
    }
}

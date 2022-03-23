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
    public partial class BiletRapor : Form
    {
        public BiletRapor()
        {
            InitializeComponent();
        }

        private void BiletRapor_Load(object sender, EventArgs e)
        {
            string _hataMesaji = "";
            Models.Sefer _sefer = new Models.Sefer();    
            DataTable dtSefer=_sefer.listele("",ref _hataMesaji);
            cbSefer.ValueMember = "id";
            cbSefer.DisplayMember = "aciklama";
            cbSefer.DataSource = dtSefer;   
                
        }

        private void cbSefer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.Rapor _rapor=new Models.Rapor();
            _rapor.BiletRaporuGetir(int.Parse(cbSefer.SelectedValue.ToString()));
            dataGridView1.DataSource = _rapor.DTRaporVerisi;
        }
    }
}

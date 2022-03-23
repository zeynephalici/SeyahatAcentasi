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
    public partial class SeferRapor : Form
    {
        public SeferRapor()
        {
            InitializeComponent();
        }

        private void SeferRapor_Load(object sender, EventArgs e)
        {
            Rapor rpr = new Rapor();
            rpr.SeferRaporuGetir();
            dataGridView1.DataSource = rpr.DTRaporVerisi;
        }
    }
}

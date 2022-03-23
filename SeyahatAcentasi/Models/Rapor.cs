using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyahatAcentasi.Models
{
    public class Rapor
    {
        public DataTable DTRaporVerisi { get; set; }

        public void SeferRaporuGetir()
        {
            string _hataMesaji = "";
            Execute _execute = new Execute();
            SQL.Rapor _sql = new SQL.Rapor();
            DTRaporVerisi = _execute.executeDT( _sql.SeferRaporu() , null, false, ref _hataMesaji);

        }

        public void BiletRaporuGetir(int _seferId)
        {
            string _hataMesaji = "";
            Execute _execute = new Execute();
            SQL.Rapor _sql = new SQL.Rapor();
            List<SqlParameter> _params=new List<SqlParameter>();
            _params.Add(new SqlParameter("@sefer_id", _seferId));
            DTRaporVerisi = _execute.executeDT(_sql.BiletRaporu(), _params.ToArray(), false, ref _hataMesaji);
        }
    }
}

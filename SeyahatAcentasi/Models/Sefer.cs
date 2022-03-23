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
    public class Sefer
    {
        //Properties:
        public int id { get; set; }
        public string aciklama { get; set; }
        public string kalkisyeri { get; set; }
        public string varisyeri { get; set; }
        public DateTime kalkistarihsaati { get; set; }

        //Global values:
        private Execute _execute = new Execute();
        private SQL.Sefer _sql = new SQL.Sefer();
        private List<SqlParameter> _params = new List<SqlParameter>();

        //Actions:
        public bool ekle(ref string _hataMesaji)
        {
            bool result = true;

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@aciklama", aciklama));
            _params.Add(new SqlParameter("@kalkisyeri", kalkisyeri));
            _params.Add(new SqlParameter("@varisyeri", varisyeri));
            _params.Add(new SqlParameter("@kalkistarihsaati", kalkistarihsaati));

            //database
            _hataMesaji = "";
            result = _execute.execute(_sql.ekle(), _params.ToArray(), false, ref _hataMesaji);

            //return
            return result;
        }

        public bool guncelle(ref string _hataMesaji)
        {
            bool result = true;

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@aciklama", aciklama));
            _params.Add(new SqlParameter("@kalkisyeri", kalkisyeri));
            _params.Add(new SqlParameter("@varisyeri", varisyeri));
            _params.Add(new SqlParameter("@kalkistarihsaati", kalkistarihsaati));
            _params.Add(new SqlParameter("@id", id));

            //database
            _hataMesaji = "";
            result = _execute.execute(_sql.guncelle(), _params.ToArray(), false, ref _hataMesaji);

            //return
            return result;
        }

        public bool sil(ref string _hataMesaji)
        {
            bool result = true;

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@id", id));

            //database
            _hataMesaji = "";
            result = _execute.execute(_sql.sil(), _params.ToArray(), false, ref _hataMesaji);

            //return
            return result;
        }

        /// <summary>
        /// Tek kayıt dönecek şekilde kurgulanmıştır.
        /// </summary>
        /// <param name="_hataMesaji"></param>
        public void ara(ref string _hataMesaji)
        {
            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@id", id));

            //database
            _hataMesaji = "";
            DataTable dtSefer = _execute.executeDT(_sql.ara(), _params.ToArray(), false, ref _hataMesaji);

            //class map
            if (_hataMesaji == "" && dtSefer != null && dtSefer.Rows.Count > 0)
            {
                id = int.Parse(dtSefer.Rows[0]["id"].ToString());
                aciklama = dtSefer.Rows[0]["aciklama"].ToString();
                kalkisyeri = dtSefer.Rows[0]["kalkisyeri"].ToString();
                varisyeri = dtSefer.Rows[0]["varisyeri"].ToString();
                kalkistarihsaati = DateTime.Parse(dtSefer.Rows[0]["kalkistarihsaati"].ToString());
            }
            else
            {
                _hataMesaji = "Kullanıcı bilgisi alınamadı!";

                id = 0;
                aciklama = "";
                kalkisyeri = "";
                varisyeri = "";
                kalkistarihsaati = DateTime.Now;
            }
        }

        /// <summary>
        /// Tüm kullanıcıları getirir.
        /// </summary>
        /// <param name="_hataMesaji"></param>
        public DataTable listele(string aramaDegeri, ref string _hataMesaji)
        {
            DataTable dtResult = new DataTable();

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@aramaDegeri", aramaDegeri));

            //database
            _hataMesaji = "";
            dtResult = _execute.executeDT(((aramaDegeri == null || aramaDegeri == "") ? _sql.listele() : _sql.listele_aramaDegeri()), _params.ToArray(), false, ref _hataMesaji);

            //class map
            if (_hataMesaji != "")
            {
                dtResult = null;
            }

            //return
            return dtResult;
        }
    }
}

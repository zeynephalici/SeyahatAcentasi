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
    public class Bilet
    {
        //Properties:
        public int id { get; set; }
        public int sefer_id { get; set; }
        public int koltukno { get; set; }
        public DateTime biletsatistarihsaati { get; set; }
        public string serino { get; set; }
        public string yolcuadi { get; set; }
        public string yolcusoyadi { get; set; }

        //Global values:
        private Execute _execute = new Execute();
        private SQL.Bilet _sql = new SQL.Bilet();
        private List<SqlParameter> _params = new List<SqlParameter>();

        //Actions:
        //public bool ekle(ref string _hataMesaji)
        //{
        //    bool result = true;

        //    //Parameters:
        //    _params.Clear();
        //    _params.Add(new SqlParameter("@sefer_id", sefer_id));
        //    _params.Add(new SqlParameter("@koltukno", koltukno));
        //    _params.Add(new SqlParameter("@biletsatistarihsaati", biletsatistarihsaati));
        //    _params.Add(new SqlParameter("@serino", serino));
        //    _params.Add(new SqlParameter("@yolcuadi", yolcuadi));
        //    _params.Add(new SqlParameter("@yolcusoyadi", yolcusoyadi));

        //    //database
        //    _hataMesaji = "";
        //    result = _execute.execute(_sql.ekle(), _params.ToArray(), false, ref _hataMesaji);

        //    //return
        //    return result;
        //}

        public bool guncelle(ref string _hataMesaji)
        {
            bool result = true;

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@sefer_id", sefer_id));
            _params.Add(new SqlParameter("@koltukno", koltukno));
            _params.Add(new SqlParameter("@biletsatistarihsaati", biletsatistarihsaati));
            _params.Add(new SqlParameter("@serino", serino));
            _params.Add(new SqlParameter("@yolcuadi", yolcuadi));
            _params.Add(new SqlParameter("@yolcusoyadi", yolcusoyadi));
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
            DataTable dtBilet = _execute.executeDT(_sql.ara(), _params.ToArray(), false, ref _hataMesaji);

            //class map
            if (_hataMesaji == "" && dtBilet != null && dtBilet.Rows.Count > 0)
            {
                id = int.Parse(dtBilet.Rows[0]["id"].ToString());
                sefer_id = int.Parse(dtBilet.Rows[0]["sefer_id"].ToString());
                koltukno = int.Parse(dtBilet.Rows[0]["koltukno"].ToString());
                try
                {
                    biletsatistarihsaati = DateTime.Parse(dtBilet.Rows[0]["biletsatistarihsaati"].ToString());
                }
                catch
                {
                    biletsatistarihsaati = DateTime.MinValue;
                }
                serino = dtBilet.Rows[0]["serino"].ToString();
                yolcuadi = dtBilet.Rows[0]["yolcuadi"].ToString();
                yolcusoyadi = dtBilet.Rows[0]["yolcusoyadi"].ToString();
            }
            else
            {
                _hataMesaji = "Kullanıcı bilgisi alınamadı!";

                id = 0;
                sefer_id = 0;
                koltukno = 0;
                biletsatistarihsaati = DateTime.Now;
                serino = "";
                yolcuadi = "";
                yolcusoyadi = "";
            }
        }

        /// <summary>
        /// Tüm kullanıcıları getirir.
        /// </summary>
        /// <param name="_hataMesaji"></param>
        public DataTable listele(string _aramaDegeri, int _sefer_id, ref string _hataMesaji)
        {
            DataTable dtResult = new DataTable();

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@aramaDegeri", _aramaDegeri));
            _params.Add(new SqlParameter("@sefer_id", _sefer_id));

            //database
            _hataMesaji = "";
            dtResult = _execute.executeDT((((_aramaDegeri == null || _aramaDegeri == "") && (_sefer_id <= 0)) ? _sql.listele() : _sql.listele_aramaDegeri()), _params.ToArray(), false, ref _hataMesaji);

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

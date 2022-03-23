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
    public class Personel
    {
        //Properties:
        public int id { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifresi { get; set; }

        public string profilResimYolu { get; set; }

        //Constructors:
        public Personel()
        {
            id = 0;
            adi = null;
            soyadi = null;
            kullaniciAdi= null;
            sifresi = null;
        }

        public Personel(string _kullaniciAdi, string _sifresi)
        {
            kullaniciAdi = _kullaniciAdi;
            sifresi = _sifresi;
        }

        //Global values:
        private Execute _execute = new Execute();
        private SQL.Personel _sql = new SQL.Personel();
        private List<SqlParameter> _params = new List<SqlParameter>();

        //Actions:
        public bool ekle(ref string _hataMesaji)
        {
            bool result = true;

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@adi", adi));
            _params.Add(new SqlParameter("@soyadi", soyadi));

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
            _params.Add(new SqlParameter("@adi", adi));
            _params.Add(new SqlParameter("@soyadi", soyadi));
            _params.Add(new SqlParameter("@profilResimYolu", profilResimYolu));
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
            _params.Add(new SqlParameter("@kullaniciAdi", kullaniciAdi));
            _params.Add(new SqlParameter("@sifresi", sifresi));
            _params.Add(new SqlParameter("@id", id));

            //database
            _hataMesaji = "";
            DataTable dtPersonel = _execute.executeDT(_sql.ara(), _params.ToArray(), false, ref _hataMesaji);

            //class map
            if (_hataMesaji == "" && dtPersonel != null && dtPersonel.Rows.Count > 0)
            {
                id = int.Parse(dtPersonel.Rows[0]["id"].ToString());
                adi = dtPersonel.Rows[0]["adi"].ToString();
                soyadi = dtPersonel.Rows[0]["soyadi"].ToString();
                profilResimYolu= dtPersonel.Rows[0]["profilResimYolu"].ToString();
            }
            else
            {
                _hataMesaji = "Kullanıcı bilgisi alınamadı!";

                id = 0;
                adi = "";
                soyadi = "";
                profilResimYolu = "";
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

        public bool sifreDegistir(ref string _hataMesaji)
        {
            bool result = true;

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@kullaniciAdi", kullaniciAdi));
            _params.Add(new SqlParameter("@sifresi", sifresi));
            _params.Add(new SqlParameter("@id", id));

            //database
            _hataMesaji = "";
            result = _execute.execute(_sql.sifreDegistir(), _params.ToArray(), false, ref _hataMesaji);

            //return
            return result;
        }
    }
}

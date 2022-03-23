using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class Rapor
    {
        public string SeferRaporu()
        {
            return "select s.id, s.aciklama, s.kalkisyeri, s.varisyeri, s.kalkistarihsaati, count(b.id) as KoltukSayisi,sum(case when b.biletsatistarihsaati is not null then 1 else 0 end ) as SatilanKoltukSayisi, sum(case when b.biletsatistarihsaati is null then 1 else 0 end ) as BosKoltukSayisi from SEFER as s inner join BILET as b on s.id = b.sefer_id group by s.id, s.aciklama, s.kalkisyeri, s.varisyeri, s.kalkistarihsaati order by s.kalkistarihsaati desc";
        }

        public string BiletRaporu()
        {
            return "select b.id,b.sefer_id,s.aciklama,b.koltukno,b.biletsatistarihsaati,b.serino,b.yolcuadi,b.yolcusoyadi from BILET b inner join SEFER s on s.id = b.sefer_id where b.sefer_id = @sefer_id order by b.koltukno asc";
        }
    }
}

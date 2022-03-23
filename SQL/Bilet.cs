using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class Bilet
    {
        public string ara()
        {
            return "select * from BILET where id = @id;";
        }

        public string listele()
        {
            return "select * from BILET order by biletsatistarihsaati desc;";
        }

        public string listele_aramaDegeri()
        {
            return "select * from BILET where sefer_id = (case when @sefer_id <= 0 then sefer_id else @sefer_id end) and (cast(id as nvarchar(max)) like '%' + @aramaDegeri + '%' or cast(sefer_id as nvarchar(max)) like '%' + @aramaDegeri + '%' or cast(koltukno as nvarchar(max)) like '%' + @aramaDegeri + '%' or cast(biletsatistarihsaati as nvarchar(max)) like '%' + @aramaDegeri + '%' or serino like '%' + @aramaDegeri + '%' or yolcuadi like '%' + @aramaDegeri + '%' or yolcusoyadi like '%' + @aramaDegeri + '%') order by biletsatistarihsaati desc;";
        }

        public string ekle()
        {
            return "insert into BILET (sefer_id, koltukno) values (@sefer_id, @koltukno);";
        }

        public string guncelle()
        {
            return "update BILET set biletsatistarihsaati = @biletsatistarihsaati, serino = @serino, yolcuadi = @yolcuadi, yolcusoyadi = @yolcusoyadi where id = @id;";
        }

        public string sil()
        {
            return "update BILET set biletsatistarihsaati=null, serino=null, yolcuadi=null, yolcusoyadi=null where id = @id";
        }
    }
}

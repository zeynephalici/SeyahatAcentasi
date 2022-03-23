using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class Sefer
    {
        public string ara()
        {
            return "select * from SEFER where id = @id;";
        }

        public string listele()
        {
            return "select * from SEFER order by kalkistarihsaati asc;";
        }

        public string listele_aramaDegeri()
        {
            return "select * from SEFER where cast(id as nvarchar(max)) like '%' + @aramaDegeri + '%' or aciklama like '%' + @aramaDegeri + '%' or kalkisyeri like '%' + @aramaDegeri + '%' or varisyeri like '%' + @aramaDegeri + '%' or kalkistarihsaati like '%' + @aramaDegeri + '%' order by kalkistarihsaati asc;";
        }

        public string ekle()
        {
            string _sql = "";
            _sql += "declare @sefer_id as int = 0;\n";

            _sql += "insert into SEFER\n";
            _sql += "(aciklama, kalkisyeri, varisyeri, kalkistarihsaati)\n";
            _sql += "values\n";
            _sql += "(@aciklama, @kalkisyeri, @varisyeri, @kalkistarihsaati);\n";

            _sql += "select @sefer_id = @@IDENTITY;\n";

            _sql += "declare @sayac as int = 1;\n";
            _sql += "while (@sayac <= 33)\n";
            _sql += "begin\n";
            _sql += "insert into BILET(sefer_id, koltukno) values (@sefer_id, @sayac);\n";

            _sql += "set @sayac = @sayac + 1;\n";
            _sql += "end\n";

            return _sql;
        }

        public string guncelle()
        {
            return "update SEFER set aciklama = @aciklama, kalkisyeri = @kalkisyeri, varisyeri = @varisyeri, kalkistarihsaati = @kalkistarihsaati where id = @id;";
        }

        public string sil()
        {
            return "delete from SEFER where id = @id;";
        }
    }
}

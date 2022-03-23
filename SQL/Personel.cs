using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class Personel
    {
        public string ara()
        {
            return "select * from PERSONEL where (kullaniciAdi = @kullaniciAdi and sifresi = @sifresi) or id = @id;";
        }

        public string listele()
        {
            return "select id, adi, soyadi from PERSONEL order by adi asc, soyadi asc;";
        }

        public string listele_aramaDegeri()
        {
            return "select id, adi, soyadi from PERSONEL where cast(id as nvarchar(max)) like '%' + @aramaDegeri + '%' or adi like '%' + @aramaDegeri + '%' or soyadi like '%' + @aramaDegeri + '%' order by adi asc, soyadi asc;";
        }

        public string ekle()
        {
            return "insert into PERSONEL (adi, soyadi, kullaniciAdi, sifresi) values (@adi, @soyadi, newid(), '123');";
        }

        public string guncelle()
        {
            return "update PERSONEL set adi = @adi, soyadi = @soyadi, profilResimYolu=@profilResimYolu where id = @id;";
        }

        public string sil()
        {
            return "delete from PERSONEL where id = @id;";
        }

        public string sifreDegistir()
        {
            return "update PERSONEL set kullaniciAdi = @kullaniciAdi, sifresi = @sifresi where id = @id;";
        }
    }
}

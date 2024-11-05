using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w7_Patikafy
{
    public class Singer 
    {
        public string NameSurname { get; set; }
        public string MusicGenre { get; set; }
        public int DebutYear { get; set; }
        public double AlbumSales { get; set; }

        public Singer(string nameSurname, string musicGenre, int debutYear, double aldumSales)
        {
            NameSurname = nameSurname;
            MusicGenre = musicGenre;
            DebutYear = debutYear;
            AlbumSales = aldumSales;
        }

        public override string ToString()
        {
            // Sanatçının ad ve soyadını, müzik türünü, çıkış yılını ve albüm satışlarını belirli bir formatta döndürür.
            // 'PadRight' metodu, yazdırma işlemi sırasında her bir değerin sağda hizalanmasını sağlar.
            return $"{NameSurname.PadRight(20)} {MusicGenre.PadRight(30)} {DebutYear}         yaklaşık {AlbumSales} milyon";
        }
    }
}

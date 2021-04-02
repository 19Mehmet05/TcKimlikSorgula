using MernisProje.TcServis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisProje
{
    class TcSorgulama
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string TcKimlikNo { get; set; }
        private KPSPublicSoapClient client = new KPSPublicSoapClient();

        public bool CheckIfRealPerson()
        {
            Isim = "Mehmet";
            Soyisim = "Büyükbayram";
            DogumTarihi = new DateTime(2000, 1, 1);
            TcKimlikNo = "11111111111";
            return client.TCKimlikNoDogrula(
                Convert.ToInt64(TcKimlikNo),
                Isim.ToUpper(),
                Soyisim.ToUpper(), DogumTarihi.Year);

        }
    }
}

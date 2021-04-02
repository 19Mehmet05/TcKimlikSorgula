using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisProje
{
    class Program
    {
        static void Main(string[] args)
        {
            TcSorgulama tcSorgulama = new TcSorgulama();
            
            if (tcSorgulama.CheckIfRealPerson())
            {
                Console.WriteLine("kayıt var");
            }
            else
            {
                Console.WriteLine("kayıt yok");
            }
            Console.ReadKey();
           


        }
    }
}

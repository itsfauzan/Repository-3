using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classobj
{
    public class Program
    {
        public static void Main()
        {
            Mobil mobil1 = new Mobil();

            mobil1.Warna = "Hitam";
            mobil1.JumlahPintu = 2;
            mobil1.Merk = "BMW";
            mobil1.Model = "E30 Coupe";
            mobil1.TahunKeluar = 1982;

            mobil1.Gas(90);
            mobil1.Klakson();
            mobil1.tampilkaninfo();



            Console.ReadLine();
        }
    }



}
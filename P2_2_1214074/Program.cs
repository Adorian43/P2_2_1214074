using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1214074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sebuah perusahaan mempunyai sistem penggajian sebagai berikut: 

              Karyawan mendapatkan gaji pokok.
              Disamping gaji pokok, karyawan juga mendapatkan bonus dan tunjangan. 
              Potongan yang dikenakan pada karyawan adalah potongan PPH.
              Perhitungan gaji yang harus dilakukan adalah sebagai berikut :

              Gaji Pokok kalian tentukan sendiri dan menggunakan sintaks input

              Tunjangan = 20% dari gaji pokok 
              Bonus = 15% dari gaji pokok 
              PPH = 3,5% dari gaji pokok
              Total Gaji = Gaji Pokok + Tunjangan + Bonus
              Gaji Bersih = Total Gaji – PPH*/


            double gapok, tunjangan, bonus, pph, total_gaji, gaji_bersih;
          
            Console.Write("Masukkan Gaji Pokok : ");
            gapok = Convert.ToDouble(Console.ReadLine());

            tunjangan = (gapok * 20) / 100;
            bonus = (gapok * 15) / 100;
            pph = (gapok * 3.5) / 100;
            total_gaji = gapok + tunjangan + bonus;
            gaji_bersih = total_gaji - pph;

            Console.WriteLine("Tunjangan : " + tunjangan);
            Console.WriteLine("Bonus : " + bonus);
            Console.WriteLine("PPH : " + pph);
            Console.WriteLine("Total Gaji : " + total_gaji);
            Console.WriteLine("Gaji Bersih : " + gaji_bersih);
            Console.ReadKey();
        }
    }
}

using System;

namespace OperasiMatematika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan bilangan pertama: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Masukkan bilangan kedua: ");
            int b = int.Parse(Console.ReadLine());

            int tambah = a + b;
            int kali = a * b;
            int bagi = a / b;        
            int mod = a % b;

            Console.WriteLine("\nHasil Operasi (selalu positif):");
            Console.WriteLine("Penambahan  : " + Math.Abs(tambah));
            Console.WriteLine("Perkalian   : " + Math.Abs(kali));
            Console.WriteLine("Pembagian   : " + Math.Abs(bagi));
            Console.WriteLine("Modulus     : " + Math.Abs(mod));

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}

using System;

namespace Perkenalan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ganti teks dalam tanda kurung dengan data Anda
            string nama = "Faris";
            string programStudi = "Teknik Informatika";
            string namaKampus = "Universitas Pelita bangsa";
            string hobi = "membaca";

            Console.WriteLine("Halo, nama saya adalah {0}", nama);
            Console.WriteLine("Saya kuliah pada jurusan {0} di {1}", programStudi, namaKampus);
            Console.WriteLine("Saya memiliki hobi {0}", hobi);

            // Agar jendela konsol tidak langsung tertutup (tekan Enter untuk keluar)
            Console.WriteLine();
            Console.WriteLine("Tekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}

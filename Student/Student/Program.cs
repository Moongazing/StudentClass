using System;

namespace Student
{
    class Student
    {
        string numara, ad, bolum, durum;
        int arasinav, final, ortalama;

        public string Numara
        {
            get { return numara; }
            set { numara = value; }
        }
        public string Bolum
        {
            get { return bolum; }
            set { bolum = value; }
        }
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }
        public int  Arasinav
        {
            get { return arasinav; }
            set { arasinav = value; }
        }
        public int Final
        {
            get { return final; }
            set { final = value; }
        }
            
        public void OrtalamaDurumHesapla()
        {

            ortalama = Convert.ToInt32(Math.Round(arasinav * 0.3 + final * 0.7));
            if (ortalama >= 60) { durum = "BAŞARILI"; }
            else durum = "BAŞARISIZ";
        }

        public void Listele(int satir)

        {
            Console.SetCursorPosition(0, satir);
            Console.Write(numara);
            Console.SetCursorPosition(15, satir);
            Console.Write(ad);
            Console.SetCursorPosition(35, satir);
            Console.Write(bolum);
            Console.SetCursorPosition(55, satir);
            Console.Write(ortalama);
            Console.SetCursorPosition(70, satir);
            Console.Write(durum);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int ogrenciSayisi;
            Console.WriteLine("Öğrenci Sayısını Giriniz:");
            ogrenciSayisi = int.Parse(Console.ReadLine());
            Student[] std = new Student[0];
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Array.Resize(ref std, std.Length + 1);
                std[i]= new Student();

                Console.Write("{0}.Öğrencinin Numarası: ", i + 1);
                std[i].Numara = Console.ReadLine();

                Console.Write("{0}.Öğrencinin Adı: ",i+1);
                std[i].Ad = Console.ReadLine();

                Console.Write("{0}.Öğrencinin Bölümü: ",i+1);
                std[i].Bolum = Console.ReadLine();

                Console.Write("{0}.Öğrencinin Arasınav Notu: ", i + 1);
                std[i].Arasinav = int.Parse(Console.ReadLine());

                Console.Write("{0}.Öğrencinin Final Notu: ",i+1);
                std[i].Final = int.Parse(Console.ReadLine());

                std[i].OrtalamaDurumHesapla();
            }
            Console.Clear();
            Console.WindowWidth = 80;
            Console.SetCursorPosition(0, 1); Console.Write("NUMARA");
            Console.SetCursorPosition(15, 1); Console.Write("AD");
            Console.SetCursorPosition(35, 1); Console.Write("BÖLÜM");
            Console.SetCursorPosition(55, 1); Console.Write("ORTALAMA");
            Console.SetCursorPosition(70, 1); Console.Write("DURUM");
            Console.SetCursorPosition(0, 2);
            for (int i = 0; i <= 80; i++) Console.Write("-");

            for (int i = 0; i < ogrenciSayisi; i++)
                std[i].Listele(i + 3);

            Console.ReadKey();

        }
    }
}

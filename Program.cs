using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler m1 = new Musteriler();
            m1.MusteriAdi = "Şükriye Nur";
            m1.MusteriId = 1;
            m1.MusteriSoyadi = "KARACA";
            m1.MusteriNo = 2873264;
            Musteriler m2 = new Musteriler();
            m2.MusteriId = 2;
            m2.MusteriAdi = "Aslı";
            m2.MusteriSoyadi = "YUKARI";
            m2.MusteriNo = 37434324;
            Musteriler[] musteriler = new Musteriler[] {m1,m2};
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine(musteriler[i].MusteriId + " " + musteriler[i].MusteriAdi + " " + musteriler[i].MusteriSoyadi + " " + musteriler[i].MusteriNo);
            }
            Ekle eklee = new Ekle();
            eklee.Eklee(3,"Aliye","Ekin",23123);
            Sil sil = new Sil();
            sil.sil(m1);
        }
    }
}

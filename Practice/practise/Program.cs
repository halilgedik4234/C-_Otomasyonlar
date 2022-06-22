using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Model;

namespace Practice
{
    internal class Program
    {


        static void Main(string[] args)
        {

            DbMvcStok2Entities db = new DbMvcStok2Entities();
            //sql deki tablolara yani sınıflara ulaşmak için nesne türettik

            //-- EF ile Listeleme--
            void listele()
            {
                var deger = db.tblmusteri.ToList();
                foreach (var item in deger)
                {
                    Console.WriteLine(item.id + " - " + item.ad + " - " + item.soyad + " - " + item.sehir + " - " + item.durum);
                    Console.WriteLine("");
                }

            }

            void listele2()
            {
                var deger = db.tblpersonel.ToList();
                foreach (var item in deger)
                {
                    Console.WriteLine(item.ad + " - " + item.soyad + " - " + item.departman);
                }
                Console.WriteLine("");
            }



            void ekle(string ad, string soyad, string departman)
            {
                tblpersonel t = new tblpersonel();
                t.ad = ad;
                t.soyad = soyad;
                t.departman = departman;
                db.tblpersonel.Add(t);
                db.SaveChanges();
                listele2();
            }

            //ekle("Deneme", "denemeee", "satış");



            void silme()
            {
                Console.Write("Silinecek peronelin id'sini giriniz: ");
                int id = Convert.ToInt32(Console.ReadLine());
                tblpersonel t = new tblpersonel();
                var value = db.tblpersonel.Find(id);
                db.tblpersonel.Remove(value);
                db.SaveChanges();

                Console.WriteLine("Kişi silinmiştir...");
                Console.WriteLine("");
                listele2();

            }
            //silme();


            void guncelle()
            {
                tblpersonel t = new tblpersonel();
                Console.Write("Güncellenecek personelin id'sini giriniz: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Yeni ad: ");
                string ad = Console.ReadLine();
                Console.Write("Yeni soyad: ");
                string soyad = Console.ReadLine();
                Console.Write("Yeni departman: ");
                string departman = Console.ReadLine();
                Console.WriteLine("");
                var value = db.tblpersonel.Find(id);
                value.ad = ad;
                value.soyad = soyad;
                value.departman = departman;
                db.SaveChanges();
                listele2();
            }

            //guncelle();


            void arama()
            {
                Console.Write("Aranan Müşteri ismi giriniz: ");
                string aranan = Console.ReadLine();
                Console.WriteLine("");

                var values2 = db.tblmusteri.Where(x => x.ad == aranan).ToList();
                foreach (var item in values2)
                {

                    Console.WriteLine(item.id + " - " + item.ad + " - " + item.soyad);

                }

            }
            //arama();

            void istatistikler()
            {
                Console.Write("toplam Kişi Sayısı: ");
                var value = db.tblmusteri.Count();
                Console.WriteLine(value);

                Console.Write("Toplam Bakiye: ");
                var value2 = db.tblmusteri.Sum(x => x.bakiye);
                Console.WriteLine(value2+ " TL");


            }
            istatistikler();


            Console.ReadLine();



        }


    }
}

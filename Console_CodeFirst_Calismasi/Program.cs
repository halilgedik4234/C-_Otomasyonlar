using Console_CodeFirst_Calismasi.DAL;
using Console_CodeFirst_Calismasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CodeFirst_Calismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person
            //jobs

            // DAL --> data access layer--> sql connection yazılır
            // Context --> Veri tabanı bağlantı adresi ve veri  tabanı bağlantı yapılandırması örnek context sınıfındaki bir property;
            // public DbSet <Customer> Customers { get; set; }


            // migration --> göç

            // CODE FİRST

            Context c = new Context();


            //  ** LİSTELEME **
            void CustomerList()
            {
                var value = c.Customers.ToList();
                foreach (var item in value)
                {
                    Console.WriteLine(item.customerID + " " + item.customerName + " " + item.customerCity);
                }
            }
            //CustomerList();

            
            // ** MÜŞTERİ EKLEME **
            void CustomerAdd(string name,string city)
            {
                Customer p = new Customer();
                p.customerName = name;
                p.customerCity = city;
                c.Customers.Add(p);
                c.SaveChanges();
                CustomerList(); 
            }
            //CustomerAdd("Ahmet", "Antalya");



            //  ** MÜŞTERİ SİLME **
            void CustomerDelete(int id)
            {
                var value = c.Customers.Find(id);

                Console.WriteLine(id + " numaralı kayıt silinmiştir..");
                Console.WriteLine("");
                Console.WriteLine("silinen Kişi id ve ad = " +value.customerID+" "+value.customerName);
                Console.WriteLine("------------------------");

                c.Customers.Remove(value);
                c.SaveChanges();
                
                CustomerList();
            }
            //CustomerDelete(11); 11 numaralı kayıt silindi


            //  ** MÜŞTERİ GÜNCELLEME **
            void CustomerUpdate(int id,string name,string city)
            {
                var values=c.Customers.Find(id);

                Console.WriteLine(id + " numaralı kayıt güncellenmiştir..");
                Console.WriteLine("");
                Console.WriteLine("------------------------");

                values.customerName = name;
                values.customerCity = city;
                c.SaveChanges();

                CustomerList();
            }
            //CustomerUpdate(5,"Murat Yücedağ","Düzce");
            Console.ReadLine();


        }
    }
}

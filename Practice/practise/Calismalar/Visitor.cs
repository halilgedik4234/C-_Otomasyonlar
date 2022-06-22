using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Visitor
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public void mesaj(Visitor visitor)
        {
            Console.Write(visitor.ID);
            Console.Write(" ");
            Console.Write(visitor.Name);
            Console.Write(" From ");
            Console.WriteLine(visitor.City);
            Console.WriteLine("***********************************");
        }
    }
}

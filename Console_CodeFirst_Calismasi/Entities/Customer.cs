using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CodeFirst_Calismasi.Entities
{
    public class Customer
    {
        [Key]
        public int customerID { get; set; }

        public string customerName { get; set; }

        public string customerCity { get; set; }



    }
}

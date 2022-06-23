using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CodeFirst_Calismasi.Entities
{
    public class Employee
    {
        [Key]
        public int employeeID { get; set; }

        public string employeeName { get; set; }
    }
}

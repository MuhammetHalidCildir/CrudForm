using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudForm.Data
{
    [Table(name: "employees")]
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string deparment { get; set; }
        public decimal salary { get; set; }
    }

    [Table(name: "employees_a")]
    public class EmployeeA
    {
        [Key]
        public int a_id { get; set; }
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string deparment { get; set; }
        public decimal salary { get; set; }
    }

    [Table(name: "employees_b")]
    public class EmployeeB
    {
        [Key]
        public int b_id { get; set; }
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string deparment { get; set; }
        public decimal salary { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudForm.Data
{
    public class DALContext : DbContext
    {
        public readonly static string conn_str = @"Server=.\SQLEXPRESS;Database=DAL;User Id=sa;Password=1;";

        public DALContext() : base(conn_str)
        {

        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeA> EmployeesA { get; set; }
        public virtual DbSet<EmployeeB> EmployeesB { get; set; }
    }
}

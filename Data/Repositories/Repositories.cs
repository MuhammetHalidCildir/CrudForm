using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace CrudForm.Data.Repositories
{
    public class Repositories
    {
        public static readonly EmployeeRepository employeeRepository = new EmployeeRepository();

        public static readonly Repository<EmployeeA> employeeaRepository = new Repository<EmployeeA>(new DALContext());

        public static readonly Repository<EmployeeB> employeebRepository = new Repository<EmployeeB>(new DALContext());
    }
}

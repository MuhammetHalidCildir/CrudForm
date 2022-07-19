using CrudForm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace CrudForm.Data.Repositories
{
    public class EmployeeRepository : Repository<Employee>
    {
        public EmployeeRepository() : base(new DALContext())
        {
        }

        public IQueryable<EmployeeListModel> GetEmployeeList(Expression<Func<Employee, bool>> expression = null)
        {
            return base.ReadMany(expression).Select(x => new EmployeeListModel
            {
                id = x.id,
                first_name = x.first_name,
                last_name = x.last_name,
                email = x.email
            });
        }
    }
}

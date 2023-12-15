using DAL.ER.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ER
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee>Employees { get; set; }   
    }
}

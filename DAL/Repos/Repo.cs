using DAL.ER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
   public class Repo
    {
        protected EmployeeContext db; 
        public Repo() 
        
        {
        
            db = new EmployeeContext();
        
        }
    }
}

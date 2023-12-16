using DAL.ER.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class EmployeeRepo : Repo, IRepos<Employee, int, bool>
    {
        public bool Create(Employee obj)
        {
            try
            {
                db.Employees.Add(obj);
                return db.SaveChanges() > 0; // savechange akta row return kore ba add kore ; 0 theke besi hole akta row add kore

            }
            catch (Exception ex) 
            {
                throw ex;
            
            }
            
        }

        public bool Delete(int id)
        {
           Employee emp = db.Employees.Find(id);
            db.Employees.Remove(emp);

            if(db.SaveChanges() > 0)
            {

                return true;
            }
            else
            {
                return false; 
            }

        }

        public Employee Get(int id)
        {
           try
            {

                Employee emp=db.Employees.Find(id);
                return emp;
            }
            catch(Exception ex)
            
            {
                throw ex;
            
            }

        }

        public List<Employee> GetAll()
        {
            var emp = db.Employees;
            return emp.ToList();
        }

        public bool Update(Employee obj)
        {
            try 
            {
                Employee emp = db.Employees.Find(obj.Id);
                db.Entry(emp).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            catch(Exception ex) 
            {
                throw ex;
            }
           
        }
    }
}

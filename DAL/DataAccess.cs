﻿using DAL.ER.Model;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        public static IRepos<Employee, int, bool> EmployeeData()
        {

            return new EmployeeRepo();
        
        }



    }
}

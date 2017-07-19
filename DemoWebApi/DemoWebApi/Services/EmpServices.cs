using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using DemoWebApi.IRepository;
using DemoWebApi.Models;

namespace DemoWebApi.Services
{
    public class EmpServices
    {
        private static IRepositoryEmp Repository
        {
            get { return ObjectFactory.GetInstance<IRepositoryEmp>(); }
        }
        public static QueryResult SaveEmpDetails(EmployeeDetails emp)
        {
            return Repository.SaveEmpDetails(emp);
        }
    }
}
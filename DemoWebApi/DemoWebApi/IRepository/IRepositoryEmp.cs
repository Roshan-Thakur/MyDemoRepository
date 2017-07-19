using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoWebApi.Repository;
using DemoWebApi.Models;

namespace DemoWebApi.IRepository
{
    public interface IRepositoryEmp
    {
        QueryResult SaveEmpDetails(EmployeeDetails emp);
    }
}
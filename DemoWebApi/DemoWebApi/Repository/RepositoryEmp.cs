using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoWebApi.IRepository;
using NHibernate;
using DemoWebApi.Nhibernet;
using DemoWebApi.Models;
namespace DemoWebApi.Repository
{
    public class RepositoryEmp:IRepositoryEmp
    {
        string ConectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConn"].ToString();

        public QueryResult SaveEmpDetails(EmployeeDetails emp)
        {
            QueryResult result = new QueryResult();
            ISession session = CommonClass.GetCurrentSession();
            using(ITransaction tx=session.BeginTransaction()){
                session.SaveOrUpdate(emp);
                tx.Commit();
            }
            result.Status = QueryResult.Results.Success;
            return result;
        }
    }
}
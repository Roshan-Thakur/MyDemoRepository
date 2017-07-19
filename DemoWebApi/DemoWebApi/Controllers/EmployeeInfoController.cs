using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoWebApi.Services;
using DemoWebApi.Models;

namespace DemoWebApi.Controllers
{
    public class EmployeeInfoController : Controller
    {
        //
        // GET: /EmployeeInfo/
        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs()]
        public ActionResult EmpRagistration(EmployeeDetails emp)
        {
            var result = EmpServices.SaveEmpDetails(emp);
            if(result.Status==QueryResult.Results.Success)
            {
                return Json(new {Status=true, message="Save Data Sucessfully!!" });
            }
            else
            {
                return Json(new {Status=false, message="Error in save Data!!" });
            }
        }
	}
}
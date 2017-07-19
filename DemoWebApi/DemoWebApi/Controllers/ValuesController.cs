using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Web.Http;
using System.Net.Http;

namespace DemoWebApi.Controllers
{
    public class ValuesController :ApiController
    {
        public List<string> Get()
        {
            List<string> lst=new List<string>();
            string item = "Roshan Thakur";
            //  item += "Hello";
            item = string.Concat(item, "ConataString");
          
            lst.Add(item);
            return lst;
        }
        public string Get(int id)
        {
            if (id == 2)
            {

                return "Roshan";
            } return "Thakur";
        }
        public string Post(int id)
        {
            if(id==4){
                return "Roshan Thakur Updated";
            } return "Not Updated";
           
        }
        public string Delete(string val)
        {

            return (val+"Deletion Succesfully!") ;
        }
	}
}
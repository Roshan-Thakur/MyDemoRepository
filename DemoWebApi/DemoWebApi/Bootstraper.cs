using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoWebApi.IRepository;
using StructureMap;
using StructureMap.Configuration.DSL;


namespace DemoWebApi
{
    public class Bootstraper
    {
        public static void ConfigureStructureMap()
        {
            StructureMapConfiguration.AddRegistry(new AgentPortalRegistry());
        }
    }
    public class AgentPortalRegistry : Registry
    {

        protected override void configure()
        {
            #region Services
            ForRequestedType<IRepositoryEmp>().TheDefaultIsConcreteType<Repository.RepositoryEmp>();
            #endregion 
        }
    }
}
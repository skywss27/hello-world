using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using EHOME.DTO;
using EHOME.Models;
using EHOME.TeamInterface;
using EHOME.TeamService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EHOME
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();
            SetupResolveRules(builder);
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisteAutoMapper();

        }
        private void SetupResolveRules(ContainerBuilder builder)
        {
            builder.RegisterType<TeamMemberService>().As<ITeamMember>();
        }
        protected void RegisteAutoMapper() 
        {
            Mapper.Initialize(cfg=>{
                cfg.CreateMap<TeamMemberDTO, TeamMember>();
                cfg.CreateMap<TeamMember, TeamMemberDTO>();
                
            });
        }

        //public class AProfile : Profile
        //{
        //    public AProfile()
        //    {
        //        Mapper
        //    }
        //}
    }
}

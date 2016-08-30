using EHOME.TeamInterface;
using EHOME.TeamService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EHOME.Controllers
{
    public class HomeController : Controller
    {
        private ITeamMember team = new TeamMemberService();
        public ActionResult Index()
        {
            return View(team.GetAllMembers());
        }

        public ActionResult About()
        {
            ViewBag.Message = "小组介绍";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "联系我们";

            return View();
        }
    }
}
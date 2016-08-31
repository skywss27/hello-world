using EHOME.DTO;
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
        private ITeamMember _team ;
        public HomeController(ITeamMember team) 
        {
            _team = team;
        }
        public ActionResult Index()
        {
            return View(_team.GetAllMembers());
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
        public ActionResult Details(int? id)
        {
            ViewBag.Message = "成员信息";
            TeamMemberDTO dto = new TeamMemberDTO();
            if (id != null)
                dto = _team.GetMemberById((int)id);
            return View(dto);
        }

        [HttpGet]
        public ActionResult AddMember() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMember(TeamMemberDTO dto)
        {

            _team.UpdateMember(dto);

            return RedirectToAction("Index"); ;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcleaderboard.Controllers
{
    public class SkillsController : Controller
    {
        //
        // GET: /Skills/

        public ActionResult Index()
        {
            return View();
        }
        
        // SKILLS/GRANT

        public ActionResult Grant()
        {
            
            // alle useres doorgeven naar view via viewbag
            Models.UserModel usermodel = new Models.UserModel();
            ViewBag.users = usermodel.selectAll();
            return View();

               Models.SkillModel skillmodel = new Models.SkillModel(as;
              ViewBag.skills = skillmodel.selectAll();
              return View();


        }



    }
}

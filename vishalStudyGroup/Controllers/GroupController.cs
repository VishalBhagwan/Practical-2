using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vishalStudyGroup.Controllers
{
    public class GroupController : Controller
    {
        // GET: Group

        public ActionResult ListGroup()
        {
            List<Models.GroupModel> group = new List<Models.GroupModel>();

            group.Add(new Models.GroupModel { StudentNum = "u23684722", FirstName = "Vishal", LastName = "Bhagwan", Email = "u23684722@tuks.co.za"});

            return View(group);
        }
    }
}
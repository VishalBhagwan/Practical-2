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
            group.Add(new Models.GroupModel { StudentNum = "u23585600", FirstName = "Callum", LastName = "Molver", Email = "u23585600@tuks.co.za" });
            group.Add(new Models.GroupModel { StudentNum = "u24706672", FirstName = "Nikhil", LastName = "Sunker", Email = "u24706672@tuks.co.za" });
            group.Add(new Models.GroupModel { StudentNum = "u23601711", FirstName = "Tyla", LastName = "Naidoo", Email = "u23601711@tuks.co.za" });
            group.Add(new Models.GroupModel { StudentNum = "u23682044", FirstName = "Musawenkosi", LastName = "Mathebula", Email = "u23682044@tuks.co.za" });

            return View(group);
        }
    }
}
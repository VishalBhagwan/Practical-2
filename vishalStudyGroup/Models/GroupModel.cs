using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace vishalStudyGroup.Models
{
    public class GroupModel
    {
        [Display(Name = "Student Number")]
        public string StudentNum { get; set; }

        [Display(Name = "Name")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Link to Personal Page")]
        public string myLink { get; set; }
    }
}

// <a href="@item.myLink" class="btn btn-primary">View Profile</a>
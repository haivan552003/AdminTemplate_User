using Microsoft.AspNetCore.Mvc;
using AdminTemplate_User.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace AdminTemplate_User.Controllers
{
    public class UserController : Controller
    {
        private static List<User> _users = new List<User>()
        {
            new User(){Id = 1, Name = "Vân 1", Birthday = DateTime.Parse("12/12/2010"), Gender = 1, Class= "SD18301", Email = "haivan5.5.2003@gmail.com"},
            new User(){Id = 2, Name = "Vân 2", Birthday = DateTime.Parse("12/12/2010"), Gender = 1, Class= "SD18301", Email = "haivan5.5.2003@gmail.com"},
            new User(){Id = 3, Name = "Vân 3", Birthday = DateTime.Parse("12/12/2010"), Gender = 1, Class= "SD18301", Email = "haivan5.5.2003@gmail.com"},
            new User(){Id = 4, Name = "Vân 4", Birthday = DateTime.Parse("12/12/2010"), Gender = 1, Class= "SD18301", Email = "haivan5.5.2003@gmail.com"}
        };
        public IActionResult Index()
        {
            return View(_users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _users.Add(user);
                return RedirectToActionPermanent("Index");
            }
            return View(_users);
        }
    }
}

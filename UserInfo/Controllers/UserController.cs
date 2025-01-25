using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UserInfo.Entities;

namespace UserInfo.Controllers
{
    public class UsersController : Controller
    {
        public static List<User> users = new List<User>()
    {
        new User
        {
            Id = 1,
            Name = "Tural",
            Surname = "Huseynli",
            Image = "image",
            Age = 20
        },
        new User
        {
            Id = 2,
            Name = "Adolf",
            Surname = "Hitler",
            Image = "image",
            Age = 1945
        }
    };

        public ViewResult Index()
        {
            return View(users);
        }

        public ViewResult Details(int id)
        {
            User user = users.Find(x => x.Id == id);
            return View(user);
        }

        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            user.Id = users.Count > 0 ? users[^1].Id + 1 : 1;
            users.Add(user);
            return RedirectToAction("Index");
        }
    }
}

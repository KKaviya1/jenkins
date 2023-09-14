using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
            new User(){UserId=1,UserName="Viya",UserPwd="Viya050601",UserEmail="viya@gmail.com"},
            new User(){UserId=2,UserName="Priya",UserPwd="Pri123",UserEmail="pri@gmail.com"},
            new User(){UserId=3,UserName="Ramya",UserPwd="Ram456",UserEmail="ram@gmail.com"},
            new User(){UserId=4,UserName="Prakash",UserPwd="Pra789",UserEmail="pra@gmail.com"},
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            if(ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
      
    }
}

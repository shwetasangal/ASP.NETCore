using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApp1.Models;


namespace TestApp1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //var model = new Videos{ Id=1,Title = "FirstBook"};
            var model = new List<Videos>
            {
                new Videos { Id=1,Title = "FirstBook"},
                new Videos { Id = 2, Title = "SecondBook" },
                new Videos { Id = 3, Title = "ThirdBook" }
            };
            return View(model);
        }
            
        }
    }


using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Controllers
{
    public class Dokumanlar : Controller
    {
        TaskDokumanManager tm = new TaskDokumanManager(new EfTaskDokumanRepository());
        public IActionResult Index()
        {
            var deger = tm.GetDokumanWithTaskName();
            return View(deger);
        }
    }
}

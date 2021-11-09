using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace TaskManager.Controllers
{
    public class PersonelCont : Controller
    {
        PersonelManager pm = new PersonelManager(new EfPersonelRepository());
        public IActionResult Index()
        {
            var result = pm.GetlistWithYetki();
            return View(result);
        }
        public IActionResult Personel()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Personel(Personel personel)
        {
            pm.TaskAdd(personel);
            return RedirectToAction("Index");
        }
    }
}

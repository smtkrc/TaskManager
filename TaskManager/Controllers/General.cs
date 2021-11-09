using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Controllers
{
    public class General : Controller
    {
        PersonelManager pm1 = new PersonelManager(new EfPersonelRepository());
        TaskDetayManager tm = new TaskDetayManager(new EfTaskDetayRepository());
        TaskDokumanManager tdm = new TaskDokumanManager(new EfTaskDokumanRepository());
        public IActionResult Index()
        {
            ViewBag.dg1 = tdm.GetDokumanName().ToList();
            var deger= tm.GetListTaskDurum();
            return View(deger);
        }
        [HttpGet]
        public IActionResult TaskEkle()
        {
            List<SelectListItem> PersonelValues = (from x in pm1.GetAllList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.PersonelAdSoyad,
                                                       Value = x.PersonelId.ToString()
                                                   }).ToList();
            ViewBag.dg1 = PersonelValues;
            return View();
        }
        [HttpPost]
        public IActionResult TaskEkle(TaskDetay taskdetay,TaskDokuman taskdokuman)
        {
           
            taskdetay.TaskOlusturulmaTarihi = DateTime.UtcNow;
            tm.TaskAdd(taskdetay);
            return RedirectToAction("Index");
        }
        
    }
}

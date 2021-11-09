using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace TaskManager.Controllers
{
    public class AdminControl : Controller
    {
        PersonelManager tm = new PersonelManager(new EfPersonelRepository());
        
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
       
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Personel p)
        {
            Context c = new Context();
            var data = c.Personels.FirstOrDefault(x => x.PersonelKullaniciAdi == p.PersonelKullaniciAdi && x.PersonelSifre == p.PersonelSifre);
            if (data!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.PersonelKullaniciAdi)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "General");
            }
            else
            {
                return View();
            }
        }
    }
}
//Context c = new Context();
//var data = c.Personels.FirstOrDefault(x => x.PersonelKullaniciAdi == p.PersonelKullaniciAdi && x.PersonelSifre == p.PersonelSifre);
//if (data != null)
//{
//    HttpContext.Session.SetString("UserName", p.PersonelKullaniciAdi);
//    HttpContext.Session.SetString("Password", p.PersonelSifre);
//    return RedirectToAction("Index", "General");
//}
//else
//{
//    return View();
//}
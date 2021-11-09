using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-E1NQ81J\\SQLEXPRESS;database=TaskManagerDb; integrated security=true;");
        }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<TaskDetay> TaskDetays { get; set; }
        public DbSet<TaskAksiyon> TaskAksiyons { get; set; }
        public DbSet<TaskDokuman> TaskDokumans { get; set; }
        public DbSet<TaskDurum> TaskDurums { get; set; }
        public DbSet<TaskOncelik> TaskOnceliks { get; set; }
        public DbSet<Yetki> Yetkis { get; set; }
    }
}

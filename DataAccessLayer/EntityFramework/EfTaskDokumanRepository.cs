using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfTaskDokumanRepository:GenericRepository<TaskDokuman>,ITaskDokumanDal
    {
        public List<string> GetDokumanName()
        {
            using (var d = new Context())
            {
                var deger = d.TaskDokumans.Select(x => x.DokumanBaslık).ToList();
                return deger;
            }
        }

        public List<TaskDokuman> GetDokumanWithTaskName()
        {
            using (var c = new Context())
            {
                var deger = c.TaskDokumans.Include(x => x.TaskDetay).ToList();
                return deger;
            }
        }

       
    }
}

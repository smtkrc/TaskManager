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
using System.Web.Mvc;

namespace DataAccessLayer.EntityFramework
{
    public class EfTaskDetayRepository : GenericRepository<TaskDetay>, ITaskDetayDal
    {
        public List<TaskDetay> GetListWithDurum()
        {
            using (var c = new Context())
            {
                var deger = c.TaskDetays.Include(x => x.TaskDurum).Include(y=>y.TaskOncelik).Include(z=>z.Personel).ToList();
                return deger;
            }
        }
      
    }
}

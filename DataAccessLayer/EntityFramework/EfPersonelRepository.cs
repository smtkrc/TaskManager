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
    public class EfPersonelRepository:GenericRepository<Personel>,IPersonelDal
    {
        public List<Personel> GetAlllistWithYetki()
        {
            using (var c = new Context())
            {
                var deger = c.Personels.Include(x => x.yetkis).Include(y=>y.Departman).ToList();
                return deger;
            }
        }
    }
}

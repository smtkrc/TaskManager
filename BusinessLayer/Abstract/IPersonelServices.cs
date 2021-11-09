using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPersonelServices
    {
        void TaskAdd(Personel personel);
        void TaskDelete(Personel personel);
        void TaskUpdate(Personel personel);
        List<Personel> GetAllList();
        void GetById(int id);
        List<Personel> GetlistWithYetki();
    }
}

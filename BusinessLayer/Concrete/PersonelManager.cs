using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PersonelManager : IPersonelServices
    {
        IPersonelDal _personeldal;

        public PersonelManager(IPersonelDal personeldal)
        {
            _personeldal = personeldal;
        }

        public List<Personel> GetAllList()
        {
            return _personeldal.GetListAll();
        }

        public void GetById(int id)
        {
            _personeldal.GetById(id);
        }

        public List<Personel> GetlistWithYetki()
        {
            return _personeldal.GetAlllistWithYetki();
        }

        public void TaskAdd(Personel personel)
        {
            _personeldal.Insert(personel);
        }

        public void TaskDelete(Personel personel)
        {
            throw new NotImplementedException();
        }

        public void TaskUpdate(Personel personel)
        {
            throw new NotImplementedException();
        }
    }
}

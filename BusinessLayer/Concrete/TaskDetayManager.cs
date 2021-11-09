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
    public class TaskDetayManager : ITaskDetayService
    {

        ITaskDetayDal _taskDetayDal;
        public TaskDetayManager(ITaskDetayDal taskDetayDal)
        {
            _taskDetayDal = taskDetayDal;
        }

        public List<TaskDetay> GetList(TaskDetay taskdetay)
        { 
           return _taskDetayDal.GetListAll();
        }

        public List<TaskDetay> GetAllList()
        {
           return _taskDetayDal.GetListAll();
        }
        public void GetById(int id)
        {
            _taskDetayDal.GetById(id);
        }

        public void TaskAdd(TaskDetay taskdetay)
        {
            _taskDetayDal.Insert(taskdetay);
        }

        public void TaskDelete(TaskDetay taskdetay)
        {
            _taskDetayDal.Delete(taskdetay);
        }

        public void TaskUpdate(TaskDetay taskdetay)
        {
            _taskDetayDal.Update(taskdetay);
        }

        void ITaskDetayService.GetAllList()
        {
            throw new NotImplementedException();
        }

        public List<TaskDetay> GetListTaskDurum()
        {
          return   _taskDetayDal.GetListWithDurum();
        }
    }
}

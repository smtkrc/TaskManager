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
    public class TaskDokumanManager : ITaskDokumanService
    {
        ITaskDokumanDal _Itaskdokumandal;

        public TaskDokumanManager(ITaskDokumanDal ıtaskdokumandal)
        {
            _Itaskdokumandal = ıtaskdokumandal;
        }

        public List<TaskDokuman> GetAllList()
        {
           return _Itaskdokumandal.GetListAll();
        }

        public void GetById(int id)
        {
            _Itaskdokumandal.GetById(id);
        }

        public List<string> GetDokumanName()
        {
           return _Itaskdokumandal.GetDokumanName();
        }

        public List<TaskDokuman> GetDokumanWithTaskName()
        {
           return _Itaskdokumandal.GetDokumanWithTaskName();
        }

        public void TaskAdd(TaskDokuman taskdokuman)
        {
            _Itaskdokumandal.Insert(taskdokuman);
        }

        public void TaskDelete(TaskDokuman taskdokuman)
        {
            _Itaskdokumandal.Delete(taskdokuman);
        }

        public void TaskUpdate(TaskDokuman taskdokuman)
        {
            _Itaskdokumandal.Update(taskdokuman);
        }
    }
}

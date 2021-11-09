using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITaskDetayService
    {
        void TaskAdd(TaskDetay taskdetay);
        void TaskDelete(TaskDetay taskdetay);
        void TaskUpdate(TaskDetay taskdetay);
        void GetAllList();
        void GetById(int id);
        List<TaskDetay> GetListTaskDurum();
    }
}

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITaskDokumanService
    {
        void TaskAdd(TaskDokuman taskdokuman);
        void TaskDelete(TaskDokuman taskdokuman);
        void TaskUpdate(TaskDokuman taskdokuman);
        List<TaskDokuman> GetAllList();
        void GetById(int id);
        public List<string> GetDokumanName();
        public List<TaskDokuman> GetDokumanWithTaskName();
    }
}

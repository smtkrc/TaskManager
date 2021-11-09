using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TaskOncelik
    {
        [Key]
        public int OncelikId { get; set; }
        public string OncelikAd { get; set; }
        public List<TaskDetay> TaskDetays { get; set; }
    }
}

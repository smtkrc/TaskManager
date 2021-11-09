using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yetki
    {
        [Key]
        public int YetkiId { get; set; }
        public string YetkiAd { get; set; }
        public List<Personel> personels { get; set; }
    }
}

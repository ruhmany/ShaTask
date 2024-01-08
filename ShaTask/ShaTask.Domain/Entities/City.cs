using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Domain.Entities
{
    public class City : BaseEntity
    {
        public int ID { get; set; }
        public string CityName { get; set; }
        public virtual List<Branch> Branches { get; set; }
    }
}

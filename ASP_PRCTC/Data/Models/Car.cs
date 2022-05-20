using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Practice.Data.Models
{
    public class Car
    {
        public int id { set; get; }
        public string Name { set; get; }
        public string Shortddesc { set; get; }
        public string Longdesc { set; get; }
        public string Img { set; get; }
        public ushort Price { set; get; }
        public bool IsFavourite { set; get; }
        public bool Available { set; get; }
        public int CategoryId { set; get; }

        public virtual Category Category { set; get; }
    }
}

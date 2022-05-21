using ASP_Practice.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Practice.Data.Interfaces
{
   public interface ICarsCategory
    {
        //Возвращает список типа данных Category
        IEnumerable<Category> AllCategoies { get; }
    }
}

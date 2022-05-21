using ASP_Practice.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Practice.Data.Interfaces
{
   public interface IAllCars
    {
        IEnumerable<Car> Cars { get;  }
        IEnumerable<Car> GetFavCars { get; set; }
        Car GetObjectCar(int CarID);


    }
}

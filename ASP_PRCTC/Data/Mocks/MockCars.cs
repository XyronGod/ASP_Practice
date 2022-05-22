using ASP_Practice.Data.Interfaces;
using ASP_Practice.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Practice.Data.Mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _CategoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
            new Car { Name = "Tesla", 
                Shortddesc = "", 
                Longdesc = "", 
                Img = "/img/Tesla.jpg", 
                Price = 45000,
                IsFavourite = true,
                Available = true,
                Category = _CategoryCars.AllCategoies.First()
            },
            new Car { Name = "MERC",
                Shortddesc = "",
                Longdesc = "",
                Img = "/img/mersedes-amg.jpg",
                Price = 65000,
                IsFavourite = true,
                Available = true,
                Category = _CategoryCars.AllCategoies.Last()
            },
            new Car { Name = "FORD",
                Shortddesc = "",
                Longdesc = "",
                Img = "/img/ford-focus-sedan-4.jpg",
                Price = 55000,
                IsFavourite = false,
                Available = false,
                Category = _CategoryCars.AllCategoies.Last()
            },

                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int CarID)
        {
            throw new NotImplementedException();
        }
    }
}

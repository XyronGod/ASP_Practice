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
                Img = "https://avatars.mds.yandex.net/get-zen_doc/3473288/pub_6009ca00b7c9394d3023de38_6009d0c211af84570bd7f6fd/scale_1200", 
                Price = 45000,
                IsFavourite = true,
                Available = true,
                Category = _CategoryCars.AllCategoies.First()
            },
            new Car { Name = "MERC",
                Shortddesc = "",
                Longdesc = "",
                Img = "https://proprikol.ru/wp-content/uploads/2020/09/kartinki-mersedes-mercedes-48.jpg",
                Price = 65000,
                IsFavourite = true,
                Available = true,
                Category = _CategoryCars.AllCategoies.Last()
            },
            new Car { Name = "FORD",
                Shortddesc = "",
                Longdesc = "",
                Img = "https://i.trse.ru/2015/07/image2-82.jpg",
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

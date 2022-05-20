using ASP_Practice.Data.Interfaces;
using ASP_Practice.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Practice.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategoies { get { 
                return new List<Category> 
                {
            new Category { CategoryName = "Электромобили", desc = "Современный вид транспорта" },
            new Category { CategoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                };
        } 
        
        }
    }
}

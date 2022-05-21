using ASP_Practice.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PRCTC.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _AllCars;
        private readonly ICarsCategory _AllCategoryies;

        public CarsController(IAllCars iallCars, ICarsCategory icarsCat)
        {
            _AllCars = iallCars;
            _AllCategoryies = icarsCat;
        }
        //Метод, который возвращает HTML-страницу
        public ViewResult  List()
        {
            ViewBag.Category = "Some New";
            var cars = _AllCars.Cars;
            return View(cars);
        }
    }
}

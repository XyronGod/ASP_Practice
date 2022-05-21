using ASP_Practice.Data.Interfaces;
using ASP_PRCTC.ViewModels;
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
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _AllCars.Cars;
            obj.CurrCategory = "Автомобили";
            return View(obj);
        }
    }
}

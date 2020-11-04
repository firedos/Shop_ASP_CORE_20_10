﻿using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller 
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategories;
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _carsCategories = iCarsCat;
        }
        public ViewResult List()
        {
            //ViewBag.Category = "Some New";
            //var cars = _allCars.Cars; 
            CarsListViewModel obj = new CarsListViewModel();
            ViewBag.Title = "Страница с автомобилями";
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
        }
    }
}


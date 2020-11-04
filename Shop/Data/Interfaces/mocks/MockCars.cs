using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> 
                { 
                    new Car { 
                        name = "Tesla mobilt",
                        shortDesc = "Быстрый авто",
                        longtDesc= "",
                        //img = "https://www.tesla.com/contrent/dam/tesla-site/sx-redisign/img/socialcard/ms.ipg",
                        img = "/img/tesla.jpg",
                        price = 45000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.First()
                    },
                    new Car { 
                        name = "Ford fiesta",
                        shortDesc = "тихий и спокойный",
                        longtDesc= "для города",
                        img = "https://auto.ru/catalog/cars/bmw/7er/21473050/21473416/?geo_id=10725",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()}
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}

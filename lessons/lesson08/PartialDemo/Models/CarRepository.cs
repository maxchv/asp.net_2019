using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace PartialDemo.Models
{
    public class CarRepository
    {
        private readonly List<Car> _cars = new List<Car>
        {
            new Car{Id=1, Name = "Audi A8", Color = "Red", Price = 25_000.0m},
            new Car{Id=2, Name = "BMW X9", Color = "Black", Price = 15_000.0m},
            new Car{Id=3, Name = "Porche", Color = "Yellow", Price = 35_000.0m},
            new Car{Id=4, Name = "Таврия", Color = "Magenta", Price = 123_000.0m},
        };
        private static CarRepository instance = new CarRepository();
        public static CarRepository Instance => instance;

        private CarRepository()
        {
            
        }

        public List<Car> Cars(int delay = 3000)
        {
            Thread.Sleep(delay);
            return _cars;
        }
    }
}
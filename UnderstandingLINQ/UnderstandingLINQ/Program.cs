using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myList = new List<Car>()
            {
                new Car() {Make = "Volkswagen", Model = "Gol", VIN = "A1", StickerPrice = 45000, Year = 2015},
                new Car() {Make = "Fiat", Model = "Uno", VIN = "B2", StickerPrice = 43000, Year = 2016 },
                new Car() {Make = "GM", Model = "Corsa", VIN = "C3", StickerPrice = 38000, Year = 2014 },
                new Car() {Make = "GM", Model = "Ka", VIN = "D4", StickerPrice = 46500, Year = 2017 },
                new Car() {Make = "Peogeut", Model = "206", VIN = "E5", StickerPrice = 29000, Year = 2012 }
            };

            //LINQ Query
            /*
            var Gms = from Car in myList
                      where Car.Make == "GM"
                      && Car.Year == 2017
                      select Car;
            */
            /*
            var OrderedCars = from car in myList
                              orderby car.Year descending
                              select car;
            */


            // LINQ Method
            //var Gms = myList.Where(p => p.Make == "GM" && p.Year == 2017);

            //var OrderedCars = myList.OrderByDescending(p => p.Year);
            /*
            var firstGM = myList.OrderByDescending(p => p.Year).First(p => p.Make == "GM");
            Console.WriteLine(firstGM.VIN);
            */

            //Console.WriteLine(myList.TrueForAll(p => p.Year > 2009));

            /*
            foreach (var car in OrderedCars)
            {
                Console.WriteLine("{0} {1}",car.Year, car.Model, car.VIN);
            }
            */
            //myList.ForEach(p => p.StickerPrice -= 3000);
            //myList.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            //Console.WriteLine(myList.Exists(p => p.Model == "Ka"));

            //Console.WriteLine(myList.Sum(p => p.StickerPrice));

            Console.WriteLine(myList.GetType());
            var OrderedCars = myList.OrderByDescending(p => p.Year);
            Console.WriteLine(OrderedCars.GetType());

            var Gms = myList.Where(p => p.Make == "GM" && p.Year == 2017);
            Console.WriteLine(Gms.GetType());

            var newCars = from car in myList
                      where car.Make == "GM"
                      && car.Year == 2017
                      select new {car.Make, car.Model };
            Console.WriteLine(newCars.GetType());

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Title = "Otávio Augusto";
            b1.Author = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";
            */

            /*
            //ArrayLists are dynamically sized, 
            //cool features sorting, remove items

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            // List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);       
            }
            */

            /*
            // Dictionary <TKey, Tvalue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);
            */

            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            //Object Initializer
            //No need for a constructor
            //Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
            //Car car2 = new Car() { Make = "GM", Model = "Cruze", VIN = "D4" };

            //Collection initializer
            List<Car> myList = new List<Car>()
            {
                new Car { Make = "BMW", Model = "750li", VIN = "C3" },
                new Car { Make = "GM", Model = "Cruze", VIN = "D4" }
            };

            foreach (Car car in myList)
            {
                Console.WriteLine(car.VIN);
            }




            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}

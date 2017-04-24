using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();

            //myCar.Make = "Oldmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Color = "Silver";
            myCar.Year = 1986;

            Console.WriteLine("{0} {1} {2} {3}"
                , myCar.Make
                , myCar.Model
                , myCar.Color
                , myCar.Year);

            Car myOthercar = new Car("Ford", "Focus", "Black", 2017);
            Console.WriteLine("{0} {1} {2} {3}"
                , myOthercar.Make
                , myOthercar.Model
                , myOthercar.Color
                , myOthercar.Year);

        }
    }
    
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Car()        //Constructor(serve para colocar o objeto num estado válido, para poder ser usado assim que uma nova instância for criada)
        {
            //Você pode carregar as informações de um arquivo de configuração
            //de um Database, etc.
            Make = "Nissan";
        }

        public Car(string make, string model, string color, int year) //Constructor sobrecarregado
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
        }

        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
        }
    }
}

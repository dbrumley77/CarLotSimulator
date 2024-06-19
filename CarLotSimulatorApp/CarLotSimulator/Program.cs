using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot lot1 = new CarLot();
            


            //dot notation         default constructor
            Car car1 = new Car();
            car1.Make = "BMW";
            car1.Model = "X2";
            car1.Year = 2025;
            car1.EngineNoise = "brr";
            car1.HonkNoise = "honk honk!";
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise();
            lot1.CarList.Add(car1);
            Console.WriteLine();
            


            //Custom Constructor
            Car car2 = new Car(2024, "Mercedes", "Fancy Model");
            car2.MakeEngineNoise("mooooo");
            car2.MakeHonkNoise();
            lot1.CarList.Add(car2);
            Console.WriteLine();
            

            //object initilzer syntax
            //List<int> list = new List<int>() {1, 2, 3};
            List<int> list = new List<int>() { 1, 2, 3, };
            Car car3 = new Car() { Make = "Ford", Model = "150", Year = 2025 };

            car3.MakeEngineNoise("LOUD ENGINE");
            car3.MakeHonkNoise();
            lot1.CarList.Add(car3);
            Console.WriteLine();
            



            foreach (Car item in lot1.CarList)
            {
                Console.WriteLine($"Year: {item.Year}");
                Console.WriteLine($"Make: {item.Make}");
                Console.WriteLine($"Model: {item.Model}");
            }

            Console.WriteLine();
            
            



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}

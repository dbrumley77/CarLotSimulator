using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    class Cars
    {
        public int Year { set; get; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; } = "Honk Honk!";
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine($"The {Make}'s engine noise sounds like this: {noise}");
        }public void MakeHonkNoise()
        {
            Console.WriteLine($"The {Make}'s honk noise sounds like this {HonkNoise}");
        }

        public Cars()
        {

        }
        public Cars(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }
    }



 }





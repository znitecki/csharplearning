using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Types
{
    class Car
    {
        // https://stackify.com/learn-c-sharp-tutorials/
        public Car(string model, string color, int productionYear)
        {
            Model = model;
            Color = color;
            ProductionYear = productionYear;
        }

        public string Model { get ; set; }
        public string Color { get; set; }
        public int ProductionYear { get; set; }
        
    }

    class SuperCar : Car
    {

        public SuperCar(string model, string color, int productionYear, int power) : base(model, color, productionYear)
        {
            Power = power;
        }

        public int Power { get; set; }
 
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Types.SuperCar("Maseratti", "Red", 1998, 550);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Color);
            Console.WriteLine(car.ProductionYear);
            Console.WriteLine(car.Power);
            var odbyt = "odbyt";
            Console.WriteLine(value: odbyt);
            Console.WriteLine(odbyt);
            Console.WriteLine(odbyt.ToString());

            int i = 100;
            Console.WriteLine(i);
            ChangeValue(i);
            Console.WriteLine(i);

            Student std1 = new Student
            {
                StudentName = "Bill"
            };
            Console.WriteLine(std1.StudentName);
            ChangeReferenceType(std1);
            Console.WriteLine(std1.StudentName);

            Console.ReadKey();
        }

        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }

        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }
    }

}


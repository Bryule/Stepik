using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik
{
    class Car
    {
        public string Name;
        public int HorsePower;
        public int Age;
        public float MaxSpeed;

        public Car(string name, int horsePower, int age, float maxSpeed)
        {
            Name = name;
            HorsePower = horsePower;
            Age = age;
            MaxSpeed = maxSpeed;
        }
        public void ShowTechnicalPasport()
        {
            Console.WriteLine($"Название авто: {Name}, л/c {HorsePower}, " +
                $"возраст {Age}, максимальная скорость {MaxSpeed}");
        }

        public void BecomeOlder(int years, int runAwayHorses)
        {
            Age += years;
            HorsePower -= runAwayHorses;
        }



        // Для Main
        //Car ferrari = new Car("F40", 320, 30, 317.0f);


        //ferrari.ShowTechnicalPasport();

        //    ferrari.BecomeOlder(5, 50);

        //    Console.WriteLine();

        //    ferrari.ShowTechnicalPasport();
    }
}

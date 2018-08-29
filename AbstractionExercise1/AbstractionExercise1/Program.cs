using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceStation DeathStar1 = new DeathStar(); //instantiating
            Console.WriteLine(DeathStar1.FireLaser()); //calling method with instance
        }
    }
}

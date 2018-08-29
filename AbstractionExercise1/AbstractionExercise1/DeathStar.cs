using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExercise1
{
    class DeathStar : SpaceStation
    {
        public override string FireLaser() //modifying the FireLaser method. This method is also public for access.
        {
            return "Pew pew"; //returning string
        }
    }
}

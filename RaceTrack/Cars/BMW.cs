using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class BMW : RaceCar
    {
        public BMW()
        {
            Name = "BMW";
            TopSpeed = 90;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} revs it's engine!");
        }
        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} stops it's engine");
        }
    }
}
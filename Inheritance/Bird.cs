using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public string BirdType { get; set; }
        public string BeakShape { get; set; }
        public string FeatherColor { get; set; }
        public static void EatWorm()
        {
            Console.WriteLine("eat a worm from the ground");
        }
    }

    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string ReptileType { get; set; }
        public bool IsColdBlooded { get; set; }
        public string ScaleColor { get; set; }
        public static void SunBathe()
        {
            Console.WriteLine($"The reptile got up on a rock and soaked up the sun to stay warm.");
        }
        
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public bool IsHuman { get; set; }
        public bool IsLiving { get; set; }
        public int NumberOfLegs { get; set; }
        public static void MoveAround()
        {
            Console.WriteLine("The animal has moved");
        }
    }
    
    
    
    // TODO Be sure to follow best practice when creating your classes

    // Create a class Animal
    // give this class 4 members that all Animals have in common
        
}

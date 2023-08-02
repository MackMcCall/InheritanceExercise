using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird crow = new Bird();
            crow.BirdType = "crow";
            crow.FeatherColor = "black";
            crow.BeakShape = "long and pointy";

            Console.Write($"The skies were clear and the {crow.BirdType} flapped it's {crow.FeatherColor} wings. It then used its {crow.BeakShape} beak to ");
            Bird.EatWorm();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile beardedDragon = new Reptile();
            beardedDragon.ReptileType = "bearded dragon";
            beardedDragon.ScaleColor = "brown";
            beardedDragon.IsColdBlooded = true;

            Console.WriteLine($"It was a hot, dry day in the desert. The {beardedDragon.ReptileType} could be seen with its {beardedDragon.ScaleColor} scales.");
            Console.WriteLine($"Since it is {beardedDragon.IsColdBlooded} that the {beardedDragon.ReptileType} is cold blooded ");
            Reptile.SunBathe();
        }
    }
}

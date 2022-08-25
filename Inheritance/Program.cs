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
            var bird = new Bird
            {
                WingSpan = 6,
                TypeOfBird = "Blad Eagle",
                Flies = true,
                Size = "Large",
                Claws = true,
                FeatherColor = "White and dark brown",
                Domesticated = false,
                Legs = 2,
                Tail = true
            };
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var reptile = new Reptile
            {
                Fangs = false,
                Claws = true,
                Aquatic = true,
                ReptileType = "Crocodile",
                Scales = true,
                Legs = 4,
                Domesticated = false,
                Size = "Large",
                Tail = true
            };
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            System.Console.WriteLine($"Atributes of a { bird.TypeOfBird} they have a wingspan of {bird.WingSpan}FT its color of feathers is {bird.FeatherColor} it has {bird.Legs} legs " +
                $"does it fly? {bird.Flies} is it domesticated? {bird.Domesticated} in most cases. It is a {bird.Size}, bird does it have a tail {bird.Tail}, does it have claws {bird.Claws}");
            System.Console.WriteLine($"Atributes of a {reptile.ReptileType} they it has {bird.Legs} legs,do they have scales {reptile.Scales} is it an aquatic animal {reptile.Aquatic}  " +
                $"does it have fangs? {reptile.Fangs} is it domesticated? {reptile.Domesticated}, It is a {reptile.Size} sized reptile. does it have a tail {reptile.Tail}, does it have claws {reptile.Claws}");
        }
    }
}

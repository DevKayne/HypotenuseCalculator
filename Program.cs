using System;

namespace HypotenuseCalculator
{
    class HypotenuseCalculator
    {
        static void Main(string[] args)
        {
            // First Two Lines
            Console.WriteLine("Hypotenuse Calculator");
            Console.WriteLine("Enter Side A:");

            // Read Side A and Save it to a Variable
            double SideA = Convert.ToDouble(Console.ReadLine());

            // Side B
            Console.WriteLine("Enter Side B:");
            double SideB = Convert.ToDouble(Console.ReadLine());

            // Calculations
            double answer = Math.Round(Math.Sqrt(SideA * SideA + SideB * SideB));

            // Answer
            Console.WriteLine("The Hypotenuse is equal to: " + answer);

            // Exit with Key
            Console.WriteLine("Press ~Any~ Key to Exit.");
            Console.ReadKey();
        }
    }
}
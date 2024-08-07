using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Linear Equation Resolver");
        Console.WriteLine("Given an equation as 'a * x + b = 0', please enter constants:");

        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a != 0)
        {
            double solution = -b / a;
            Console.WriteLine("The solution is: {0}!", solution);
        }
        else
        {
            if (b == 0)
            {
                Console.WriteLine("The solution is all x!");
            }
            else
            {
                Console.WriteLine("No solution!");
            }
        }
    }
}
using System;


class p331
{
    static void Main(string[] args)
    {
        double height;
        double weight;
        double BMI;

        Console.Write("Please enter your height in inches: ");
        // get the user's value and put it  in  variable called heightInInches
        weight = Double.Parse(Console.ReadLine());


        Console.Write("Please enter your weight in pounds: ");
        height = Double.Parse(Console.ReadLine());


        BMI = (weight * 703) / (height * height);
        Console.Write("\nYour BMI is: ");
        Console.WriteLine(BMI);

        Console.WriteLine("\nBMI VALUES");
        Console.WriteLine("Underweight: \t less than 16.5");
        Console.WriteLine("Normal: \t between 18.5 and 24.9");
        Console.WriteLine("Overweight: \t between 25 and 29.9");
        Console.WriteLine("Obese: \t\t 30 or greater");

        Console.ReadLine();
    }
}


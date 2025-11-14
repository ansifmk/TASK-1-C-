using System;

public class Class1
{
    public Class1()
    {
        int num1 = 20;
        int num2 = 10;

        int addition = num1 + num2;
        int subtraction = num1 - num2;
        int multiplication = num1 * num2;
        double division = (double)num1 / num2;

        Console.WriteLine("Addition: " + addition);
        Console.WriteLine("Subtraction: " + subtraction);
        Console.WriteLine("Multiplication: " + multiplication);
        Console.WriteLine("Division: " + division);
    }

    public static void Main(string[] args)   
    {
        Class1 obj = new Class1();
    }
}

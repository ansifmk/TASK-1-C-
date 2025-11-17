using System;

public class Class1
{
    //task 1

    //public Class1()
    //{
    //    int num1 = 20;
    //    int num2 = 10;

    //    int addition = num1 + num2;
    //    int subtraction = num1 - num2;
    //    int multiplication = num1 * num2;
    //    double division = (double)num1 / num2;

    //    Console.WriteLine("Addition: " + addition);
    //    Console.WriteLine("Subtraction: " + subtraction);
    //    Console.WriteLine("Multiplication: " + multiplication);
    //    Console.WriteLine("Division: " + division);
    //}

    //public static void Main(string[] args)   
    //{
    //    Class1 obj = new Class1();
    //}






    //task 2 -1qst

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("enter a number: ");
    //    int number = Convert.ToInt32(Console.ReadLine());

    //    if (number % 2 == 0)
    //    { 
    //    Console.WriteLine("The number is even.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The number is odd.");
    //    }
    //}



    //task 3 -2qst
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("enter a number");
    //    int number = Convert.ToInt32(Console.ReadLine());

    //    if (number > 0) { 
    //    Console.WriteLine("The number is positive.");
    //    }
    //    else if (number < 0)
    //    {
    //        Console.WriteLine("The number is negative.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The number is zero.");
    //    }

    //}


    //Task 4 -3qst

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("enter a number: ");
    //    int num1 = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine("enter second number: ");
    //    int num2 = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine("enter third number: ");
    //    int num3 = Convert.ToInt32(Console.ReadLine());

    //    if (num1 >= num2 && num1 >= num3)
    //    {
    //        Console.WriteLine(num1 + " is the largest number . ");
    //    }
    //    else if (num2 >= num1 && num2 >= num3)
    //    {
    //        Console.WriteLine(num2 + " is the largest number . ");
    //    }
    //    else
    //    {
    //        Console.WriteLine(num3 + " is the largest number . ");
    //        {

    //        }
    //    }
    //}



    //task 5 -4qst

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("enter a year: ");
    //    int year = Convert.ToInt32(Console.ReadLine());
    //    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    //    {
    //        Console.WriteLine(year + " is a leap year.");
    //    }
    //    else
    //    {
    //        Console.WriteLine(year + " is not a leap year.");
    //    }
    //}


    //task 6 -5qst

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("enter a mark: ");
    //    int mark=Convert.ToInt32(Console.ReadLine());

    //    if(mark >=90 && mark <=100)
    //    {
    //        Console.WriteLine("grade s");
    //    }
    //    else if(mark >=80 && mark <90)
    //    {
    //        Console.WriteLine("grade a");
    //    }
    //    else if(mark >=70 && mark <80)
    //    {
    //        Console.WriteLine("grade b");
    //    }
    //    else if(mark >=60 && mark <70)
    //    {
    //        Console.WriteLine("grade c");
    //    }
    //    else if(mark >=50 && mark <60)
    //    {
    //        Console.WriteLine("grade d");
    //    }
    //    else if(mark >=40 && mark <50)
    //    {
    //        Console.WriteLine("grade e");
    //    }
    //    else if(mark >=0 && mark <40)
    //    {
    //        Console.WriteLine("grade f");
    //    }
    //    else
    //    {

    //    }
    //}


    //task 2 scnd page - 1qst

    //static void Main(string[] args)
    //{
    //    int rows = 5;
    //    int space = rows - 1;

    //    for (int i = 1; i <= rows; i++)
    //    {
    //        for (int j = 1; j <= space; j++)
    //        {
    //            Console.Write(" ");
    //        }
    //        for (int k = 1; k <= (2 * i - 1); k++)
    //        {
    //            Console.Write("*");
    //        }
    //        Console.WriteLine();
    //        space--;
    //    }
    //}


    //task 2 scnd page - 2qst

    //static void Main(string[] args)
    //{
    //    int n = 5;

    //    for (int i = n; i >= 1; i--)
    //    {
    //        for (int j = i; j < n; j++)
    //        {
    //            Console.Write(" ");
    //        }

    //        for (int j = 1; j <= (2 * i - 1); j++)
    //        {
    //            if (i == n || j == 1 || j == (2 * i - 1))
    //            {
    //                Console.Write("*");
    //            }
    //            else
    //            {
    //                Console.Write(" ");
    //            }
    //        }

    //        Console.WriteLine();
    //    }
    //}




    //task 2 scnd page - 3qst
    //static void Main(string[] args)
    //{
    //    for (int i=0; i < 5; i++) { 
    //    char ch = 'A';
    //        for (int j=0; j <= i; j++)
    //        {
    //            Console.Write(ch + " ");
    //            ch++;
    //        }
    //        Console.WriteLine();
    //    }
    //}


    //task 2 scnd page - 4qst

    //static void Main(string[] args)
    //{
    //    int num = 1;

    //    for (int i = 1; i <= 4; i++)
    //    {
    //        for (int j = 1; j <= i; j++)
    //        {
    //            Console.Write(num + " ");
    //            num++;
    //            if (num > 9) { 
    //                num = 1;
    //            }
    //        }
    //        Console.WriteLine();
    //    }
    //}



    //task 2 scnd page - 5qst

    //static void Main(string[] args)
    //{
    //    int rows = 5;
    //    for (int i = 1; i <= rows; i++) { 
    //    for(int s = 1; s <= rows - i; s++)
    //        {
    //            Console.Write(" ");
    //        }
    //    for (int num = 1; num <= (2 * i - 1); num++)
    //        {
    //            Console.Write(num);
    //        }
    //    Console.WriteLine();
    //    }
    //}






    // task day 2 prime number
    //static void Main(string[] args)
    //{
    //    {
    //        Console.Write("Enter a number: ");
    //        int num = int.Parse(Console.ReadLine());

    //        bool isPrime = true;

    //        if (num <= 1)
    //        {
    //            isPrime = false;
    //        }
    //        else
    //        {
    //            for (int i = 2; i <= num / 2; i++)
    //            {
    //                if (num % i == 0)
    //                {
    //                    isPrime = false;
    //                    break;
    //                }
    //            }
    //        }

    //        if (isPrime)
    //            Console.WriteLine(num + " is a Prime Number");
    //        else
    //            Console.WriteLine(num + " is NOT a Prime Number");
    //    }
    //}




    //task day 2 - pattern qst 1
    //static void Main(string[] args)
    //{
    //    int n = 4;

    //    for(int i = 1; i < n; i++)
    //    {
    //        for(int j=i; j < n; j++)

    //            Console.Write(" ");
    //        for(int j=1; j<=(2*i-1);j++)
    //            Console.Write("*");

    //        Console.WriteLine();
    //    }
    //    for(int i=n-1; i>=1; i--)
    //    {
    //        for(int j=i; j < n; j++)
    //            Console.Write(" ");
    //        for(int j=1; j<=(2*i-1);j++)
    //            Console.Write("*");
    //        Console.WriteLine();
    //    }
    //}



    class Animal
    {
        public string name;
        public int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Speak()
        {
            Console.WriteLine($"My name is {name} and I am {age} years old.");
        }
    }

    class Dog : Animal
    {
        public string breed;

        public Dog(string name, int age, string breed) : base(name, age)
        {
            this.breed = breed;
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public void Meow()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Rocky", 3, "Labrador");
            Cat cat = new Cat("Kitty", 2);

            dog.Speak();
            cat.Speak();
            cat.Meow();

            Console.ReadLine();
        }
    }
}


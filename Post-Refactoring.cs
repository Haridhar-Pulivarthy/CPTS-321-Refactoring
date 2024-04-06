using System;

class Program
{
    static void Main(string[] args)
    {
        // Code after refactoring.
        
        // The variable 'result' is removed
        Console.WriteLine("(Inline Variable) Sum: ", Add(5, 3));
        
        // Extract Variable: Parameter '5/2' is extracted into variables diameter and radius
        double diameter = 5;
        double radius = diameter / 2;
	    double area = CalculateAreaOfCircle(radius);
        Console.WriteLine("(Extract Variable) Area: ", area);
        
        // Remove Middle Man: Let's remove the middle man 'Add' function and do the operation directly
        int directResult = 5 + 3;
        Console.WriteLine("(Remove Middle Man) Sum: ", directResult);
        
        // Parameterize Function: Let's parameterize the 'Calculate' function to accept the operation as a parameter
        int parameterizedResult = CalculateWithOperation(5, 3, OperationType.Addition);
        Console.WriteLine("(Parameterize Function) Sum: ", parameterizedResult);
        
        // Replace Exception with Precheck: Let's replace the exception with a pre-check to avoid exceptions
        int precheckResult = SafeDivide(5, 0);
        Console.WriteLine("(Replace Exception w/ Precheck) Quotient: ", badResult);
        
        // Replace Conditional with Polymorphism: Let's replace the conditional logic with polymorphic behavior
        Animal cat = new Cat();
        Animal dog = new Dog();
        Console.WriteLine(cat.Sound());
        Console.WriteLine(dog.Sound());
    }

    // Original methods

    // Can use expression body for method
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int SafeDivide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return -1; // Return some default value instead of throwing an exception
        }
        return a / b;
    }

    const PI = 3.14;
    static double CalculateAreaOfCircle(int radius)
    {
        return PI * Math.Pow(radius, 2);  // Replace Magic Literal: Magic number 3.14 should be replaced with a named constant.
    }

    enum OperationType
    {
        Addition,
        Subtraction
    }

    static int CalculateWithOperation(int a, int b, OperationType operation)
    {
        switch (operation)
        {
            case OperationType.Addition:
                return a + b;
            case OperationType.Subtraction:
                return a - b;
            default:
                throw new ArgumentException("Invalid operation");
        }
    }

    // Polymorphism example
    abstract class Animal
    {
        // Can replace Sound with property
        public abstract string Sound();
    }

    class Cat : Animal
    {
        public override string Sound()
        {
            return "Meow";
        }
    }

    class Dog : Animal
    {
        public override string Sound()
        {
            return "Woof";
        }
    }
}
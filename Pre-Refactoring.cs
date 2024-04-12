using System;

class Program
{
    static void Main(string[] args)
    {
        // Original code with some issues and opportunities for refactoring
        
        // Inline Variable: Let's inline the variable 'result'
        int result = Add(5, 3);
        Console.WriteLine("(Inline Variable) Sum: ", result);
        
        // Extract Variable: Let's extract the parameter '5/2' (Opposite refactoring)
        var foo = 5/2;
        double area = CalculateAreaOfCircle(foo);
        Console.WriteLine("(Extract Variable) Area: ", area);
        
        // Remove Middle Man: Let's remove the middle man 'Add' function and add the parameters directly
        int directResult = Add(5, 3);
        Console.WriteLine("(Remove Middle Man) Sum: ", directResult);
        
        // Parameterize Function: Let's parameterize the 'Calculate' function to accept the operation as a parameter
        int parameterizedResult = CalculateWithOperation(5, 3, OperationType.Addition);
        Console.WriteLine("(Parameterize Function) Sum: ", parameterizedResult);
        
        // Replace Exception with Precheck: Let's replace the exception with a pre-check to avoid exceptions
        int badResult = Divide(5, 0);
        Console.WriteLine("(Replace Exception w/ Precheck) Quotient: ", badResult);
        
        // Replace Conditional with Polymorphism: Let's replace the conditional logic with polymorphic behavior
        Animal cat = new Cat();
        Animal dog = new Dog();
        Console.WriteLine(GetSound(cat));
        Console.WriteLine(GetSound(dog));
    }

    // Original methods
    static int Add(int a, int b)
    {
        return a + b;
    }

    static double Divide(int a, int b)
    {
        return a / b;
    }

    static double CalculateAreaOfCircle(int radius)
    {
        return 3.14 * Math.Pow(radius, 2);  // Replace Magic Literal: Magic number 3.14 should be replaced with a named constant.
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

    // Conditional Logic Example
    enum AnimalType
    {
        Cat,
        Dog
    }

    static string GetSound(Animal animal)
    {
        switch (GetAnimalType(animal))
        {
            case AnimalType.Cat:
                return "Meow";
            case AnimalType.Dog:
                return "Woof";
            default:
                throw new ArgumentException("Invalid animal type");
        }
    }

    static AnimalType GetAnimalType(Animal animal)
    {
        if (animal is Cat)
            return AnimalType.Cat;
        else if (animal is Dog)
            return AnimalType.Dog;
        else
            throw new ArgumentException("Invalid animal type");
    }
    
    // Original animal classes
    abstract class Animal
    {
    }

    class Cat : Animal
    {
    }

    class Dog : Animal
    {
    }
}
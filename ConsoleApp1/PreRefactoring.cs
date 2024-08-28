using ConsoleApp1;

namespace ClassLibrary1;


using System;

class PreRefactoring
{
    static void Main(string[] args)
    {
        // Original code with some issues and opportunities for refactoring
        
        // Inline Variable: Let's inline the variable 'result'
        Console.WriteLine($"(Inline Variable) Sum: {Add(5, 3)} ");
        
        // Introduce Variable: Let's extract the parameter '5/2' (Opposite refactoring)
        var radius = 5.0/2.0;
        double area = Circle.CalculateAreaOfCircle(radius);
        Console.WriteLine($"(Extract Variable) Area: {area} ");
        
        // Remove Middle Man: Let's remove the middle man 'AddTwoNumbers' function and add the parameters directly
        // Original method with a middleman 'Add' function
        int Add(int a, int b)
        {
            return a + b; // Middleman function call
        }


        // Using Safe Delete to remove Divide Method. Review the usages detected by Rider in the confirmation dialog. 
        double badResult = Divide(5, 0);
        Console.WriteLine($"(Replace Exception w/ Precheck) Quotient: {badResult}");
        
        
    }

    // Original methods


    // Move into Circle Class

    // Push down and pull up methods
    // Base class
    class Shape
    {
        protected int width;
        protected int height;

        public Shape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }

    // Subclass
    class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height)
        {
        }

        public virtual int CalculateArea()
        {
            return width * height;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Width: {width}, Height: {height}");
        }
    }
   
    
    // Extract
    class MyClass
    {
        public void DoSomething()
        {
            // Long method body
            StepUno();
            Console.WriteLine("Step 2");
            Console.WriteLine("Step 3");
        }

        private static void StepUno()
        {
            Console.WriteLine("Step 1");
        }
    }

    
}

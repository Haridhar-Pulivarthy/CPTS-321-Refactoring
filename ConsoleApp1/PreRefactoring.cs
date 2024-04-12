namespace ClassLibrary1;


using System;

class PreRefactoring
{
    static void Main(string[] args)
    {
        // Original code with some issues and opportunities for refactoring
        
        // Inline Variable: Let's inline the variable 'result'
        int result = Add(5, 3);
        Console.WriteLine($"(Inline Variable) Sum: {result} ");
        
        // Introduce Variable: Let's extract the parameter '5/2' (Opposite refactoring)
        double area = CalculateAreaOfCircle(5.0/2.0);
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
    static double Divide(int a, int b)
    {
        return a / b;
    }
    

    // Move into Circle Class
    static double CalculateAreaOfCircle(double radius)
    {
        return 3.14 * Math.Pow(radius,2);  // Replace Magic Literal: Magic number 3.14 should be replaced with a named constant.
    }
    
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

        public virtual int CalculateArea()
        {
            return width * height;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Width: {width}, Height: {height}");
        }
    }

    // Subclass
    class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height)
        {
        }
        
    }
   
    
    // Extract
    class MyClass
    {
        public void DoSomething()
        {
            // Long method body
            Console.WriteLine("Step 1");
            Console.WriteLine("Step 2");
            Console.WriteLine("Step 3");
        }

        
    }
}

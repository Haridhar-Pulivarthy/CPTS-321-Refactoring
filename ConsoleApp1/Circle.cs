namespace ConsoleApp1;

public class Circle
{
    public static double CalculateAreaOfCircle(double radius)
    {
        var PI = 3.14;
        return PI * Math.Pow(radius,2);  // Replace Magic Literal: Magic number 3.14 should be replaced with a named constant.
    }
}
using System;
namespace task08dec
{
    public class methodPractice
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine(add(65.26,56.23));
            Console.WriteLine(add(5, 6));
            add("kuldeep", "singh");
        }
        public static int add(int x, int y)
        {
            return x + y;
        }
        public static double add(double x, double y)
        {
            return x + y;
        }
        public static void add(string x, string y)
        {
            Console.WriteLine("your first name is : " + x);
            Console.WriteLine("your last name is : " + y);
            Console.WriteLine($"your full name is : {x} {y}");
        }
    }
}
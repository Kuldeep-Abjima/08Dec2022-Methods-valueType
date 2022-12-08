using System;

namespace task08dec2022
{
    public class EmunTask
    {
        static void Main(String[] args)
        {
            //for (int i = 0; i < 7; i++)
            //{
            //    var a = (Weekdays)i;
            //    Console.WriteLine($"{a} = {i}");

            //}
            int d = (int)Weekdays.friday;
            Console.WriteLine("Index of friday"+d);


            foreach (var b in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine($"Weekdays {b} = {(int)b}");
            }
            //foreach(string i in Enum.GetNames(typeof(Weekdays)))
            //{
            //    Console.WriteLine(i);
            //}
            
        }
    }
    enum Weekdays
    {
        sunday=10,
        monday = 30,
        tuesday = 40,
        wednesday = 50,
        thursday = 60,
        friday = 20,
        saturday = 45
    }
}
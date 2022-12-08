using System;
namespace methodPractice
{
    public class methodPractice
    {
        static void Main(String[] args)
        {
            int monthlyWage = 4000;
            int monthlyWage2 = 5000;
            int months = 12;
            int bonus = 1000;
            int bonus2;
            int yeralyWage = calculateYearlyWage(monthlyWage, months);
      
            Console.WriteLine($"By Method 1 \n Yearly Wage : {yeralyWage}");
            Console.WriteLine("by Method 2  \n Yearly Wage With Bonus : " + calculateYearlyWage(monthlyWage, months, bonus));
            Console.WriteLine("by method 3 \n Yearly Wage With Bonus  of 2: " + calculateYearlyWage(monthlyWage2, months, bonus));
            Console.WriteLine("by method out keyword \n yearly bonus via out Keyword :" + calculateYearlyWagesByOut(monthlyWage, months, out bonus2));

        }
        public static int calculateYearlyWage(int monthlyWage, int numberOfMonthsWorks)
        {
            //Console.WriteLine($"Yearly Wages : {monthlyWage * numberOfMonthsWorks}");
            if(numberOfMonthsWorks == 12)
            {
                return monthlyWage * (numberOfMonthsWorks + 1);
            }
            return monthlyWage * numberOfMonthsWorks;
        }
        public static int calculateYearlyWage(int monthlyWage, int numberOfMonthsWorks, ref int bonus)
        {
            
            if (monthlyWage < 5000)
            {
                bonus = bonus * 2;
            }
            Console.WriteLine($"your bonus {bonus}");
            return monthlyWage * numberOfMonthsWorks + bonus;
        }
        public static double calculateYearlyWage(double monthlyWage, double numberOfMonthsWorks, double bonus)
        {
            return monthlyWage * numberOfMonthsWorks + bonus;
        }
        public static int calculateYearlyWagesByOut(int monthlyWage, int numberOfMonthsWorks, out int bonus)
        {
            bonus = new Random().Next(1000);
            if(bonus < 500)
            {
                bonus *= 2;
            }
            Console.WriteLine($"your bonus is : {bonus}");
            return monthlyWage * numberOfMonthsWorks + bonus;
        }

    }
}
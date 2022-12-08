using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace methodPractice
{
    public class methodPracticeUsingPrams
    {
        static void Main(String[] args)
        {
            usingprams();
            usingEumuration();
            usingAStruct();
            
        }

        private static void usingprams()
        {
            int monthlyWages1 = 1500, monthlyWages2 = 1600, monthlyWages3 = 1700, monthlyWages4 = 1800;
            int avg = CalculateAvgWages(monthlyWages1, monthlyWages2, monthlyWages3, monthlyWages4);
            Console.WriteLine($"avg wages is : {avg}");
        }
        private static int CalculateAvgWages(params int[] wages )
        {
            int total  = 0;
            int numberOfWages = wages.Length;
            for(int i = 0; i< numberOfWages; i++)
            {
                total += wages[i];
            }
            return total/numberOfWages;
        }
        private static void usingEumuration()
        {
            EmployeeType employeeType = EmployeeType.sales;
            Storetype storetype = Storetype.pie;
            int baseWage = 1000;
            enumWageMethod(baseWage, employeeType, storetype);

        }
        private static void  enumWageMethod(int baseWage, EmployeeType employeeType, Storetype storetype)
        {
            int calculatedWage = 0;
            if (employeeType == EmployeeType.sales)
            {
                calculatedWage = baseWage * 3;
            }
            else
            {
                calculatedWage *= 3;
            }
            if(storetype == Storetype.pie)
            {
                calculatedWage += 500;

            }
            Console.WriteLine($"wage : {calculatedWage}");
        }
        private static void usingAStruct()
        {
            employee employee;
            employee.name = "bethnay";
            employee.wage = 82220;
            employee.work();
        }
    }
    enum EmployeeType
    {
        sales,
        manger,
        research,
        StoreManger

    }
    enum Storetype
    {
        pie = 10,
        piediwpie = 20,
        seating = 100,
        undefine = 200
    }
    struct employee{
        public string name;
        public int wage;
        public void work()
        {
            Console.WriteLine($"{name} is working with us");
        }
    }
}
using System;

namespace birth_age
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            int year = today.Year;
            int age = 0;
            Console.WriteLine("enter your age ");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("your age =  " + age);
            int birth = year - age;
            Console.WriteLine("your birth =  " + birth);
        }
    }
}

using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;
            int max_heart_rate;
            // Max Heart rate is 220 - age

            age = 26;
            height = 6;
            max_heart_rate = 220 - age;

            Console.WriteLine("I am " +age+ " years old , my max heart rate is " +max_heart_rate+ " and I am " +height+ " feets tall");
            Console.ReadLine();
        }
    }
}

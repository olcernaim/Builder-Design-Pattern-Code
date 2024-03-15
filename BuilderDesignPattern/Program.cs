using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person per1 = new Person("Naim", "Ölçer", 12);

            //per1.Print();

            //Person per2 = new Person(123, "12345", 12);

            //per2.Print();

            //Person per3 = new Person("Naim", "Ölçer", 12, 12345, "12345");

            //per3.Print();

            Person person1 = new PersonBuilder().SetName("Naim").SetSurname("Ölçer").SetAge(12).Build();

            person1.Print();

            Person person2 = new PersonBuilder().SetAge(12).SetPhone(123).SetCitNo("12312412").Build();

            person2.Print();

            Person person3 = new PersonBuilder().SetName("Naim").SetSurname("Ölçer").SetAge(12).SetPhone(12345).SetCitNo("12345").Build();

            //Console.WriteLine("Hello World!");
        }
    }
}

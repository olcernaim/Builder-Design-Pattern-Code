using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public int phone { get; set; }
        public string addresss { get; set; }
        public string citno { get; set; }

        public Person() { }

        //public Person(string nameinput, string surnameinput, int ageinput)
        //{
        //    name = nameinput;
        //    surname = surnameinput;
        //    age = ageinput;
        //}

        //public Person(int phoneinput, string citnoinput, int ageinput)
        //{
        //    phone = phoneinput;
        //    citno = citnoinput;
        //    age = ageinput;
        //}

        //public Person(string nameinput, string surnameinput, int ageinput, int phoneinput, string citnoinput)
        //{
        //    name = nameinput;
        //    surname = surnameinput;
        //    age = ageinput;
        //    phone = phoneinput;
        //    citno = citnoinput;
        //}

        public void Print()
        {
            Console.WriteLine("name is : " + name);
            Console.WriteLine("surname is : " + surname);
            Console.WriteLine("age is : " + age);
            Console.WriteLine("phone is : " + phone);
            Console.WriteLine("addresss is : " + addresss);
            Console.WriteLine("citno is : " + citno);
        }

    }

    public class PersonBuilder
    {
        private Person _person = new Person();

        public PersonBuilder SetName(string nameinput)
        {
            _person.name = nameinput;
            return this;
        }
        public PersonBuilder SetSurname(string surnameinput)
        {
            _person.surname = surnameinput;
            return this;
        }
        public PersonBuilder SetCitNo(string citnoinput)
        {
            _person.citno = citnoinput;
            return this;
        }
        public PersonBuilder SetAge(int ageinput)
        {
            _person.age = ageinput;
            return this;
        }
        public PersonBuilder SetPhone(int phoneinput)
        {
            _person.phone = phoneinput;
            return this;
        }
        public PersonBuilder SetAddress(string adressinput)
        {
            _person.addresss = adressinput;
            return this;
        }

        public Person Build()
        {
            return _person;
        }
    }
}

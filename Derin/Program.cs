using System;

namespace Derin
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Customer customer = new Customer();
            Employee employee = new Employee();

            person1.PersonName = "CAN";
            person2 = person1;
            person1.PersonName = "JEAN";
            Console.WriteLine(person2.PersonName);


            PersonManger personManger = new PersonManger();
            personManger.Ekle(person1);
        }

    }

    class Person
    {
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public int Id { get; set; }
    }
    class Customer:Person
    {
        public int Tel { get; set; }
    }
    class Employee:Person
    {
        public int CreditCards { get; set; }
    }
    class PersonManger
    {
        public void Ekle(Person person)
        {
            Console.WriteLine(person.PersonName);
        }

    }
}

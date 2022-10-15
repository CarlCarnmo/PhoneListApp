using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Xml.Linq;

namespace PhoneListApp
{
    class Person //PERSON OBJECT
    {
        string fname;
        string lname;
        string address;
        int nr;
        public Person(string Fname, string Lname, string Address, int Nr)
        {
            this.fname = Fname;
            this.lname = Lname;
            this.address = Address;
            this.nr = Nr;
        }
        public void Print()
        {
            Console.WriteLine($"First Name: {fname}\nLast Name: {lname}\nAddress: {address}\nPhoneNumber: {nr}");
        }
        public static void PrintList(List<Person> list)
        {
            /*foreach (Person person in list)
            {
                person.Print();
            }*/
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{i}: ");
                list[i].Print();
                Console.WriteLine("----------------------------------------------------------");
            }
        }
        public static void RemovePerson(List<Person> list)
        {
            Console.WriteLine("Who you want to remove from the list: ");
            int num = Convert.ToInt32(Console.ReadLine());
            list.RemoveAt(num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till telefonlistan.");
            Console.WriteLine("Skriv 'hjälp' för hjälp!");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Remove");
            Console.WriteLine("3. Print List");
            Console.WriteLine("4. Exit");
            string command;
            List<Person> list = new List<Person>();
            do
            {
                Console.Write("Kommando: ");
                command = Console.ReadLine();
                switch (command)
                {
                    case "hjälp":
                        Console.WriteLine($"Shit is fucked.");
                        break;
                    case "1":
                        Console.Clear();
                        list = MakeList();
                        Person.PrintList(list);
                        break;
                    case "2":
                        Console.Clear();
                        Person.PrintList(list);
                        Person.RemovePerson(list);
                        break;
                    case "3":
                        Console.Clear();
                        Person.PrintList(list);
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                }
            } while (command != "4");
            Console.WriteLine("Hej då!");
        }
        public static List<Person> MakeList()
        {
            Console.WriteLine("How many people(max 10): ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount > 10 && amount < 1) { Console.WriteLine("Thats not cool."); }
            List<Person> list = new List<Person>();
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Name: ");
                string Fname = Console.ReadLine();
                Console.WriteLine($"Last Name: ");
                string Lname = Console.ReadLine();
                Console.WriteLine($"Address: ");
                string Address = Console.ReadLine();
                Console.WriteLine($"PhoneNumber: ");
                int Nr = Convert.ToInt32(Console.ReadLine());
                list.Add(new Person(Fname, Lname, Address, Nr));
            }
            return list;
        }

    }
}
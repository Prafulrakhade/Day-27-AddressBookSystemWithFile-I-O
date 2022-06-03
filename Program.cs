using System;
using Newtonsoft.Json;

namespace AddressBookProblemWithJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Problem with JSON \n\n");
            AddressBook manager = new AddressBook();

            //Infinite Loop
            while (true)
            {
                Console.WriteLine("\nPlease Select any one Operation: ");
                Console.WriteLine("1: To add Details to Address Book");
                Console.WriteLine("2: To Display All Contacts of Address Book");
                Console.WriteLine("3: To Exit");
                int read = int.Parse(Console.ReadLine());
                switch (read)
                {
                    //For Adding Details to Address Book
                    case 1:
                        {
                            Person person = new Person();
                            Console.WriteLine("Enter First Name: ");
                            string fname = Console.ReadLine();
                            person.FName = fname;
                            Console.WriteLine("Enter Last Name: ");
                            string lname = Console.ReadLine();
                            person.LName = lname;
                            Console.WriteLine("Enter Address: ");
                            string address = Console.ReadLine();
                            person.Address = address;
                            Console.WriteLine("Enter Phone Number: ");
                            long number = long.Parse(Console.ReadLine());
                            person.PhoneNumber = number;
                            manager.addPerson(person);
                        }
                        break;
                    //Display contact list of addressbook
                    case 2:
                        {
                            manager.Display();
                        }
                        break;
                        //for exit from infinite loop
                    case 3:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Please Select any one operation ");
                        }
                        break;
                }
            }
        }
    }
}

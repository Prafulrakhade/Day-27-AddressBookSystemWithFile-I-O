using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AddressBookSystem_File_I_O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\HP\Bridgelabz-145\Assignments_\Day 27\AddressBookSystem_File_I_O\AddressBookSystem_File_I_O\Records.txt";
            InputPerson input = new InputPerson();
            //Getting details from user
            Console.WriteLine("\nEnter your First Name : ");
            input.fName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            input.lName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            input.address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            input.city = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            input.state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            input.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            input.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            input.email = Console.ReadLine();

            FileIO.WriteRecordsInFile(path, input); // Writing records into file
            Console.WriteLine("\n\nRecords present in file are : ");
            FileIO.ReadRecordsFromFile(path); // Reading all records from file 
        }
    }
}

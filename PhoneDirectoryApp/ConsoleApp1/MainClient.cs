using System;
using System.Collections.Generic;
using System.Text;
using PhoneDirectoryApp;
using PhoneDirectoryLibrary;

namespace PhoneDirectoryClient
{
    class MainClient
    {
        static void Main(string[] args)
        {
            bool flag = false;

            ContactManager manager = new ContactManager();
            do
            {
                Console.WriteLine($"What would you like to do?");
                Console.WriteLine($"Enter 'N' to quit. ");
                Console.WriteLine($"1: Load a directory. ");
                Console.WriteLine($"2: Add contact to the directory. ");
                Console.WriteLine($"3: Delete a contact from the directory. ");
                Console.WriteLine($"4: Search for a contact. ");
                Console.WriteLine($"5: Print the current directory. ");
                Console.WriteLine($"6: Update a contact's information. ");
                string feedback = Console.ReadLine();
                if (feedback.Contains("1")) { manager.READ(); }
                if (feedback.Contains("2")) { manager.ADD(manager.CREATE()); }
                if (feedback.Contains("3")) { manager.DELETE(); }
                if (feedback.Contains("4")) { Console.WriteLine(manager.SEARCH().Print); }
                if (feedback.Contains("5")) { manager.PRINT(); }
                if (feedback.Contains("6")) { }
                if (feedback.Contains("N") || feedback.Contains("n")) { flag = true; }
            } while (flag == false); 
        }
    }
}


/*

            string temp = System.IO.File.ReadAllText("C:\\Users\\mexic\\Documents\\temp\\file2.txt");
            System.Web.Script.Serialization.JavaScriptSerializer deserializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            Contact cont = deserializer.Deserialize<Contact>(temp); 
            Console.WriteLine(temp);
            Console.WriteLine(cont.Print());

*/
using PhoneDirectoryApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization; 


namespace PhoneDirectoryLibrary
{
    public class ContactManager
    {
        //
        private List<ContactEntry> phonedir;

        //Default constructor. Initializes the List of ContactEntries for a PhoneDirectory. 
        public ContactManager() { phonedir = new List<ContactEntry>(); }

        //PRINTS the contents of the PhoneDirectory in the right order. 
        public void PRINT() { foreach (ContactEntry cont in phonedir) { Console.WriteLine(cont.Print + "\n"); } }

        //READS a PhoneDirectory from file. 
        public void READ() { StartDeserialization(); }

        //CREATES a new Contact type object. 
        public Contact CREATE() { return new Contact(); }

        //ADDS a ContactEntry to the PhoneDirectory using a Contact
        public void ADD(Contact cont) 
        {
            DirectoryEntry(cont); 
            StartSerialization(); 
        }

        //DELETS a ContactEntry from the PhoneDirectory by using its ID Number. 
        public void DELETE()
        {
            Console.WriteLine($"Identification number of contact you'd like to erase?");
            Console.WriteLine($"Please use the SEARCH function to look up ID Numbers. ");
            string feedback = Console.ReadLine();
            short searchoption = Convert.ToInt16(feedback);

            for (int i = 0; i < phonedir.Count; i++) 
            {
                if (phonedir[i].ID == searchoption)
                {
                    Console.WriteLine($"Gotemmm ");
                    phonedir.Remove(phonedir[i]);
                    StartSerialization();
                    return;
                }
            }
        }

        //UPDATES a ContactEntry in the PhoneDirectory by using its ID Number. 
        public void UPDATE()
        {
            Console.WriteLine($"What would you like to update?");
            Console.WriteLine($"1: Name. ");
            Console.WriteLine($"2: Address. ");
            Console.WriteLine($"3: Phone number. ");
        }

        //SEARCHES for a ContactEntry in the PhoneDirectory to present their information. 
        public ContactEntry SEARCH()
        {
            Console.WriteLine($"What would you like to search by?");
            Console.WriteLine($"1: Name. ");
            Console.WriteLine($"2: Address. ");
            Console.WriteLine($"3: Phone number. ");
            string searchoption = Console.ReadLine();

            do
            {
                if (searchoption.Contains("1"))
                {
                    return SearchByName();
                }
                if (searchoption.Contains("2"))
                {
                    return SearchByAddress();
                }
                if (searchoption.Contains("3"))
                {
                    return SearchByPhone();
                }
                else
                {
                    Console.WriteLine($"Hm. That Doesn't seem right. Try again: ");
                    searchoption = Console.ReadLine();
                }
            } while (true); //Flag might be better. 
        }


        private ContactEntry SearchByName()
        {
            Console.WriteLine($"What would you like to search for?");
            string feedback = Console.ReadLine(); 
            foreach (ContactEntry entry in phonedir)
            {
                if (entry.Name.Contains(feedback))
                {
                    Console.WriteLine($"Gotemmm ");
                    return entry;
                }
            }
            return null;
        }

        private ContactEntry SearchByAddress()
        {
            Console.WriteLine($"What would you like to search for?");
            string feedback = Console.ReadLine();
            foreach (ContactEntry entry in phonedir)
            {
                if (entry.Address.Contains(feedback))
                {
                    Console.WriteLine($"Gotemmm ");
                    return entry;
                }
            }
            return null;
        }

        private ContactEntry SearchByPhone()
        {
            Console.WriteLine($"What would you like to search for?");
            string feedback = Console.ReadLine();
            foreach (ContactEntry entry in phonedir)
            {
                if (entry.Number.Contains(feedback))
                {
                    Console.WriteLine($"Gotemmm ");
                    return entry;
                }
            }
            return null;
        }

        private void StartSerialization() { SerializerJSON.JsonSerializer<List<ContactEntry>>(phonedir);  }

        private void StartDeserialization() { phonedir = SerializerJSON.JsonDeserialize<List<ContactEntry>>(); }

        private void DirectoryEntry(Contact cont)
        {
            ContactEntry entry = new ContactEntry();
            entry.Name =  cont.GetLastName + ", " + cont.GetFirstName + ".";
            entry.Address = cont.GetAddressInfo + ".";
            entry.Number = cont.GetPhoneNumberInfo + ".";
            phonedir.Add(entry);
        }
    }
}
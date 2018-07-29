using System;

namespace PhoneDirectoryLibrary
{
    public class PhoneNumber
    {
        //Member Variables. 
        private int countryCode; 
        private int areaCode; 
        private int phoneCode; 
        private int extensionCode;

        //Default constructor. Adds values to the object. 
        public PhoneNumber()
        {
            Console.WriteLine($"What is the country code?");
            countryCode = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"What is the area code?");
            areaCode = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"What is the phone number?");
            phoneCode = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"What is the extension? 0 if there is none. ");
            extensionCode = Int32.Parse(Console.ReadLine());
        }

        //Overloaded constructor. Assigns values to the object. 
        public PhoneNumber(int cc, int ac, int pc, int ec) 
        {
            countryCode = cc;
            areaCode = ac;
            phoneCode = pc;
            extensionCode = ec; 
        }

        //Property values for the member variables. 
        public int CCode {get {return countryCode; }}
        public int ACode {get {return areaCode; }}
        public int PCode {get {return phoneCode; }}
        public int ECode {get {return extensionCode; }}

        //Simple function that prints in the right order. 
        public string Print() { return $"Phone: +{CCode} ({ACode}) {PCode} Ext: {ECode}";  }

    }
}

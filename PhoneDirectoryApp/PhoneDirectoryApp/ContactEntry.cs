using System;

namespace PhoneDirectoryApp
{
    public class ContactEntry
    {
        //Data members. 
        private short iD = (short)DateTime.Now.Ticks; 
        private string name;
        private string address;
        private string number;
        //Data properties. 
        public long ID { get => iD; }
        public string Name { set => name = value; get => name; }
        public string Address { set => address = value; get => address; }
        public string Number { set => number= value; get => number;  }
        //Print property. 
        public string Print { get => $"ID: {iD}; {name} {address} {number}"; }
    }
}

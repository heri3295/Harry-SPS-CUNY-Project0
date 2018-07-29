using System;
using System.Collections.Generic;
using PhoneDirectoryLibrary; 
using System.Web.Script.Serialization;

namespace PhoneDirectoryApp
{
    public class SerializerJSON
    {
        //Directory for reading/writing. Perhaps a method for changing directory?
        private static string directory = "C:\\Users\\mexic\\Documents\\temp\\Directory.txt"; 


        //Method for serializing in Json, which also returns a Json in string. 
        public static string JsonSerializer<T>(T t)
        {
            string jsonstring = new JavaScriptSerializer().Serialize(t);
            System.IO.File.WriteAllText(directory, jsonstring);
            return jsonstring; 
        }

        //Method for deserializing in Json, which also returns that same T object. 
        public static T JsonDeserialize<T>()
        {
            string jsonString_data = System.IO.File.ReadAllText(directory);
            JavaScriptSerializer deserializer = new JavaScriptSerializer();
            T cont = deserializer.Deserialize<T>(jsonString_data);
            return cont; 
        }
    }
}
using System;
using System.Collections.Generic;
using PhoneDirectoryLibrary; 
using System.Web.Script.Serialization;

namespace PhoneDirectoryApp
{
    public class SerializerJSON
    {
        //Method for serializing in Json, which also returns a Json in string. 
        public static string JsonSerializer<T>(T t)
        {
            string jsonstring = new JavaScriptSerializer().Serialize(t);
            //OutsideConnect.WriteToFile(jsonstring); 
            OutsideConnect.WriteToSQL_DB(jsonstring); 
            OutsideConnect.WriteToFile(jsonstring); 
            return jsonstring; 
        }

        //Method for deserializing in Json, which also returns that same T object. 
        public static T JsonDeserialize<T>()
        {
            //string jsonstring = OutsideConnect.ReadFromFile(); 
            string jsonstring = OutsideConnect.ReadFromSQL_DB(); 
            JavaScriptSerializer deserializer = new JavaScriptSerializer();
            return deserializer.Deserialize<T>(jsonstring);
        }

    }
}
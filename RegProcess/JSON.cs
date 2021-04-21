using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

public class JSON
{
    public static string Stringify(object val)
    {
        //if (val == null) return "null";
        //DataContractJsonSerializer serializer = new DataContractJsonSerializer(val.GetType());
        //using (var ms = new MemoryStream())
        //{
        //    serializer.WriteObject(ms, val);
        //    return Encoding.UTF8.GetString(ms.ToArray());
        //}

        return JsonConvert.SerializeObject(val, Formatting.Indented);
    }
    public static T Parse<T>(string json)
    {
        return JsonConvert.DeserializeObject<T>(json);
        //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
        //using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        //{
        //    return (T)serializer.ReadObject(ms);
        //}
    }
    public static T ParseFile<T>(string fileName)
    {
        return Parse<T>(File.ReadAllText(fileName, Encoding.UTF8));
        //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
        //using (var ms = new FileStream(fileName, FileMode.Open))
        //{
        //    return (T)serializer.ReadObject(ms);
        //}
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task
{
    public static class DataReader 
    {
        public static T ReadJsonAPI<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static T ReadJson<T>(string pathToFile)
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + pathToFile);
            return JsonConvert.DeserializeObject<T>(json);
        }
        
        public static List<T> ReadJsonList<T>(string pathToFile)
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + pathToFile);
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}
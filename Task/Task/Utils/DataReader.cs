using System.Collections.Generic;
using Aquality.Selenium.Core.Configurations;
using NUnit.Framework;

namespace Task
{
    public class DataReader : ISettingsFile
    {
        public T GetValue<T>(string path)
        {
            throw new System.NotImplementedException();
        }

        public List GetValueList<T>(string path)
        {
            throw new System.NotImplementedException();
        }

        public IReadOnlyDictionary<string, T> GetValueDictionary<T>(string path)
        {
            throw new System.NotImplementedException();
        }

        public bool IsValuePresent(string path)
        {
            throw new System.NotImplementedException();
        }
    }
}
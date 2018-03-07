using System;
using Newtonsoft.Json;

namespace LibraryProject
{
    public class Class1
    {
    }
    public class Person
    {
        [JsonIgnore]        
        public string Name{get;set;}
        public int Age{get;set;}
    }
}

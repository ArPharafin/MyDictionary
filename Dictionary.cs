using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyDictionary
{
    internal class Dictionary
    {
        Dictionary<int,string>myDictionary = new Dictionary<int,string>();
        public void Add()
        {
            myDictionary.Add(1,"Omer" );
            myDictionary.Add(2,"Seyma");
            myDictionary.Add(3,"Kerem");
            myDictionary.Add(4,"Rumeysa");
            foreach(KeyValuePair<int,string>kvp in myDictionary)
            {
                Console.WriteLine(kvp);
            }
        }
        
    }
}

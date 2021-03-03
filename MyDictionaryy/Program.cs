using System;

namespace MyDictionaryy
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("hatice", 25);
            myDictionary.Add("Ali", 39);
            myDictionary.Add("Musa", 98);
            myDictionary.Add("Merve", 78);
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            solve3();
        }

        static void solve3()
        {
            String filePath = "sample.json";
            JObject jo = JObject.Parse(File.ReadAllText(filePath));
            foreach (KeyValuePair<string, JToken> itemJo in jo)
            {
                Console.WriteLine("Key : " + itemJo.Key + " / Value Type : " + itemJo.Value.Type);
            }
        }

    }
}

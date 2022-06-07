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
            solve2();
        }


        static void solve2()
        {
            String filePath = "sample.json";
            StreamReader sr = new StreamReader(filePath);
            String jsonString = sr.ReadToEnd();
            sr.Close();
            JObject jo = JObject.Parse(jsonString);
            String name = jo["name"].ToString();
            int age = (int)jo["age"];
            Console.WriteLine("name(age) : " + name + "(" + age + ")");
            name = jo["children"][1]["name"].ToString();
            age = (int)jo["children"][1]["age"];
            Console.WriteLine("name(age) : " + name + "(" + age + ")");
        }

    }
}

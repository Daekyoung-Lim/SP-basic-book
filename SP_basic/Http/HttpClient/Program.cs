using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;


namespace SP_BASIC
{
    class Httpclient
    {
        static JObject getFileList(string path)
        {
            JObject jsonFiles = new JObject();

            jsonFiles["Folder"] = "Input";

            

            return jsonFiles;
        }

        static void sendFileList(String url, JObject jsonObj)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url); 
            webRequest.Method = "POST"; 
            webRequest.Timeout = 30 * 1000;
            webRequest.ContentType = "application/json; charset=utf-8";
            string responseText;

            string postData = jsonObj.ToString();
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            Stream dataStream = webRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length); 
            dataStream.Close();

            using (HttpWebResponse resp = (HttpWebResponse)webRequest.GetResponse())
            {
                HttpStatusCode status = resp.StatusCode; 
                Console.WriteLine(status);
                
                Stream respStream = resp.GetResponseStream();
                using (StreamReader streamReader = new StreamReader(respStream))
                { 
                    responseText = streamReader.ReadToEnd();
                } 
            }
            Console.WriteLine(responseText);
        }

        static void Main(string[] args)
        {
            string url = "http://127.0.0.1:8080/files";

            JObject jsonFiles = getFileList("./INPUT");
            sendFileList(url, jsonFiles);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace HP_12
{
    class Program
    {
        //async and wait
        static void Main(string[] args)
        {

            string result = DownloadContent().Result;
            Console.WriteLine(result); 

        }
        public static async Task<string> DownloadContent() 
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com"); //programme waits here until the function returns the value
                return result;
            
            }
        }
    }
}

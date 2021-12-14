using System;
using System.IO;
using System.Net;
using System.Text;

namespace HttpWebRequestResponce
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HttpWebRequest reqw = (HttpWebRequest)HttpWebRequest.Create("https://google.com");
                //HttpWebRequest reqw = (HttpWebRequest)HttpWebRequest.Create("http://asfhyugsdh.com");
                //HttpWebRequest reqw = (HttpWebRequest)HttpWebRequest.Create("http://rosumniy.prostir.com.ua/");
                HttpWebResponse resp = (HttpWebResponse)reqw.GetResponse(); //создаем объект отклика
                Console.WriteLine("Status Code: " + ((int)resp.StatusCode));
                if (resp.StatusCode.ToString() == "OK")
                {

                    StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.Default);
                    //создаем поток для чтения отклика
                    Console.WriteLine(sr.ReadToEnd());
                    //вывести на экран все, что читается
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

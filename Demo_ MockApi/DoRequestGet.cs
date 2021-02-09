using System;
using System.Net;
using System.IO;


namespace Demo__MockApi
{
    public class DoRequestGet
    {

        public DoRequestGet() { }

        //fazendo um get de uma API existente
        public void Busca()
        {
            WebRequest request = WebRequest.Create("https://600607e63698a80017de12e2.mockapi.io/demo");
            request.Method = "GET";
            var response = request.GetResponse();

            if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
            {
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader streamReader = new StreamReader(stream);
                    string content = streamReader.ReadToEnd();
                    Console.Write("GET" + content);
                }
            }
            else
            {
                Console.Write("GET Fail");
            }
        }
    }
}

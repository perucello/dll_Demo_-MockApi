using System;
using System.Text;
using System.Net;
using System.IO;

namespace Demo__MockApi
{
    public class DoRequestPost
    {

        public DoRequestPost() { }

        public void Inserir()
        {
            WebRequest request = WebRequest.Create("https://600607e63698a80017de12e2.mockapi.io/demo");
            request.Method = "POST";
            request.ContentType = "application/json; charset=UTF-8";
            string json = "{\"nome\":\"Teste de Post via Script\"}";

            var byteArray = Encoding.UTF8.GetBytes(json);
            request.ContentLength = byteArray.Length;

            Stream stream = request.GetRequestStream();
            stream.Write(byteArray, 0, byteArray.Length);
            stream.Close();

            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.Created)
            {
                Console.WriteLine("Post => ok");
                Console.WriteLine(json);
            }
            else
            {
                Console.Write("fail Post");
            }
        }

    }
}
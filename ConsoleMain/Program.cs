using System;
using Demo__MockApi;


namespace ConsoleMain
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //POST
            DoRequestPost post = new DoRequestPost();
            post.Inserir();
            */

            //GET
            DoRequestGet busca = new DoRequestGet();
            busca.Busca();
        }
    }
}

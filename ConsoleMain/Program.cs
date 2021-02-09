using System;
using Demo__MockApi;


namespace ConsoleMain
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //POST DLL 
            DoRequestPost post = new DoRequestPost();
            post.Inserir();
            */

            //GET DLL
            DoRequestGet busca = new DoRequestGet();
            busca.Busca();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Demo__MockApi;


namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            DoRequestGet get = new DoRequestGet();
            get.Busca();
        }
    }
}

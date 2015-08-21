using System;
using ConcreteSolutions.Apoio.Pcl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConcreteSolutions.Apoio.Testes
{
    [TestClass]
    public class HttpTeste
    {
        [TestMethod]
        public void ObterTeste()
        {
            Console.WriteLine(Http.Obter("http://api.dribbble.com/shots/popular?page=1").Result);
        }
    }
}
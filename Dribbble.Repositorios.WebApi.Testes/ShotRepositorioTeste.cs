using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dribbble.Repositorios.WebApi.Testes
{
    [TestClass]
    public class ShotRepositorioTeste
    {
        [TestMethod]
        public void Obter()
        {
            var repositorio = new ShotRepositorio("http://api.dribbble.com/shots/popular?page=1");
            var pagina = repositorio.Obter();

            Assert.AreEqual(15, pagina.shots.Count);
        }
    }
}
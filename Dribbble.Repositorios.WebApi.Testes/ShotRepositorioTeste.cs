using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dribbble.Repositorios.WebApi.Testes
{
    [TestClass]
    public class ShotRepositorioTeste
    {
        [TestMethod]
        public void Obter()
        {
            var repositorio =  new ShotRepositorio("http://api.dribbble.com/shots/{0}");
            var shot =  repositorio.Obter(1757954);

            Assert.AreEqual(shot.Result.id, 1757954);
            Assert.AreEqual(shot.Result.player.name, "Tim Van Damme");
        }
    }
}
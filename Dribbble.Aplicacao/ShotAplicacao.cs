using System.Threading.Tasks;
using Dribbble.Dominio;
using Dribbble.Repositorios.WebApi;

namespace Dribbble.Aplicacao
{
    public class ShotAplicacao
    {
        public async Task<Shot> Obter(string uri, int shotId)
        {
            return await new ShotRepositorio(uri).Obter(shotId);
        }
    }
}
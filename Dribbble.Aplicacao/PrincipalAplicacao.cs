using System.Threading.Tasks;
using Dribbble.Dominio;
using Dribbble.Repositorios.WebApi;

namespace Dribbble.Aplicacao
{
    public class PrincipalAplicacao
    {
        public async Task<Pagina> Obter(string uri, int numeroPaginaPrincipal)
        {
            return await new PaginaRepositorio(string.Format(uri, numeroPaginaPrincipal)).Obter();
        }
    }
}
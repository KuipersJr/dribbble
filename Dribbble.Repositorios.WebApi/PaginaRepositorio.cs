using System.Threading.Tasks;
using ConcreteSolutions.Apoio;
using Dribbble.Dominio;
using Newtonsoft.Json;

namespace Dribbble.Repositorios.WebApi
{
    public class PaginaRepositorio
    {
        readonly string _apiUrl;

        public PaginaRepositorio(string apirUrl)
        {
            _apiUrl = apirUrl;
        }

        //ToDo: refatorar para classes genéricas.
        public async Task<Pagina> Obter()
        {
            //ToDo: definir ponto para tratamento de exceções.
            var pagina = await Http.Obter(_apiUrl);

            return JsonConvert.DeserializeObject<Pagina>(pagina);
        }
    }
}
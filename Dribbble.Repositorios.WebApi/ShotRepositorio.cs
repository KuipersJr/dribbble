using ConcreteSolutions.Apoio;
using Dribbble.Dominio;
using Newtonsoft.Json;

namespace Dribbble.Repositorios.WebApi
{
    public class ShotRepositorio
    {
        readonly string _apiUrl;

        public ShotRepositorio(string apirUrl)
        {
            _apiUrl = apirUrl;
        }

        public Pagina Obter()
        {
            return JsonConvert.DeserializeObject<Pagina>(Http.Obter(_apiUrl).Result);
        }
    }
}
using System.Threading.Tasks;
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

        public async Task<Shot> Obter(int id)
        {
            var shot = await Http.Obter(string.Format(_apiUrl, id));
            return JsonConvert.DeserializeObject<Shot>(shot);
        }
    }
}
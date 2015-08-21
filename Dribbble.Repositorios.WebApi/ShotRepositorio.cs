using System.Threading.Tasks;
using ConcreteSolutions.Apoio.Pcl;
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
            return JsonConvert.DeserializeObject<Shot>(await ObterJson(id));
        }

        public async Task<string> ObterJson(int id)
        {
            return await Http.Obter(string.Format(_apiUrl, id));
        }
    }
}
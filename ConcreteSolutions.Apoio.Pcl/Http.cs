using System.Net.Http;
using System.Threading.Tasks;

namespace ConcreteSolutions.Apoio.Pcl
{
    public static class Http
    {
        public static async Task<string> Obter(string uri)
        {
            using (var cliente = new HttpClient())
            {
                var resposta = await cliente.GetAsync(uri);
                return await resposta.Content.ReadAsStringAsync();
            }
        }
    }
}
using System.Collections.Generic;

namespace Dribbble.WindowsPhone
{
    public static class Configuracoes
    {
        static Configuracoes()
        {
            Uris = new Dictionary<string, string>
            {
                { "PaginaPrincipal", "http://api.dribbble.com/shots/popular?page=1" }
            };
        }

        public static Dictionary<string, string> Uris { get; set; }
    }
}
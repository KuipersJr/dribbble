using System.Collections.Generic;

namespace Dribbble.WindowsPhone
{
    public static class Configuracoes
    {
        static Configuracoes()
        {
            Uris = new Dictionary<Pagina, string>
            {
                { Pagina.Principal, "http://api.dribbble.com/shots/popular?page={0}" },
                { Pagina.Shot, "http://api.dribbble.com/shots/{0}" }
            };
        }

        public static Dictionary<Pagina, string> Uris { get; set; }

        public enum Pagina
        {
            Principal,
            Shot
        }
    }
}
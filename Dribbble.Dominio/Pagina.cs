using System.Collections.Generic;

namespace Dribbble.Dominio
{
    public class Pagina
    {
        public string page { get; set; }
        public int per_page { get; set; }
        public int pages { get; set; }
        public int total { get; set; }
        public List<Shot> shots { get; set; }
    }
}
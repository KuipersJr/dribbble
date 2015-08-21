using System.Threading.Tasks;
using System.Web.Mvc;
using ConcreteSolutions.Apoio;
using Dribbble.Aplicacao;

namespace Dribbble.AspNetMvc.Controllers
{
    public class ShotController : Controller
    {
        // GET: Shot
        public async Task<string> Index()
        {
            var shot = await new ShotAplicacao().ObterJson(Configuracao.Obter("EnderecoPaginaShotDribbble"), 2204334);

            return shot;
            //return Json(shots, JsonRequestBehavior.AllowGet);
        }

        public ActionResult _Shot()
        {
            return PartialView();
        }
    }
}
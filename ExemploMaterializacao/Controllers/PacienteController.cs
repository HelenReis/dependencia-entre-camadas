using System.Web.Mvc;

namespace ExemploMaterializacao.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaPacientes()
        {
            var servico = new ServicoExposto.ServicoSoapClient();
            return View(servico.GetMeusPacientes());
        }
    }
}
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TO;

namespace Servico
{
    /// <summary>
    /// Summary description for Servico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Servico : System.Web.Services.WebService
    {

        [WebMethod]
        public List<PacienteTO> GetMeusPacientes()
        {
            var pacienteNegocio = new PacienteNegocio();
            return pacienteNegocio.GetMeusPacientes();
        }
    }
}

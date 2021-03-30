using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio;
using System;
using TO;

namespace Testes
{
    [TestClass]
    public class PacienteTeste
    {
        [TestMethod]
        public void NovoPaciente()
        {
            try
            {
                var pacienteNegocio = new PacienteNegocio();
                var paciente = new PacienteTO();
                paciente.Nome = "Helen";
                paciente.NomeMae = "Gal";
                paciente.Nascimento = DateTime.Today.AddYears(-24);
                paciente.Sexo = SexoEnum.Feminino;

                pacienteNegocio.Adicionar(paciente);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

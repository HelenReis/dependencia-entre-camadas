using Repositorio;
using System.Collections.Generic;
using TO;

namespace Negocio
{
    public class PacienteNegocio
    {
        private PacienteRepositorio _repPaciente = new PacienteRepositorio();

        public PacienteTO GetPacientePorId(int id) => _repPaciente.GetPacientePorId(id);

        public List<PacienteTO> GetMeusPacientes() => _repPaciente.GetTodos();

        public void Adicionar(PacienteTO paciente) => _repPaciente.Novo(paciente);

        public void Editar(PacienteTO paciente) => _repPaciente.Atualiza(paciente);
    }
}

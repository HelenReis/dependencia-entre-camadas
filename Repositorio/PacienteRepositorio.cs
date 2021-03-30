using Dados;
using Repositorio.Conversao;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TO;

namespace Repositorio
{
    public class PacienteRepositorio : RepositorioBase
    {
        public PacienteTO GetPacientePorId(int id) => this.Contexto.Pacientes.FirstOrDefault(p => p.Id == id).ToPacienteTO();

        public List<PacienteTO> GetTodos()
        {
            return this.Contexto.Pacientes.ToList().Select(p => p.ToPacienteTO()).ToList();
        }

        public void Novo(PacienteTO paciente)
        {
            var entity = new Paciente();
            entity.DataCriacao = DateTime.Now;
            entity.DataEdicao = DateTime.Now;
            entity.Apply(paciente);
            this.Contexto.Pacientes.Add(entity);
            this.Contexto.SaveChanges();
        }

        public void Atualiza(PacienteTO paciente)
        {
            var entity = this.Contexto.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            entity.DataEdicao = DateTime.Now;
            entity.Apply(paciente);
            this.Contexto.Entry(entity).State = EntityState.Modified;
            this.Contexto.SaveChanges();
        }
    }
}

using GymProjectMvc.Domain.Entities.Validation;
using System.Collections.Generic;

namespace GymProjectMvc.Domain.Entities
{
    public sealed class Plano : Entity
    {
        public Plano(string nome, string? descricao, decimal valor, string status)
        {
            ValidateDomain(nome, descricao, valor, status);
        }



        public void ValidateDomain(string nome, string? descricao, decimal valor, string status)
        {
            DomainExceptionValidation.When(nome.Length < 3, "Nome inválido, minimo de 3 caracteres.");
            DomainExceptionValidation.When(valor < 0, "Valor menor que 0.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(status), "Status inválido.");

            Nome = nome;
            Valor = valor;
            Status = status;
        }

        public void Update(string nome, string? descricao, decimal valor, string status)
        {
            ValidateDomain(nome, descricao, valor, status);
        }

        public string Nome { get; private set; }
        public string? Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public string Status { get; private set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}

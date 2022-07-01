using GymProjectMvc.Domain.Entities.Validation;

namespace GymProjectMvc.Domain.Entities
{
    public sealed class Plano : Entity
    {
        public Plano(int id, string nome, string? descricao, decimal valor, string status)
        {
            DomainExceptionValidation.When(id < 0, "Valor inválido para ID.");
            Id = id;
            ValidateDomain(nome, valor, status);
        }

        public Plano(string nome, string? descricao, decimal valor, string status)
        {
            ValidateDomain(nome, valor, status);
        }

        public void ValidateDomain(string nome, decimal valor, string status)
        {
            DomainExceptionValidation.When(nome.Length < 3, "Nome inválido, minimo de 3 caracteres.");
            DomainExceptionValidation.When(valor < 0, "Valor menor que 0.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(status), "Status inválido.");

            Nome = nome;
            Valor = valor;
            Status = status;
        }

        public void Update(string nome, decimal valor, string status)
        {
            ValidateDomain(nome, valor, status);
        }

        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }

        public ICollection<Aluno> Alunos { get; set; }
    }
}

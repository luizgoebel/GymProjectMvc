using GymProjectMvc.Domain.Entities.Validation;

namespace GymProjectMvc.Domain.Entities
{
    public sealed class Aluno : Entity
    {
        public Aluno(int id, string nome, string cpf, DateTime? dataNascimento, string? cidade, string? bairro, string? logradouro, string? numero, string status)
        {
            DomainExceptionValidation.When(id < 0, "Valor ID inválido.");
            Id = id;
            ValidateDomain(nome, cpf, dataNascimento, cidade, bairro, logradouro, numero, status);
        }

        public Aluno(string nome, string cpf, DateTime? dataNascimento, string? cidade, string? bairro, string? logradouro, string? numero, string status)
        {
            ValidateDomain(nome, cpf, dataNascimento, cidade, bairro, logradouro, numero, status);
        }

        public void ValidateDomain(string nome, string cpf, DateTime? dataNascimento, string? cidade, string? bairro, string? logradouro, string? numero, string status)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome inválido. Nome é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(cpf), "CPF inválido. CPF é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(Convert.ToString(dataNascimento)), "Data de nascimento inválido. Data de nascimento é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(status), "Status inválido. Status é obrigatório.");

            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Status = status;
        }

        public void Update(string nome, string cpf, DateTime? dataNascimento, string? cidade, string? bairro, string? logradouro, string? numero, string status, int planoId)
        {
            ValidateDomain(nome, cpf, dataNascimento, cidade, bairro, logradouro, numero, status);
            PlanoId = planoId;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string Status { get; set; }

        public int PlanoId { get; set; }
        public Plano Plano { get; set; }
    }
}

using GymProjectMvc.Domain.Entities.Validation;
using System;

namespace GymProjectMvc.Domain.Entities
{
    public sealed class Aluno : Entity
    {
        public Aluno(string nome, string cpf, DateTime dataNascimento, string? cidade, string? bairro, string? logradouro, string? numero, string status)
        {
            ValidateDomain(nome, cpf, dataNascimento, cidade, bairro, logradouro, numero, status);
        }

        public void ValidateDomain(string nome, string cpf, DateTime dataNascimento, string? cidade, string? bairro, string? logradouro, string? numero, string status)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome inválido. Nome é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(cpf), "CPF inválido. CPF é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(Convert.ToString(dataNascimento)), "Data de nascimento inválido. Data de nascimento é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(status), "Status inválido. Status é obrigatório.");

            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Cidade = cidade;
            Bairro = bairro;
            Logradouro = logradouro;
            Numero = numero;
            Status = status;
        }

        public void Update(string nome, string cpf, DateTime dataNascimento, string? cidade, string? bairro, string? logradouro, string? numero, string status)
        {
            ValidateDomain(nome, cpf, dataNascimento, cidade, bairro, logradouro, numero, status);
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string? Cidade { get; private set; }
        public string? Bairro { get; private set; }
        public string? Logradouro { get; private set; }
        public string? Numero { get; private set; }
        public string Status { get; private set; }

        public int? MatriculaId { get; set; }
        public Matricula Matricula { get; set; }

    }
}

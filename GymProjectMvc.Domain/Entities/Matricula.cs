using GymProjectMvc.Domain.Entities.Validation;
using System;

namespace GymProjectMvc.Domain.Entities
{
    public sealed class Matricula : Entity
    {
        public Matricula(long codigo, int alunoId, int planoId, DateTime dataPagamento, DateTime dataVencimento, string status)
        {
            ValidateDomain(codigo, alunoId, planoId, dataPagamento, dataVencimento, status);
        }

        public void ValidateDomain(long codigo, int alunoId, int planoId, DateTime dataPagamento, DateTime dataVencimento, string status)
        {
            DomainExceptionValidation.When(codigo <= 0, "Código da matricula inválido");
            DomainExceptionValidation.When(alunoId <= 0, "Aluno não encontrado.");
            DomainExceptionValidation.When(planoId <= 0, "Plano não encontrado.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(Convert.ToString(dataPagamento)), "Data do pagamento inválido. Data do pagamento é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(Convert.ToString(dataPagamento)), "Data do vencimento inválido. Data do vencimento é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(status), "Status inválido. Status é obrigatório.");

            Codigo = codigo;
            AlunoId = alunoId;
            PlanoId = planoId;
            DataPagamento = dataPagamento;
            DataVencimento = dataVencimento;
        }

        public long Codigo { get; private set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int PlanoId { get; set; }
        public Plano Plano { get; set; }
        public DateTime DataPagamento { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public string Status { get; set; }
    }
}

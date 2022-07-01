﻿namespace GymProjectMvc.Domain.Entities
{
    public sealed class Aluno : Entity
    {
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

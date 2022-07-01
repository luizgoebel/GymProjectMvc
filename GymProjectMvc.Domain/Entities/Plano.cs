namespace GymProjectMvc.Domain.Entities
{
    public sealed class Plano : Entity
    {
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }
    }
}

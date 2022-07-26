namespace georgelucasgomes_d3_avaliacao.Domain.Models
{
    internal class User
    {
        public Guid UserId { get; set; } 
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPassword { get; set; } = string.Empty;

    }
}

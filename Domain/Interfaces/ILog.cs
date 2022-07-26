using georgelucasgomes_d3_avaliacao.Domain.Models;

namespace georgelucasgomes_d3_avaliacao.Domain.Interfaces
{
    internal interface ILog
    {
        public void RegisterAccess(User user);
    }
}

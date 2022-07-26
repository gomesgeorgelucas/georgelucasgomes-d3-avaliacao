using georgelucasgomes_d3_avaliacao.Domain.Models;

namespace georgelucasgomes_d3_avaliacao.Domain.Interfaces
{
    internal interface IUser
    {
        User UserLogin(string email, string password);
    }
}

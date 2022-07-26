using georgelucasgomes_d3_avaliacao.Domain.Models;
using georgelucasgomes_d3_avaliacao.Domain.Repositories;

namespace georgelucasgomes_d3_avaliacao.Controllers
{
    internal class LogController
    {
        private LogRepository logRepository;

        public LogController()
        {
            logRepository = new LogRepository();
        }

        public void registeLogin(User user)
        {
            logRepository.Create(user);
        }

        public void registerLogout(User user)
        {
            logRepository.Create(user, true);
        }
    }
}

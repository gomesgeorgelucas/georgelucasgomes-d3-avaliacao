using georgelucasgomes_d3_avaliacao.Domain.Models;
using georgelucasgomes_d3_avaliacao.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace georgelucasgomes_d3_avaliacao.Controllers
{
    internal class LoginController
    {
        private UserRepository userRepository;

        private static Boolean _isLogged = false;

        public static bool IsLogged { get => _isLogged; set => _isLogged = value; }

        public LoginController() {
            userRepository = new UserRepository();
        }

        public Boolean UserLogin(string email, string password)
        { 
            User user = userRepository.UserLogin(email, password);
            
            if (user.UserEmail.Equals(String.Empty) || user.UserName.Equals(String.Empty))
            {
                return false;
            }

            return true;  
        }
    }
}

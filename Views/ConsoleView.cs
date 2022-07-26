using georgelucasgomes_d3_avaliacao.Controllers;
using georgelucasgomes_d3_avaliacao.Views.Assets;


namespace georgelucasgomes_d3_avaliacao.Views
{
    internal class ConsoleView
    {
        private LoginController loginController = new LoginController();    

        private readonly short _displaySize = 112;
        public void Init()
        {
            this.MainMenuLoop();
        }

        private void ShowMainMenu(Boolean hasInputError)
        {
            //Console.Clear();

            Console.WriteLine(Images.LOGO);
            Console.WriteLine(Messages.MAIN_MENU_LOGIN_TITLE + new string('-', (_displaySize - Messages.MAIN_MENU_LOGIN_TITLE.Length)));
            Console.WriteLine(Messages.MAIN_MENU_OPTION_LOGIN);
            Console.WriteLine(Messages.MAIN_MENU_OPTION_EXIT);
            Console.WriteLine(Images.DIVIDER);
            

            if (hasInputError)
            {
                Console.Write(Messages.MAIN_MENU_OPTION_INVALID + " " + Images.PROMPT);
            }
            else
            {
                Console.Write(Images.PROMPT);
            }

        }

        private void MainMenuLoop()
        {
            string input = "";
            Boolean inputError = false;

            do
            {
                ShowMainMenu(inputError);
                inputError = false;

                try
                {
                    input = Console.ReadLine().ToLower();
                }
                catch (Exception err)
                {
                    throw new IOException(err.Message);                    
                }

                switch (input)
                {
                    case "l":
                        Console.Write("Inserir email:");
                        string user_email = Console.ReadLine();
                        Console.Write("Inserir senha:");
                        string user_password = Console.ReadLine();

                        LoginController.IsLogged = loginController.UserLogin(user_email, user_password);

                        if (LoginController.IsLogged)
                        {
                            Console.WriteLine("Usuário logado com sucesso");
                        } else {
                            Console.WriteLine("Login inválido! Tente novamente!");
                        }

                        break;

                    case "x":
                        break;
                    default:
                        inputError = true;
                        break;
                }

            } while (!input.Equals("x"));
        }
    }
}

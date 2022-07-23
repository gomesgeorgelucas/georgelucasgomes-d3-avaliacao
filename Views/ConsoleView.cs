using georgelucasgomes_d3_avaliacao.Views.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace georgelucasgomes_d3_avaliacao.Views
{
    internal class ConsoleView
    {
        private readonly short _displaySize = 112;
        public void Init()
        {
            this.MainMenuLoop();
        }

        private void ShowMainMenu()
        {
            Console.WriteLine(Images.LOGO);
            Console.WriteLine(Messages.MAIN_MENU_LOGIN_TITLE + new string('-', (_displaySize - Messages.MAIN_MENU_LOGIN_TITLE.Length)));
            Console.WriteLine(Messages.MAIN_MENU_OPTION_LOGIN);
            Console.WriteLine(Messages.MAIN_MENU_OPTION_EXIT);
            Console.WriteLine(Images.DIVIDER);
            Console.Write(Images.PROMPT);
        }

        private void MainMenuLoop()
        {
            string input = "";

            do
            {
                ShowMainMenu();
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
                        Console.Clear();
                        break;
                    case "x":
                        break;
                    default:
                        Console.Clear();
                        break;
                }

            } while (!input.Equals("x"));
        }
    }
}

using georgelucasgomes_d3_avaliacao.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace georgelucasgomes_d3_avaliacao.Domain.Repositories
{
    internal class LogRepository : Base
    {
        private string path = "database/log.csv";

        public LogRepository()
        {
            CreateFolderAndFile(path);
        }

        private static string PrepareLine(User user)
        {
            return $"{DateTime.Now} - O usuário ({user.UserId}): {user.UserName} - {user.UserEmail} -  está logado.\n";
        }

        private static string PrepareLine(User user, Boolean logout)
        {
            return $"{DateTime.Now} - O usuário ({user.UserId}): {user.UserName} - {user.UserEmail} -  foi deslogado.\n";
        }

        public void Create(User user)
        {
            string[] line = { PrepareLine(user) };
            File.AppendAllLines(path, line);
        }

        public void Create(User user, Boolean logout)
        { 
            string[] line = { PrepareLine(user, logout) };
            File.AppendAllLines(path, line);
        }

        public void Delete(string idProduct)
        {
            List<string> lines = ReadAllLinesCSV(path);
            lines.RemoveAll(x => x.Split(";")[0] == idProduct);
            RewriteCSV(path, lines);
        }
    }
}

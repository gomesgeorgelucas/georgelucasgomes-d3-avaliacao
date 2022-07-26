using georgelucasgomes_d3_avaliacao.Domain.Interfaces;
using georgelucasgomes_d3_avaliacao.Domain.Models;
using System.Text;

namespace georgelucasgomes_d3_avaliacao.Domain.Repositories
{
    internal class LogRepository : ILog
    {
        private const string path = "database/log.txt";
        private readonly FileStream fileStream;

        public LogRepository()
        {
            CreateFolderAndFile(path);
            fileStream = File.OpenWrite(path);
        }

        public LogRepository(FileStream fileStream)
        {
            CreateFolderAndFile(path);
            this.fileStream = fileStream;
        }

        private static string PrepareLine(User user)
        {
            return $"{DateTime.Now} - O usuário: {user.UserName} ({user.UserEmail}) está acessando dados do banco.\n";
        }

        public static void CreateFolderAndFile(string path)
        {
            string folder = path.Split('/')[0];

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        public void RegisterAccess(User user)
        {
            string line = PrepareLine(user);
            byte[] info = new UTF8Encoding().GetBytes(line);
            fileStream.Write(info);
        }
    }
}

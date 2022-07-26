namespace georgelucasgomes_d3_avaliacao.Domain.Repositories
{
    internal class Base
    {
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

        public List<string> ReadAllLinesCSV(string path)
        {
            List<string> lines = new();

            using (StreamReader file = new(path))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }

        public void RewriteCSV(string path, List<string> lines)
        {
            using (StreamWriter output = new(path))
            {
                foreach (var line in lines)
                { 
                    output.WriteLine(line);
                }
            }
        }
    }
}

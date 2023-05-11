
namespace HomeWork
{
    abstract class Repository
    {
        public string FileName;
        protected List<IConvertToFile> ex;

        public Repository()
        {
            ex = new List<IConvertToFile>();
        }

        public bool CheckExistRepos()
        {
            if (File.Exists(FileName))
            {
                LoadRepos();
                return true;
            }
            else
            {
                File.Create(FileName);
                return false;
            }
        }

        public void WriteAll()
        {
            foreach (var exs in ex)
            {
                Console.WriteLine(exs.ToConsoleString());
                Console.WriteLine();
            }
        }

        public abstract void Add();

        public void SaveRepos()
        {
            List<string> lines = new List<string>();
            foreach (var exs in ex)
            {
                lines.Add(exs.ToFileString());
            }
            File.AppendAllLines(FileName, lines);
        }

        public void LoadRepos()
        {
            string[] lines = File.ReadAllLines(FileName);
            foreach (string line in lines)
            {
                string[] splitLine = line.Split(';');
                ex.Add(new Customer(splitLine[0], splitLine[1], splitLine[2]));
            }
        }
    }
}

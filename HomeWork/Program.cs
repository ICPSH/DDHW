using HomeWork;
internal class Program
{
    private static void Main(string[] args)
    {
        Repository cRp = new CustomersRepos();
        cRp.CheckExistRepos();
        cRp.Add();
        cRp.SaveRepos();
        cRp.WriteAll();
    }
}

namespace HomeWork
{
    internal class CustomersRepos : Repository
    {
        public CustomersRepos()
        {
            FileName = "CustomerRepos";
        }

        public override void Add()
        {
            Console.WriteLine("Введите имя:");
            var x = Console.ReadLine();
            Console.WriteLine("Введите номер телефона");
            var y = Console.ReadLine();
            Console.WriteLine("Введите серию и номер паспорта");
            var z = Console.ReadLine();

            ex.Add(new Customer(x, y, z));
        }
    }
}

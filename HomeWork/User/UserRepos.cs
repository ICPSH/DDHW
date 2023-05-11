
namespace HomeWork
{
    class UserRepos : Repository
    {
        public UserRepos()
        {
            FileName = "UserRepos";
        }

        public override void Add()
        {
            Console.WriteLine("Введите логин:");
            var x = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            var y = Console.ReadLine();
            Console.WriteLine("Тип пользователя:");
            var z = int.Parse(Console.ReadLine());

            ex.Add(new User(x, y, z));
        }
    }
}

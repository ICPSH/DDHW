
namespace HomeWork
{
    class User : IConvertToFile
    {
        public User(string login, string password, int userType)
        { 
            Login = login;
            Password = password;
            UserType = userType;
        }   

        public string Login { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }

        public string ToConsoleString()
        {
            return
                $"Логин:{Login}\n" +
                $"Пароль:{Password}\n" +
                $"Тип пользователя:{UserType}";
        }

        public string ToFileString()
        {
            return string.Join(';', Login, Password, UserType);
        }
    }
}

namespace SkillFactory.Task12_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simulating the users data for testing.
            List<User> UserList = new List<User>()
            {
                new User() { Name = "Chad", Login = "Power", IsPremium = true },
                new User() { Name = "Timmy", Login = "Speed", IsPremium = false },
                new User() { Name = "Caren", Login = "Epicness", IsPremium = true },
            };

            LoginManager.OnLogin(UserList);

            Console.ReadKey();
        }
    }
}
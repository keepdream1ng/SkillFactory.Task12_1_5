namespace SkillFactory.Task12_1_5
{
    public static class LoginManager
    {
        public static void WelcomeMessage(string person)
        {
            Console.WriteLine($"Добро пожаловать, {person}!");
        }

        public static void OnLogin(User user)
        {
            WelcomeMessage(user.Name);
            if (!user.IsPremium)
            {
                MonetizationManager.ShowAds();
            }
        }

        public static void OnLogin(List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                OnLogin(users.ElementAt(i));
            }
        }
    }
}

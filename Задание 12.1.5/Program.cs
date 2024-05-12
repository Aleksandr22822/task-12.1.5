namespace Task_12._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>() { new User("Александр", "arbuka77", true), new User("Алексей", "refos228", false) };
            foreach (var user in users)
            {
                
                if (user.IsPremium == true)
                {
                    user.GetUpdate();
                    Console.WriteLine($"Здравствуйте {user.Name}");
                }
                else
                {
                    Console.WriteLine($"Здравствуйте {user.Name}");
                    Advertisement.ShowAds();
                }
            }
        
        }
    }
    internal class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
        public User(string Name, string Login, bool IsPremium)
        {
            this.Name = Name;
            this.Login = Login;
            this.IsPremium = IsPremium;
        }

      public void GetUpdate()
        {
            Console.WriteLine("VIP пользователь, реклама отклбчена");
        }

    }

    internal static class Advertisement
    {
        public static void ShowAds()
        {
            Console.WriteLine("Авторизован пользователь, не имеющий VIP статуса");
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}

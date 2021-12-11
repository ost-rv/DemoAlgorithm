using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = GetUsers();

            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine($"Hi {users[i].Name} ({users[i].Login})");

                if (!users[i].IsPreimium)
                {
                    ShowAds();
                }
            }
            Console.ReadKey();
        }


        private static User[] GetUsers()
        {
            return new User[] { 
                new User("Roman", "Роман", false),
                new User("Andrey", "Андрей", true),
                new User("Kostey", "Константин", true),
                new User("Yrko", "Юрий", true),
            };
        }

        private static void ShowAds()
        {
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

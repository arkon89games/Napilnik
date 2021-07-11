using System;

namespace napilnik
{
    class Program
    {
        public const int StartHealth = 100;
        public const int BotDamage = 10;
        public const int MaxBullets = 10;

        private static bool _gameOver = false;

        static void Main(string[] args)
        {
            Player player = new Player(StartHealth);
            player.Died += OnPlayerDied;
            Bot bot1 = new Bot(new Weapon(BotDamage, MaxBullets));
            Bot bot2 = new Bot(new Weapon(BotDamage, MaxBullets));

            while (_gameOver == false)
            {
                bot1.OnSeePlayer(player);
                System.Threading.Thread.Sleep(1000);
                bot2.OnSeePlayer(player);
                System.Threading.Thread.Sleep(1000);
            }
            player.Died -= OnPlayerDied;
        }

        static void OnPlayerDied()
        {
            _gameOver = true;
        }
    }
}

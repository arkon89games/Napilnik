using System;
namespace napilnik
{
    public class Bot
    {
        private readonly Weapon _weapon;

        public Bot(Weapon weapon)
        {
            _weapon = weapon;
        }

        public void OnSeePlayer(Player player)
        {
            if (player.IsAlive())
            {
                _weapon.Fire(player);
            }
            else
            {
                throw new NotImplementedException("Не реализовано поведение бота, если он увидел мёртвого игрока");
            }
        }
    }
}

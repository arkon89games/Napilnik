using System;
namespace napilnik
{
    public class Weapon
    {
        private readonly int _damage;
        private int _bullets;

        public Weapon(int damage, int maxBullets)
        {
            _damage = damage;
            _bullets = maxBullets;
        }

        public void Fire(Player player)
        {
            if (_bullets > 0)
            {
                player.TakeDamage(_damage);
                _bullets -= 1;
            }
            else
            {
                throw new NotImplementedException("Не реализовано поведение оружия, если кончились патроны");
            }
        }
    }
}

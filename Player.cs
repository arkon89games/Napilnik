using System;

namespace napilnik
{
    public class Player
    {
        public event Action Died;
        private int _health;
        private bool _isDied;

        public Player(int health)
        {
            _health = health;
        }

        public void TakeDamage(int damage)
        {
            Console.WriteLine($"Ой-ай (health: {_health})");
            if (_isDied)
            {
                throw new NotImplementedException("Не реализовано поведение игрока, если он уже умер, а его опять пинают");
            }

            damage = Math.Clamp(damage, 0, _health);
            _health -= damage;
            if (_health <= 0)
            {
                _isDied = true;
                Console.WriteLine($"Кирдык (health: {_health})");
                Died?.Invoke();
            }
        }

        public bool IsAlive()
        {
            return _isDied == false;
        }
    }
}

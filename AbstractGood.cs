using System;
namespace napilnik
{
    public abstract class AbstractGood
    {
        public readonly string Name;
        protected int _count;

        public int Count { get { return _count; } }

        protected AbstractGood(string name, int count = 0)
        {
            Name = name;
            _count = count;
        }

        public void Add(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException("count должен быть больше 0");
            }
            _count += count;
        }

        public void Remove(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException("count должен быть больше 0");
            }
            if (count > _count)
            {
                throw new ArgumentException("Попытка убавить больше, чем есть в наличии");
            }
            _count -= count;
        }
    }
}
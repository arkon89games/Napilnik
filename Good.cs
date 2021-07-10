using System;
namespace napilnik
{
    public class Good
    {
        public string Name { get { return _name; } }
        private readonly string _name;

        public Good(string name)
        {
            _name = name;
        }
    }
}
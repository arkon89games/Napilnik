using System;
namespace napilnik
{
    public class StoredGood
    {
        public string Name { get { return _name; } }
        private readonly string _name;
        public StoredGood(string name)
        {
            _name = name;
        }
    }
}
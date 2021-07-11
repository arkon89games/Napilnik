using System;
using System.Linq;
namespace napilnik
{
    public class SupportedGoods
    {
        private readonly string[] _names;

        public SupportedGoods()
        {
            _names = new string[]
            {
                "IPhone 11",
                "IPhone 12"
            };
        }

        public bool Contains(string goodName)
        {
            return _names.Contains(goodName);
        }
    }
}
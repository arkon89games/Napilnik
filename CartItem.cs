using System;
namespace napilnik
{
    public class CartItem : AbstractGood
    {
        public CartItem(string name, int count = 0) : base(name, count)
        {

        }
    }
}
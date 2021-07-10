using System;
using System.Collections.Generic;

namespace napilnik
{
    public class Cart
    {
        private List<CartItem> _goods;

        public Cart()
        {
            _goods = new List<CartItem>();
        }

        public void Add(Good good, int count)
        {
            for (int g = 0; g < _goods.Count; g++)
            {
                if (_goods[g].Name == good.Name)
                {
                    for (int i = 0; i < count; i++)
                    {
                        _goods[g].Add(count);
                    }
                }
            }
        }

        public Good[] GetGoods()
        {
            var result = new Good[0];
            throw new NotImplementedException();
        }
    }
}
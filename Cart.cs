using System;
using System.Collections.Generic;

namespace napilnik
{
    public class Cart
    {
        private List<CartItem> _cartItems;
        private IWarehouse _warehouse;

        public Cart(IWarehouse warehouse)
        {
            _warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse));
            _cartItems = new List<CartItem>();

        }

        public void Add(Good good, int count)
        {
            if (good is null)
            {
                throw new ArgumentNullException(nameof(good));
            }

            Good[] leftovers = _warehouse.GetLeftovers();
            foreach (var item in leftovers)
            {
                if (item.Name == good.Name)
                {
                    if (item.Count < count)
                    {
                        throw new ArgumentException("В корзину нельзя ложить больше, чем есть на складе!");
                    }
                }
            }

            if (_cartItems.Count == 0)
            {
                AddNewItem(new Good(good.Name, count));
            }
            else
            {
                for (int itemIndex = 0; itemIndex < _cartItems.Count; itemIndex++)
                {
                    if (_cartItems[itemIndex].Name == good.Name)
                    {
                        _cartItems[itemIndex].Add(count);
                        Console.WriteLine($"В корзину добавлен товар {good.Name} в количестве {count}шт.");

                    }
                    else
                    {
                        AddNewItem(new Good(good.Name, count));
                    }
                }
            }
        }

        public Good[] GetGoods()
        {
            var result = new Good[_cartItems.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new Good(_cartItems[i].Name, _cartItems[i].Count);
            }

            return result;
        }

        public Order Order()
        {
            return new Order();
        }

        private void AddNewItem(Good good)
        {
            _cartItems.Add(new CartItem(good.Name, good.Count));
        }
    }
}
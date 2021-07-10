using System;
using System.Collections.Generic;

namespace napilnik
{
    public class Shop : IShop
    {
        private Warehouse _warehouse;
        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public Cart Cart()
        {
            return new Cart();
        }

        public void Checkout(List<Good> goods)
        {
            throw new NotImplementedException();
        }

        public Good[] GetGoods()
        {
            return _warehouse.GetLeftovers();
        }
    }
}
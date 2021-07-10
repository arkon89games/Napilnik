using System;
using System.Collections.Generic;

namespace napilnik
{
    public class Shop
    {
        private readonly Warehouse _warehouse;
        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public Cart Cart()
        {
            return new Cart(_warehouse);
        }
    }
}
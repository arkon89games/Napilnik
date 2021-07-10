using System.Collections.Generic;

namespace napilnik
{
    public interface IShop
    {
        Good[] GetGoods();
        void Checkout(List<Good> goods);
    }
}
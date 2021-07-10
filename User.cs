using System;

namespace napilnik
{
    public class User
    {
        private readonly IShop shop;
        private readonly Cart cart;

        public User(IShop shop, Cart cart)
        {
            this.shop = shop;
            this.cart = cart;
        }

        public void ViewProducts()
        {
            Good[] goods = shop.GetGoods();
            PrintGoods(goods);
        }

        public void MakePurchase()
        {
            throw new NotImplementedException();
        }

        private void PrintGoods(Good[] goods)
        {
            foreach (var good in goods)
            {
                Console.WriteLine(good.Name);
            }
            //TODO метод недореализован. В задаче 'Вывод всех товаров на складе с их остатком'
        }


    }
}
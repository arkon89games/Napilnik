using System;

namespace napilnik
{
    public class FakeUser : IUser
    {
        public Action ExitShop;
        private readonly IShop _shop;
        private readonly Cart _cart;

        private Good[] _actualGoods = new Good[0];

        public FakeUser(IShop shop, Cart cart)
        {
            _shop = shop;
            _cart = cart;
        }

        public void WaitInput()
        {
            ViewProducts();
            throw new NotImplementedException();
        }

        private void ViewProducts()
        {
            _actualGoods = _shop.GetGoods();
            PrintGoods(_actualGoods);
            AddToCard();
        }

        private void AddToCard()
        {
            throw new NotImplementedException();

            // _cart.Add(_actualGoods[userInputID], userInputCount);
        }

        private void MakePurchase()
        {
            throw new NotImplementedException();
        }

        private void PrintGoods(Good[] goods)
        {
            Console.WriteLine("\n");

            for (int i = 0; i < goods.Length; i++)
            {
                Console.WriteLine($"ID {i} : {goods[i].Name} : {goods[i].Count}");
            }
            //TODO метод недореализован. В задаче 'Вывод всех товаров на складе с их остатком'
        }


    }
}
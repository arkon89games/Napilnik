using System;

namespace napilnik
{
    public class User
    {
        public Action ExitShop;
        private readonly IShop shop;
        private readonly Cart cart;

        public User(IShop shop, Cart cart)
        {
            this.shop = shop;
            this.cart = cart;
        }

        public void WaitInput()
        {
            Console.WriteLine("\n[1] Посмотреть товары  \n[2] добавить в корзину  \n[3] Оформить покупку  \n[Esc] Выйти из магазина");
            var userInput = Console.ReadKey().Key;

            switch (userInput)
            {
                case ConsoleKey.D1:
                    {
                        ViewProducts();
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        break;
                    }
                case ConsoleKey.Escape:
                    {
                        ExitShop?.Invoke();
                        break;
                    }
                default:
                    {
                        throw new NotImplementedException();
                    }
            }
            throw new NotImplementedException();
        }

        private void ViewProducts()
        {
            Good[] goods = shop.GetGoods();
            PrintGoods(goods);
            AddToCard();
        }

        private void AddToCard()
        {
            Console.WriteLine("\nВведи ID товара, для добавления в корзину или [Q] для выхода в меню");
            var userInput = Console.Read();


            throw new NotImplementedException();
        }

        private void MakePurchase()
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
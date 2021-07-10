using System;

namespace napilnik
{
    public class User : IUser
    {
        public Action ExitShop;
        private readonly IShop _shop;
        private readonly Cart _cart;

        private Good[] _actualGoods = new Good[0];

        public User(IShop shop, Cart cart)
        {
            _shop = shop;
            _cart = cart;
        }

        public void WaitInput()
        {
            Console.WriteLine("\n[1] Посмотреть товары  \n[2] добавить в корзину  \n[3] Оформить покупку  \n[Esc] Выйти из магазина");

            Console.Write("> ");
            var userInput = Console.ReadKey(false).Key;

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
            _actualGoods = _shop.GetGoods();
            PrintGoods(_actualGoods);
            AddToCard();
        }

        private void AddToCard()
        {
            if (_actualGoods.Length <= 0)
            {
                throw new ArgumentException("[User]: AddToCard() _actualGoods.Length <= 0");
            }

            Console.WriteLine("\nВведи ID товара, для добавления в корзину");
            Console.Write("> ");
            int userInputID = Console.Read();
            if (userInputID < 0 || userInputID > _actualGoods.GetUpperBound(0))
            {
                Console.WriteLine($"\nОшибка ввода : ({userInputID}) Выход в меню");
                return;
            }
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("\nВведи желаемое количество товара, для добавления в корзину");
            Console.Write("> ");
            int userInputCount = Console.Read();

            if (userInputID < 0)
            {
                Console.WriteLine("\nОшибка ввода. Выход в меню");
                return;
            }
            else if (userInputID > _actualGoods[userInputID].Count)
            {
                Console.WriteLine("\nВ наличии нет такого количества товара. Выход в меню");
                return;
            }

            _cart.Add(_actualGoods[userInputID], userInputCount);
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
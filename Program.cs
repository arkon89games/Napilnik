using System;

namespace napilnik
{
    class Program
    {
        private static bool _userExit;
        static void Main(string[] args)
        {
            Good iPhone12 = new Good("IPhone 12");
            Good iPhone11 = new Good("IPhone 11");

            Warehouse warehouse = new Warehouse();
            Shop shop = new Shop(warehouse);

            warehouse.Delive(iPhone12, 10);
            warehouse.Delive(iPhone11, 1);

            User user = CreateUser(shop);
            user.ExitShop += OnUserExit;
            //TODO описать работу с пользователем
            while (_userExit == false)
            {
                user.WaitInput();
            }
            Console.WriteLine("\n Всего доброго! Заходи ещё\n");


            throw new NotImplementedException();
        }

        static User CreateUser(Shop shop)
        {
            return new User(shop, shop.Cart());
        }

        static void OnUserExit()
        {
            _userExit = true;
        }
    }
}

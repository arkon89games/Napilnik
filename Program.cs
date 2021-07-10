using System;

namespace napilnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();
            Shop shop = new Shop(warehouse);

            User user = CreateUser(shop);
            //TODO описать работу с пользователем

            throw new NotImplementedException();
        }

        static User CreateUser(Shop shop)
        {
            return new User(shop, shop.Cart());
        }
    }
}

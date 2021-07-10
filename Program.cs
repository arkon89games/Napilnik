using System;

namespace napilnik
{
    public static class Program
    {

        private static void Main(string[] args)
        {
            Good iPhone12 = new Good("IPhone 12");
            Good iPhone11 = new Good("IPhone 11");

            // Warehouse warehouse = new Warehouse();   это то как я пишу
            // Warehouse warehouse = new();             это предлагает Roslynator
            // а как рекомендует наш преподаватель? 
            Warehouse warehouse = new Warehouse();
            Shop shop = new Shop(warehouse);

            warehouse.Delive(iPhone12, 10);
            warehouse.Delive(iPhone11, 1);

            Console.WriteLine("\n Остатки на складе:");
            PrintGoods(warehouse.GetLeftovers());

            Cart cart = shop.Cart();
            cart.Add(iPhone12, 4);
            cart.Add(iPhone11, 3);

            Console.WriteLine("\n Товары в корзине:");
            PrintGoods(cart.GetGoods());

            Console.WriteLine(cart.Order().Paylink);

            Console.WriteLine("\n Всего доброго! Заходи ещё\n");
        }



        private static void PrintGoods(Good[] goods)
        {
            if (goods is null)
            {
                throw new ArgumentNullException(nameof(goods));
            }

            if (goods.Length == 0)
            {
                throw new ArgumentException("На печать отправлен пустой список товаров");
            }
            foreach (var item in goods)
            {
                Console.WriteLine($"{item.Name} {item.Count} ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
namespace napilnik
{
    public class Warehouse
    {
        private SupportedGoods _supportedGoods;
        private List<StoredGood> _storedGoods;

        public Warehouse()
        {
            _supportedGoods = new SupportedGoods();
            _storedGoods = new List<StoredGood>();
        }

        public void Delive(Good good, int count)
        {
            if (count <= 0)
            {
                throw new ArgumentOutOfRangeException("count должен быть больше ноля");
            }

            if (_supportedGoods.Contains(good.Name))
            {
                _storedGoods.Add(new StoredGood(good.Name));
            }
            else
            {
                throw new NotSupportedException("Попытка добавить неподдерживаемый товар");
            }
        }

        public Good[] GetLeftovers()
        {
            Good[] result = new Good[_storedGoods.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new Good(_storedGoods[i].Name, _storedGoods[i].Count);
            }
            return result;
        }

        public void PickUp(Good good)
        {
            throw new NotImplementedException("Не реализовано получение товара со склада");
        }
    }
}
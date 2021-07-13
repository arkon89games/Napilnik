using System;
using System.Collections.Generic;
using System.Linq;
namespace napilnik
{
    public class Warehouse : IWarehouse
    {
        private List<StoredGood> _storedGoods;
        private readonly SupportedGoods _supportedGoods;

        public Warehouse()
        {
            _supportedGoods = new SupportedGoods();
            _storedGoods = new List<StoredGood>();
        }

        public void Delive(Good good, int count)
        {
            if (count <= 0)
            {
                throw new ArgumentOutOfRangeException(paramName: "count должен быть больше ноля");
            }

            if (_supportedGoods.Contains(good.Name))
            {
                bool match = false;
                foreach (var item in _storedGoods)
                {
                    if (item.Name == good.Name)
                    {
                        item.Add(count);
                        match = true;
                    }
                }
                if (match == false)
                {
                    _storedGoods.Add(new StoredGood(good.Name, count));
                }
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
    }
}
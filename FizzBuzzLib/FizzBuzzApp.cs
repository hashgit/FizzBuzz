using System;
using System.Collections.Generic;
using FizzBuzzLib.Items;

namespace FizzBuzzLib
{
    public class FizzBuzzApp
    {
        private readonly List<string> _collection;
        private readonly int _lower;
        private readonly int _higher;

        public FizzBuzzApp(List<string> collection, int lower, int higher)
        {
            _collection = collection;
            _lower = lower;
            _higher = higher;
        }

        public List<IFizzBuzzItem> Execute()
        {
            if (_collection == null)
                return null;

            var result = new List<IFizzBuzzItem>();

            _collection.ForEach(item =>
            {
                int ival;
                if (!int.TryParse(item, out ival))
                {
                    result.Add(new InvalidItem { Value = item });
                    return;
                }

                var itemType = string.Empty;
                if (ival % _lower == 0) itemType += "Fizz";
                if (ival % _higher == 0) itemType += "Buzz";

                if (string.IsNullOrWhiteSpace(itemType))
                {
                    result.Add(new OtherItem { Value = item, Lower = _lower, Higher = _higher });
                    return;
                }

                var optionItem = Activator.CreateInstance(Type.GetType("FizzBuzzLib.Items." + itemType + "Item")) as IFizzBuzzItem;
                optionItem.Value = item;
                result.Add(optionItem);
            });

            return result;
        }
    }
}
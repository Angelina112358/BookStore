using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class OrderDelivery
    {
        public string UniqueCode { get; }
        public string Description { get; }
        public decimal Price { get; }
        public IReadOnlyDictionary<string, string> Parameters { get; }
        public OrderDelivery(string uniqueCode, string descriprion, decimal price,
                             IReadOnlyDictionary<string, string> parametrs)
        {
            if (string.IsNullOrWhiteSpace(uniqueCode))
                throw new ArgumentException(null, nameof(uniqueCode));

            if (string.IsNullOrWhiteSpace(descriprion))
                throw new ArgumentException(null, nameof(descriprion));

            if (parametrs == null)
                throw new ArgumentException(null, nameof(parametrs));

            UniqueCode = uniqueCode;
            Description = descriprion;
            Price = price;
            Parameters = parametrs;
        }
    }
}

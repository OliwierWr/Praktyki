using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waluta.Klasa
{
    internal class ExchangeRatesSeries
    {
        public string Table { get; set; }
        public string Waluta { get; set; }
        public string Code { get; set; }
        public ICollection<Rate> Rates { get; set; }

        public override string ToString()
        {
            return $"Table: {Table} Code{Code}";
        }
    }
}

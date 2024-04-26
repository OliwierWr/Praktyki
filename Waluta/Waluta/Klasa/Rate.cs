using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waluta.Klasa
{
    internal class Rate
    {
        public string Number {  get; set; }
        public string EffectiveDate {  get; set; }
        public string Bid {  get; set; }
        public string Ask { get; set; }
        public override string ToString()
        {
            return $"{EffectiveDate} Bid:{Bid} Ask:{Ask}";
        }
    }
}

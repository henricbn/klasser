using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Namn
    {
        public string förnamn { get; set; }
        public string efternamn { get; set; }
        public string date { get; set; }
        public string föroeft { get { return förnamn + " " +  efternamn; } }
    }
}

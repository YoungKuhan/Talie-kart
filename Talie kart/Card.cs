using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talie_kart
{
    class Card
    {
        public Values Value { get; set; }
        public Suits Suit { get; set; }
        public string Name { get { return $"{Value} {Suit}"; } }
        public Card(Values value, Suits suits) { Value = value;Suit = suits; }
    }
}

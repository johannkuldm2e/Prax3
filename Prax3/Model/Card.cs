using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Prax3.Model
{
    public class Card
    {
        public Card(string cardStatus, string cardType)
        {
        }
        public string CardType { get; set; }


        public string CardStatus { get; set; }

        public int CardNumber = 1234;
    }
}


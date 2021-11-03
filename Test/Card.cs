using System;

namespace CardApplication
{
    public class Card
    {
        public Recipient Recipt { get; set; }
        public Sender Sender { get; set; }
        public string Messagge { get; set; }

        public Card() { }
    }
}

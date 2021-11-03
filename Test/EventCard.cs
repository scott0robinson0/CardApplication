using System;
using System.Collections.Generic;
using System.Text;

namespace CardApplication
{
    public class EventCard : Card
    {
        public string Date { set; get; }

        public EventCard() {
            Message = "Come to the event!";
        }
        public EventCard(string message)
        {
            Message = message;
        }

    }
}

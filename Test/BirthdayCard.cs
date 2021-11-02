using System;
using System.Collections.Generic;
using System.Text;

namespace CardApplication
{
    public class BirthdayCard : Card
    {
        public BirthdayCard() {
            Message = "Happy Birthday!";
        }
        public BirthdayCard(string message) {
             Message = message;
        }
    }
}

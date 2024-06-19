using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationOOPS
{
    class EncapsulationPro
    {
        string CardType;
        string CardHolder;
        string CardNumber;
        string Cardexpiry;
        string Gender;
        string DateOfBirth;
        internal EncapsulationPro(string cardType, string cardHolder,string cardNumber, string cardexpiry, string gender, string dateOfBirth) 
        {
            CardType = cardType;
            CardHolder = cardHolder;
            CardNumber = cardNumber;
            Cardexpiry = cardexpiry;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }
        internal void Display()
        {
            Console.WriteLine("Customer Type of the card is {0}", CardType);
            Console.WriteLine("Card Holder name is {0}", CardHolder);
            Console.WriteLine("Customer card number is {0}", CardNumber);
            Console.WriteLine("Card expiry date is {0}", Cardexpiry);
            Console.WriteLine("customer gender is {0}", Gender);
            Console.WriteLine("date of birth of customer {0}", DateOfBirth);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EncapsulationPro p = new EncapsulationPro("PANCARD", "Radha", "AWEYL234R", "20/06/2025", "Female", "14/01/1998");
            p.Display();
            Console.ReadLine();
        }
    }
}

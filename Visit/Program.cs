using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visit
{
    abstract class GuestVisit
    {
        public void Guestwelcomemessage()
        {
            Console.WriteLine("Welcome to our house");
        }

        public void GuestName()
        {
            Console.WriteLine("Guest name is Ramu");
        }
        public abstract void purposeofVisit();
    }

    class Program:GuestVisit
    {
        static void Main(string[] args)
        {
            Program h1 = new Program();
            h1.Guestwelcomemessage();
            Console.ReadKey();
        }

        public override void purposeofVisit()
        {
            Console.WriteLine("Just came here to spend some time");
            
        }

    }
}

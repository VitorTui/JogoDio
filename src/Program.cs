using System;
using Vitor_Silva.src.Entities;

namespace Vitor_Silva
{

  class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new  Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard(" Jennica", 23, " White Wizard");
            Ninja  wedge = new Ninja(" Wedge", 42, "Ninja");
            BlackWizard topapa = new BlackWizard(" Topapa", 42, "BlackWizard");
            
            Console.WriteLine(wizard.Attack(13));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(wedge.Attack(7));
            Console.WriteLine(topapa.Attack(77));
        }
    }
}

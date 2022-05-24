using System;
using Vitor_Silva.src.Entities;

namespace Vitor_Silva
{

  class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus("Arus", 23, "Knight");
            Arus wizard = new Arus("Jennica", 23, "white Wizard");
           
            Console.Write(wizard.Attack());
           
        }
    }
}

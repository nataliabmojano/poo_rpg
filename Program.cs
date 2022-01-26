
using System;
using GFT.Modelo.CRC.Modelo;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Arus = new Hero ("Arus", 23, "Knight");
            Wizard Wizard  = new Wizard ("Jennica" , 23, "White");
    
         Console.WriteLine(Arus.Attack());
         Console.WriteLine(Wizard.Attack(1));
        }
    
    }

}
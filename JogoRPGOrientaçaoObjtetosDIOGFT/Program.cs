using System;
using JogoRPGOrientaçãoObjetos.src.Entities;


namespace JogoRPGOrientaçãoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            BlackWizard Topapa = new BlackWizard("Topapa", 23, "BlackWizard");
            Ninja Wedge = new Ninja("Wedge", 23, "Ninja");

            Console.WriteLine(wizard.Attack(1));

            Console.WriteLine(wizard.Attack(7));

            
        }
    }
}

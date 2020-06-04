using System;

namespace PolimorfismoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Mario : ");
        Mario mario = new Mario();
        mario.Correr();
        mario.Pular();

        System.Console.WriteLine("Yoshi : ");
        Yoshi yoshi = new Yoshi();
        yoshi.Correr();
        yoshi.Pular();
        }
    }
}

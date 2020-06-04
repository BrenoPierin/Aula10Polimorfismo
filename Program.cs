using System;

namespace Aula10Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new Mario();
            mario.Correr();
            mario.Pular();

            System.Console.WriteLine("------------------------------------------------------");

            Luigi luigi = new Luigi();
            luigi.Correr();
            luigi.Pular();
        }
    }
}

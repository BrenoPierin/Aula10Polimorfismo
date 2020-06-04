namespace Aula10Polimorfismo
{
    public class Player
    {
        //Classe de configuração basica de personagens

        public virtual void Pular(){
            System.Console.WriteLine("Personagem pulando normalmente");
        }

        public virtual void Correr(){
            System.Console.WriteLine("Personagem correndo normalmente");
       }
    }
}
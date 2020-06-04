namespace Aula10Polimorfismo
{
    public class Luigi : Player
    {

        //Personagem com metodos herdados da classe player
        public override void Pular(){

            base.Pular();

            System.Console.WriteLine("O personagem está pulando mais alto");
        }
        //modificação feita no pulodo personagem
    }
}
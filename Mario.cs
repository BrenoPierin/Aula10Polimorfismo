namespace Aula10Polimorfismo
{
    public class Mario : Player
    {
        //classe de personagens herdando e modificando metodos da classe pai
        public override void Correr(){
            System.Console.WriteLine("O personagem está correndo mais rapido!");
        }
        //Metodo configurado para mostrar que ele está correndo mais rapido
    }
}
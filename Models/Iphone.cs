namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class IPhone : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo {nomeApp} foi instalado no IPhone");
        }
    }
}
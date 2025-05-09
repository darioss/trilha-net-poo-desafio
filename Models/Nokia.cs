namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string nome, string imei, int memoria)
        : base(numero, nome, imei, memoria)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} a partir da Play Store.");
        }
    }
}
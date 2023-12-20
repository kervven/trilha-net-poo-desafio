namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando app {nomeApp}...");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine($"{nomeApp} instalado com sucesso.");
        }

        public override void ToString()
        {
            base.ToString();
        }
    }
}
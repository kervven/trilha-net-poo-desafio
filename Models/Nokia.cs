namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp}...");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"Aplicativo instalado com sucesso");
        }

        public override void ToString()
        {
            base.ToString();
        }
    }
}
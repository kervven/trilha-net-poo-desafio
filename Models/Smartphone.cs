namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar(string numero)
        {
            Console.WriteLine($"Ligando para {numero}");
        }

        public void desligarLigacao(){

            Console.WriteLine("Ligação encerrada");
        }

        public void ReceberLigacao(string numero)
        {
            Console.WriteLine($"Recebendo ligação de {numero}");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public new virtual void  ToString(){
            Console.WriteLine($"Smartphone {Modelo} com imei {IMEI} com capaciade de amarzenamento de {Memoria} gigas está disponível para uso! \n");
        }
    }
}
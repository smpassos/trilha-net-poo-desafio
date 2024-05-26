namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementado
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // Implementado
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
            //Console.WriteLine($"Número: {Numero}");
            //Console.WriteLine($"Modelo: {Modelo}");
            //Console.WriteLine($"IMEI: {IMEI}");
            //Console.WriteLine($"Memória: {Memoria}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
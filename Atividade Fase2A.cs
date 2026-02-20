using System;
class Program
{
    static void Main(string[] args)
    {

        Fase2.Banco Banco = new Fase2.Banco();
        Banco.Nome = "Banco do Brasil";
        Banco.CodigoBACEN = "001";


        Fase2.Transacao minhaTransacao = new Fase2.Transacao();
        minhaTransacao.Valor = 250.00m;
        minhaTransacao.Data = DateTime.Now;
        minhaTransacao.Tipo = "PIX";


        Console.WriteLine("--- REGISTRO BACEN ---");
        Console.WriteLine("Banco: " + Banco.Nome);
        Console.WriteLine("Código: " + Banco.CodigoBACEN);
        Console.WriteLine("---------------------");
        Console.WriteLine("Tipo: " + minhaTransacao.Tipo);
        Console.WriteLine("Valor: R$ " + minhaTransacao.Valor);
        Console.WriteLine("Data: " + minhaTransacao.Data);
    }

        public class ContaBancaria
    {
        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public decimal Saldo { get; private set; }
    }
}

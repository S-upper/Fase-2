using Fase3;
using System;
using System.Runtime.Intrinsics.X86;
class Program
{
    static void Main(string[] args)
    {

        Fase3.Banco Banco = new Fase3.Banco();
        Banco.Nome = "Banco do Brasil";
        Banco.CodigoBACEN = "001";


        Fase3.Transacao minhaTransacao = new Fase3.Transacao();
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

           static void M(string[] args)
        {
            var conversor = new ConversorGrandezas(new ConversorMilhoes());

            var resultado = conversor.Converter(5000000);

            Console.WriteLine(resultado);
        }
    
}
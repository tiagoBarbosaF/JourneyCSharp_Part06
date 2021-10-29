using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objects

            ContaCorrente conta = new ContaCorrente(987,987654);
            Console.WriteLine(conta);

            Console.ReadLine();

            Cliente tiago_1 = new Cliente
            {
                Nome = "Tiago",
                CPF = "987.654.321-98",
                Profissao = "Desenvolvedor"
            };

            Cliente tiago_2 = new Cliente
            {
                Nome = "Tiago",
                CPF = "987.654.321-98",
                Profissao = "Desenvolvedor"
            };

            if( tiago_1.Equals(tiago_2) )
            {
                Console.WriteLine("São iguais");
            }
            else
            {
                Console.WriteLine("Não são iguais");
            }

            Console.ReadLine();



            // Regex - Regular expressions

            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4}[-][0-9]{4}";
            //string padrao = "[0-9]{4}-[0-9]{4}";
            //string padrao = "[0-9]{4,5}-[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            string texto = "Meu número é: 998743579";
            Match match = Regex.Match(texto,padrao);
            Console.WriteLine(match.Value);


            Console.ReadLine();

            // Strings
            string url = "www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);

            string moedaOrigem = extrator.GetValor("MOEDAORIGEM");
            string moedaDestino = extrator.GetValor("moedaDestino");
            string valor = extrator.GetValor("valor");

            Console.WriteLine($"Moeda Origem = {moedaOrigem}");
            Console.WriteLine($"Moeda Destino = {moedaDestino}");
            Console.WriteLine($"Valor = {valor}");

            Console.ReadLine();
        }
    }
}

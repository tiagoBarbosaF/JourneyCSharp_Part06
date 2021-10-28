using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main( string[] args )
        {
            string url = "pagina?argumentos";

            //Console.WriteLine(argumentos);

            int indiceInterrogacao = url.IndexOf('?');
            string argumentos = url.Substring( indiceInterrogacao + 1 );
            Console.WriteLine( argumentos );

            Console.ReadLine();
        }
    }
}

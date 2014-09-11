using System;
using System.Collections.Generic;

using System.Text;
using CPFData;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf = Console.ReadLine();
            Console.WriteLine( clsCPFData.isCPF_Mod11(cpf).ToString()
                );
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Signos
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            string mes;
            

            Console.WriteLine("Em que dia você nasceu? ");
            dia = Console.ReadLine();

            Console.WriteLine("Em que mês você nasceu? ");
            mes = Console.ReadLine();

            int diaInt = 0;
            int mesInt = 0;
            try
            {
               diaInt = Convert.ToInt32(dia);
               mesInt = Convert.ToInt32(mes);

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                Environment.Exit(1);
                
            }
            
            
            InterpretadorSigno interpretador = new InterpretadorSigno();
            Signo signo = interpretador.interpretar(diaInt, mesInt);

            if (signo != null)
            {
                Console.WriteLine("Seu signo é " + signo.nome + " " + signo.caracteristicas);
            }
            else
            {
                Console.WriteLine("Não foi possível interpretar seu signo. Tente novamente.");
            }
            Console.ReadKey();
            


        }
    }
}

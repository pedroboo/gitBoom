using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

using atividade01.Model;

namespace atividade01
{
    class Program
    {
        static void Main(string[] args)
        {



            Vendedore v = new Vendedore(10);

        
            Console.WriteLine("0 - Sair \n 1 - Cadastrar Vendedor\n 2 - Consultar Vendedor \n 3 - Excluir Vendedor" +
                "\n 4 - Registrar Venda \n 5 - Listar Vendedores");



            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 0: break;
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: break;


            }
            Console.Clear();

        
            Console.ReadKey();
        }
    }
}

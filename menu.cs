using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filades
{
    class menu  : atendimento
    {
        string op = "";
        atendimento obj = new atendimento();
        public void opcao()
        {
            Console.WriteLine("/---ATENDIMENTO HOSPITALAR---/");

            do
            {
                Console.WriteLine("\n\n 1 adicionar paciente \n 2 - listar paciente \n 3 - atender paciente \n 4 - editar dados \n q - fechar programa.");
                op = Console.ReadLine();

                switch(op){
                    case "1":
                        obj.registrar();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                }
                
            } while (op != "q");
        }
    }
}

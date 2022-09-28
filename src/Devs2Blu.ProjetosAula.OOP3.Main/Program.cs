using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main
{
    class Program
    {
        public static Mocks Mock { get; set; }
        static void Main(string[] args)
        {
            Int32 opcao = 0, opcaoMenuCadastros = 0;
            Mock = new Mocks();
            IMenuCadastro menuCadastro;

            do
            {
                
                if(opcaoMenuCadastros.Equals((int)MenuEnums.SAIR))
                    {
                    if (opcao.Equals)

                    Console.WriteLine("              -----═ +Devs2BLU - C# ═-----\n");
                    Console.WriteLine("   ╔═════════════════════════════════════════════════╗ ");
                    Console.WriteLine("   ║       Sistema de Gerencimento de Clínicas       ║ ");
                    Console.WriteLine("   ║       10- Cadastro de Pacientes                 ║ ");
                    Console.WriteLine("   ║       20- Cadastro de Médicos                   ║ ");
                    Console.WriteLine("   ║       30- Cadastro de Recepcionistas            ║ ");
                    Console.WriteLine("   ║       40- Cadastro de Fornecedores              ║ ");
                    Console.WriteLine("   ║       50- Agenda                                ║ ");
                    Console.WriteLine("   ║       60- Prontuário                            ║ ");
                    Console.WriteLine("   ║       70- Financeiro                            ║ ");
                    Console.WriteLine("   ║                                                 ║ ");
                    Console.WriteLine("   ║       0- Sair                                   ║ ");
                    Console.WriteLine("   ╚═════════════════════════════════════════════════╝ ");
                    Int32.TryParse(Console.ReadLine(), out opcao);

                    switch (opcao)
                    {
                        case (int)MenuEnums.CAD_PAC:
                            menuCadastro = new CadastroPaciente();
                            opcaoMenuCadastros = menuCadastro.MenuCadastro();
                            break;

                        case (int)MenuEnums.CAD_REC:
                            menuCadastro = new CadastroRecepcionista();
                            opcaoMenuCadastros = menuCadastro.MenuCadastro();
                            break;

                        case (int)MenuEnums.CAD_FOR:
                            menuCadastro = new CadastroFornecedor();
                            opcaoMenuCadastros = menuCadastro.MenuCadastro();
                            break;

                        case (int)MenuEnums.CAD_MED:
                            menuCadastro = new CadastroMedico();
                            opcaoMenuCadastros = menuCadastro.MenuCadastro();
                            break;
                        default:
                            opcaoMenuCadastros = 0;
                            break;
                    }
                }
            } while (!opcao.Equals(MenuEnums.SAIR));
        }   
       
    }
}




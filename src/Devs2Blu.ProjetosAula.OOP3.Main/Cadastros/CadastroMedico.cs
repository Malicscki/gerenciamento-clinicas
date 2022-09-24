using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroMedico
    {
        public CadastroMedico()
        {

        }

        public void MenuCadastro()
        {
            Int32 opcao;

            do
            {
                
                Console.WriteLine("----- Cadastro de Médicos -----");
                Console.WriteLine("----- 1- Lista de Médicos -----");
                Console.WriteLine("----- 2- Cadastro de Médico -----");
                Console.WriteLine("----- 3- Alterar Médico -----");
                Console.WriteLine("---------------------");
                Console.WriteLine("----- 0- Sair -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarMedicos();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals(MenuEnums.SAIR));
        }

        public void ListarMedicos()
        {
            Console.Clear();

            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Médico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine("-----------------------------------------\n");
            }
        }

        public void CadastrarMedico()
        {

        }

        public void AlterarMedico()
        {

        }

        public void ExcluirMedico()
        {

        }
    }
}


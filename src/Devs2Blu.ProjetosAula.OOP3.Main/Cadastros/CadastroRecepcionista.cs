using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroRecepcionista : IMenuCadastro
    {
        public CadastroRecepcionista()
        {

        }

        public void MenuCadastro()
        {
            Int32 opcao;

            do
            {

                Console.WriteLine("----- Cadastro de Recepcionista -----");
                Console.WriteLine("----- 1- Lista de Recepcionistas -----");
                Console.WriteLine("----- 2- Cadastro de Recepcionista -----");
                Console.WriteLine("----- 3- Alterar Recepcionista -----");
                Console.WriteLine("---------------------");
                Console.WriteLine("----- 0- Sair -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarRecepcionistas();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals(MenuEnums.SAIR));
        }

        public void ListarRecepcionistas()
        {
            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine("-----------------------------------------\n");
            }
        }

        public void CadastrarRecpecionista(Recepcionista novoRecepcionista)
        {
            Program.Mock.ListaRecepcionistas.Add(novoRecepcionista);
        }

        public void AlterarRecepcionista()
        {

        }

        public void ExcluirRecepcionista()
        {

        }

        int IMenuCadastro.MenuCadastro()
        {
            throw new NotImplementedException();
        }

        public void Listar()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar()
        {
            throw new NotImplementedException();
        }

        public void Alterar()
        {
            throw new NotImplementedException();
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }
    }
}


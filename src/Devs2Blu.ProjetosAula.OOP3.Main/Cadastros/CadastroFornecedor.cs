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
    public class CadastroFornecedor
    {
        public CadastroFornecedor()
        {

        }

        public void MenuCadastro()
        {
            Int32 opcao;

            do
            {

                Console.WriteLine("----- Cadastro de Fornecedores -----");
                Console.WriteLine("----- 1- Lista de Fornecedores -----");
                Console.WriteLine("----- 2- Cadastro de Fornecedor -----");
                Console.WriteLine("----- 3- Alterar Fornecedor -----");
                Console.WriteLine("---------------------");
                Console.WriteLine("----- 0- Sair -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarFornecedores();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals(MenuEnums.SAIR));
        }

        public void ListarFornecedores()
        {
            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Fornecedor: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"Tipo: {fornecedor.TipoFornecedor}");
                Console.WriteLine($"CNPJ: {fornecedor.CGCCPF}");
                Console.WriteLine("-----------------------------------------\n");
            }
        }

        public void CadastrarFornecedor()
        {

        }

        public void AlterarFornecedor()
        {

        }

        public void ExcluirFornecedor()
        {

        }
    }
}


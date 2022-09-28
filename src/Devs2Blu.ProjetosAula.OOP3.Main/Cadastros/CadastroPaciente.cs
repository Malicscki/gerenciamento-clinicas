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
    public class CadastroPaciente : IMenuCadastro
    {
        public CadastroPaciente()
        {
            //teste commit
        }

        public Int32 MenuCadastro()
        {
                Int32 opcao;
                Console.Clear();
                Console.WriteLine("   ╔═════════════════════════════════════════════════╗");
                Console.WriteLine("   ║        Cadastro de Pacientes                    ║");
                Console.WriteLine("   ║        1- Lista de Pacientes                    ║");
                Console.WriteLine("   ║        2- Cadastro de Pacientes                 ║");
                Console.WriteLine("   ║        3- Alterar Pacientes                     ║");
                Console.WriteLine("   ║                                                 ║");
                Console.WriteLine("   ║        0- Sair                                  ║");
                Console.WriteLine("   ╚═════════════════════════════════════════════════╝ ");
                Int32.TryParse(Console.ReadLine(), out opcao);
                return opcao;
             }
        public void Listar()
        {
            ListarPacientes();
        }

       public void Cadastrar(Pessoa pessoa)
        {
            CadastrarPaciente((Paciente)pessoa);
        }

        public void Alterar(Pessoa pessoa)
        {
            AlterarPaciente((Paciente)pessoa);
        }

        public void Excluir(Pessoa pessoa)
        {
            ExcluirPaciente((Paciente)pessoa);
        }

        private void ListarPacientes()
        {
            throw new NotImplementedException();
        }
        private void CadastrarPaciente(Paciente novoPaciente)
        {
            Program.Mock.ListaPacientes.Add(novoPaciente);
        }

        private void AlterarPaciente(Paciente paciente)
        {

        }

        private void ExcluirPaciente(Paciente paciente)
        {

        }
    }
}
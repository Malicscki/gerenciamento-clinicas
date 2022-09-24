using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public List<Paciente> ListaPacientes { get; set; }
        public List<Medico> ListaMedicos { get; set; }
        public List<Recepcionista> ListaRecepcionistas { get; set; }
        public List<Fornecedor> ListaFornecedores { get; set; }

        public Mocks() //teste commit 24/09
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            CargaMock();
        }
        public void CargaMock()
        {
            CargaPacientes();
            CargaMedicos();
            CargaRecepcionistas();
            CargaFornecedores();    
        }

        public void CargaPacientes()
        {
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i + 1}", $"{i}23{i}56{i}891{i}", "Unimed");
                ListaPacientes.Add(paciente);
            }
        }

        public void CargaRecepcionistas()
        {
            Random rd = new Random();
            String[] setor = { "Raio X", "UTI", "Ginecologista", "Obstetricia" };
            for (int i = 0; i < 5; i++)
            {
                Recepcionista recepcionista = new Recepcionista(i, $"Recepcionista {i + 1}", $"{i}10{i}20{i}30{i}", rd.Next(321, 789), setor[rd.Next(0, 3)]);
                ListaRecepcionistas.Add(recepcionista);
            }
        }
        public void CargaMedicos()
            {
                Random rd = new Random();
                String[] especialidades = { "Clínico Geral", "Neurologista", "Ginecologista", "Obstetra" };
                for (int i = 0; i < 4; i++)
                {
                   Medico medico = new Medico(i, $"Médico {i + 1}", $"{i}10{i}20{i}30{i}",rd.Next(321,789) , especialidades [rd.Next(0,3)]);
                   ListaMedicos.Add(medico);
                }
            }
        public void CargaFornecedores()
        {
            Random rd = new Random();
            String[] tipoFornecedor = { "Material Hospitalar", "Prestador de Serviço", "Equipamentos", "Limpeza" };
            for (int i = 0; i < 5; i++)
            {
                Fornecedor fornecedor = new Fornecedor(i, $"Fornecedor {i + 1}", $"{i}10{i}20{i}30{i}", rd.Next(321, 789), tipoFornecedor[rd.Next(0, 3)]);
                ListaFornecedores.Add(fornecedor);
            }
        }
    }
    } 


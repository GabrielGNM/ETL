﻿using CamadaDeDados.Context;
using CamadaDeDados.Models;

namespace CamadaDeDados
{
    public class AcessoBancoDeDados
    {
        //public List<Account> ExtractExemploData()
        //{
        //    // Lógica de extração de dados, pode ser consulta a um banco de dados, leitura de arquivo, etc.
        //    // Retornar dados brutos, por exemplo, de um banco de dados
        //    var rawData = new List<Account>();
        //    using (var dbContext = new TechMuseDbContext())
        //    {
        //        // Obter todos os registros da tabela Account
        //        var accounts = dbContext.Accounts.ToList();
        //        rawData = accounts;
        //        // Agora, 'accounts' contém todos os registros da tabela Account
        //    }
        //    return rawData;
        //}
        public List<PacienteModel> ExtractPacienteData()
        {
            // Lógica de extração de dados, pode ser consulta a um banco de dados, leitura de arquivo, etc.
            // Retornar dados brutos, por exemplo, de um banco de dados
            var listaPacientes = new List<PacienteModel>();
            using (var dbContext = new ClinicaGardenDbContext())
            {
                // Obter todos os registros da tabela Account
                var retorno = dbContext.Pacientes.ToList();
                listaPacientes = retorno;
                // Agora, 'accounts' contém todos os registros da tabela Account
            }
            return listaPacientes;
        }
        public List<AgendamentoModel> ExtractAgendamentoData()
        {
            // Lógica de extração de dados, pode ser consulta a um banco de dados, leitura de arquivo, etc.
            // Retornar dados brutos, por exemplo, de um banco de dados
            var listaAgendamentos = new List<AgendamentoModel>();
            using (var dbContext = new ClinicaGardenDbContext())
            {
                // Obter todos os registros da tabela Account
                var retorno = dbContext.Agendamentos.ToList();
                listaAgendamentos = retorno;
                // Agora, 'accounts' contém todos os registros da tabela Account
            }
            return listaAgendamentos;
        }
        public List<DescarteEcologicoModel> ExtractDescarteEcologicoData()
        {
            // Lógica de extração de dados, pode ser consulta a um banco de dados, leitura de arquivo, etc.
            // Retornar dados brutos, por exemplo, de um banco de dados
            var listaDescartesEcologicos = new List<DescarteEcologicoModel>();
            using (var dbContext = new ClinicaGardenDbContext())
            {
                // Obter todos os registros da tabela Account
                var retorno = dbContext.DescartesEcologicos.ToList();
                listaDescartesEcologicos = retorno;
                // Agora, 'accounts' contém todos os registros da tabela Account
            }
            return listaDescartesEcologicos;
        }

        public void LoadData(List<string> transformedData)
        {
            // Lógica de carregamento de dados, por exemplo, inserção em um banco de dados
            foreach (var data in transformedData)
            {
                // Lógica de inserção
                Console.WriteLine($"Dado carregado: {data}");
            }
        }
    }

}
﻿using CH.ExamesConsultas.UI.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace CH.ExamesConsultas.UI.Data
{
    internal class DbInitializer : CreateDatabaseIfNotExists<CHExamesConsultasDataContext>
    {
        protected override void Seed(CHExamesConsultasDataContext context)
        {
            var pacientes = new List<Paciente>() {
                new Paciente() { Id = 1, Nome = "José", CPF = 12356789040, DataNasc = 12/12/1985, Sexo = "M", Telefone = "(81)3439-5586", Email = "paciente91@gmail.com"},
                new Paciente() { Id = 2, Nome = "Mauro", CPF = 12376789040, DataNasc = 13/10/1986, Sexo = "M", Telefone = "(81)3439-5588", Email = "paciente12@gmail.com"},
                new Paciente() { Id = 3, Nome = "Alberto", CPF = 12356729040, DataNasc = 03/09/1987, Sexo = "M", Telefone = "(81)3439-7786", Email = "paciente99@gmail.com"},
                new Paciente() { Id = 4, Nome = "Kleber", CPF = 12356729089, DataNasc = 12/10/1989, Sexo = "M", Telefone = "(81)3439-7783", Email = "paciente87@gmail.com"},
                };

            context.Pacientes.AddRange(pacientes);
            context.SaveChanges();
        }
        ///{
           /// var consultas = new List<Consulta>() {
              ///  new Consulta() { Id = 1, Nome = "José", Tipodeexame = "A", Descricao = "Esta consulta foi marcada para o dia 20"},
                ///new Consulta() { Id = 2, Nome = "Maria", Tipodeexame = "B", Descricao = "Esta consulta foi marcada para o dia 22"},
                ///new Consulta() { Id = 3, Nome = "Antonio", Tipodeexame = "C", Descricao = "Esta consulta foi marcada para o dia 27"},
                
                ///};

            ///context.Consultas.AddRange(consultas);
            ///context.SaveChanges();
        ///}

    }
}
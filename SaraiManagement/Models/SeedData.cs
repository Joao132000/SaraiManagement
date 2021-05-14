using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using SaraiManagement.Models.Enuns;

namespace SaraiManagement.Models.Classes
{
    public class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.Alunos.Any())
            {
                context.Alunos.AddRange(
                    new Aluno
                    {
                        Nome = "Davi da Silva Nascimento",
                        DataNascimento = Convert.ToDateTime("15-06-1998"),
                        Escola = "E.E. Padre José Grimminck",
                        Ano = Ano.Quinto,
                        Endereco = "Rua Barroso 244 Recreio Vale do Sol ",
                        Cidade = "Alfenas.MG",
                        NomeResponsavel = "Eliano Cordeiro",
                        Período = "Noturno",
                        Admissao = Convert.ToDateTime("10-05-2021"),
                        DonatarioID = 1
                    }); ;
            }
            if (!context.Caixas.Any())
            {
                context.Caixas.AddRange(
                  new Caixa
                  {
                      CaixaID = 1,
                      Saldo = 10000,
                      Descricao = "aaa"

                  });
            }

            if (!context.Doacaos.Any())
            {
                context.Doacaos.AddRange(
                  new Doacao
                  {
                      DonatarioID = 1,
                      DoacaoID = 1,

                  });
            }
            if (!context.Doadors.Any())
            {
                context.Doadors.AddRange(
                  new Doador
                  {
                      Nome = "João Paulo Carvalho",
                      Endereco = "AV São José 2080 Centro",
                      Cidade = "Alfenas.MG",
                      regularidadeDoador = Regularidade.Unico,
                      inicioDaDoacao = Convert.ToDateTime("10-05-2021")
                  });
            }
            if (!context.Donatarios.Any())
            {
                context.Donatarios.AddRange(
                  new Donatario
                  {
                      DonatarioID = 1,
                      Email = "teste@gmail.com",
                      Endereco = "Rua da Prainha,27 - Jd Alvorada",
                      Telefone = "(35) 99888-1355",
                      Nome = "Eliano Cordeiro"
                  });
            }
            if (!context.Movimentacaos.Any())
            {
                context.Movimentacaos.AddRange(
                  new Movimentacao
                  {
                      MovimentacaoID = 1,
                      Descricao = "Arrumar parede da Classe",
                      DiaMovimentacao = Convert.ToDateTime("15-06-2021"),
                      TipoMovimentacao = tipoMovimentacao.Debito,
                      Valor = 1000.50,
                      CaixaID = 1
                  });
            }
            
            if (!context.Usuarios.Any())
            {
                context.Usuarios.AddRange(
                  new Usuario
                  {
                      UsuarioID = 1,
                      Nome = "Davi Nascimento",
                      Senha = "123",
                      Tipo = tipoUsuario.User
                  });
            }
            if (!context.ItemDoados.Any())
            {
                context.ItemDoados.AddRange(
                  new ItemDoado
                  {
                      ItemDoadoID = 1,
                      EstoqueID =1,
                      DoacaoID =1,
                      Quantidade = 1,
                      
                  });
            }
            if (!context.Estoques.Any())
            {
                context.Estoques.AddRange(
                  new Estoque
                  {
                      EstoqueID=1,
                      Descricao="aaa",
                      Quantidade=1

                  });
            }
            context.SaveChanges();
        }
    }
}

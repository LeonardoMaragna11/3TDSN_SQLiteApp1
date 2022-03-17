using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using App1.Models;
using System.Threading.Tasks;

namespace App1.Data
{
    public class Banco
    {
        readonly SQLiteAsyncConnection conexao;
        public Banco(string arquivo)
        {
            conexao = new SQLiteAsyncConnection(arquivo);
            conexao.CreateTableAsync<Computador>().Wait();
        }

        public Task<int> SalvarComputador(Computador computador)
        {
            if (computador.ID == 0)
            {
                return conexao.InsertAsync(computador);
            }
            else
            {
                return conexao.UpdateAsync(computador);
            }
        }
    }
}

using App1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Services
{
    public class RegistroBase
    {
        static void CadastrarComputador()
        {
            var computador1 = new Computador()
            {
                Processador = "AMD Ryzen PRO",
                USB = 6,
                Atualizado = false
            };
            var computador2 = new Computador()
            {
                Processador = "Intel i5",
                USB = 4,
                Atualizado = true,
                DataAtualizacao = new DateTime(2022,2,28)
            };
            App.Banco.SalvarComputador(computador1);
            App.Banco.SalvarComputador(computador2);
        }
    }
}

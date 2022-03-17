using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class Computador
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Processador { get; set; }
        public int USB { get; set; }
        public bool Atualizado { get; set; }
        public DateTime DataAtualizacao { get; set; }

    }
}

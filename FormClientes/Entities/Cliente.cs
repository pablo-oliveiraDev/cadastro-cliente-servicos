using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entities;
using Npgsql;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;



namespace Entities
{
    [Table("cliente",Schema ="public")]
    public class Cliente
    {
        
        public int IdCliente { get; set; }
        public string Name { get; set; }
        public string Endereco { get; set; }
        public DateTime DataEntrada { get; set; }

        public Cliente()
        {

        }

        public Cliente(int idCliente, string name, string endereco, DateTime dataEntrada)
        {
            IdCliente = idCliente;
            Name = name;
            Endereco = endereco;
            DataEntrada = dataEntrada;
        }
        
    }
}
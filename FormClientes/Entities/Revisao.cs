using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entities;
using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data;

namespace Entities
{
    [Table("revisao", Schema = "public")]
    public class Revisao : Servicos
    {

        public int IdRevisao { get; set; }
        public DateTime DataRevisao { get; set; }

        public Servicos servicos { get; set; }
        public Cliente Cliente { get; set; }


        public Revisao()
        {

        }
        public Revisao(int idCliente, string name, string endereco, DateTime dataEntrada, int idServicos, string nameServico, string equipamento, string pecasTrocadas,
            string sevicosExecutados,
            double valorDoServico, double desconto, DateTime dataServico,string defeitos, int idRevisao, DateTime dataRevisao) : base(idCliente, name, endereco, dataEntrada,
            idServicos,nameServico,equipamento,pecasTrocadas,sevicosExecutados,valorDoServico,desconto,dataServico,defeitos)
        {
            IdRevisao = idRevisao;
            DataRevisao = dataRevisao;


        }

    }
}


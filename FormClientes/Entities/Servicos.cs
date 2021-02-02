using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entities;
using Npgsql;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Entities
{
    [Table("servicos", Schema = "public")]
    public class Servicos : Cliente
    {

        public int IdServicos { get; set; }
        public string NameServico { get; set; }
        public string Equipamento { get; set; }
        public string PecasTrocadas { get; set; }
        public string SevicosExecutados { get; set; }
        public double ValorDoServico { get; set; }
        public double Desconto { get; set; }
        public Cliente cliente { get; set; }


        public DateTime DataServico { get; set; }
        public double ValTotal { get; private set; }
       

        public Servicos()
        {

        }


        public Servicos(int idCliente, string name, string endereco, DateTime dataEntrada, int idServicos, string nameServico, string equipamento, string pecasTrocadas,
            string sevicosExecutados,
            double valorDoServico, double desconto, DateTime dataServico) : base(idCliente, name, endereco, dataEntrada)
        {
            IdServicos = idServicos;
            NameServico = nameServico;
            Equipamento = equipamento;
            PecasTrocadas = pecasTrocadas;
            SevicosExecutados = sevicosExecutados;
            ValorDoServico = valorDoServico;
            Desconto = desconto;
            DataServico = dataServico;
           
        }


       /* public void NumberCliente(string TextIdCliente)
        {
            int text = int.Parse(TextIdCliente);
            DataContext dataContext = new DataContext();
            dataContext.servicos.ToList().ForEach(x => x.IdCliente = text);

        }*/
        public double ValorTotal()
        {
            return ValorDoServico -= ValorDoServico * (Desconto / 100);
        }
    }
}

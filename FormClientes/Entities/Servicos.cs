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
        public int id_cliente { get; set; }
        public int id_servicos { get; set; }
        public string nameservice { get; set; }
        public string equipamento { get; set; }
        public string pecastrocadas { get; set; }
        public string executservices { get; set; }
        public double valservice { get; set; }
        public double desconto { get; set; }
        public Cliente cliente { get; set; }
        public string defeito { get; set; }

        public DateTime DataServico { get; set; }
        public double ValTotal { get; private set; }
        

        public Servicos()
        {

        }


        public Servicos(int idCliente, string name, string endereco, DateTime dataEntrada, int idServicos, string nameServico, string equipamentos, string pecasTrocadas,
            string sevicosExecutados,
            double valorDoServico, double descontos, DateTime dataServico,string defeitos) : base(idCliente, name, endereco, dataEntrada)
        {
            id_servicos = idServicos;
            nameservice = nameServico;
            equipamento = equipamentos;
            pecastrocadas = pecasTrocadas;
            executservices = sevicosExecutados;
            valservice = valorDoServico;
            desconto = descontos;
            DataServico = dataServico;
            defeito = defeitos;
           
        }


       /* public void NumberCliente(string TextIdCliente)
        {
            int text = int.Parse(TextIdCliente);
            DataContext dataContext = new DataContext();
            dataContext.servicos.ToList().ForEach(x => x.IdCliente = text);

        }*/
        public double ValorTotal()
        {
            return valservice -= valservice * (desconto / 100);
        }
    }
}

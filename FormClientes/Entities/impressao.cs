using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormClientes.Entities
{
    public class Impressao
    {
        public string NomeCliente { get; set; }
        public string NomeDoServico { get; set; }
        public string DataDoServico { get; set; }
        public string ValorTotal { get; set; }
        public string IdCliente { get; set; }
        public string IdServicos { get; set; }
        public string Equipamento { get; set; }
        public string PecasTrocadas { get; set; }
        public string ValorServico { get; set; }
        public string Desconto { get; set; }
        public string ExeServ { get; set; }
        public Impressao()
        {

        }

        public Impressao(string nomeCliente, string nomeDoServico, string dataDoServico, string valorTotal,
            string idCliente, string idServicos, string equipamento, string pecasTrocadas, string valorServico, string desconto,string exeServ)
        {
            NomeCliente = nomeCliente;
            NomeDoServico = nomeDoServico;
            DataDoServico = dataDoServico;
            ValorTotal = valorTotal;
            IdCliente = idCliente;
            IdServicos = idServicos;
            Equipamento = equipamento;
            PecasTrocadas = pecasTrocadas;
            ValorServico = valorServico;
            Desconto = desconto;
            ExeServ = exeServ;
        }
    }
}

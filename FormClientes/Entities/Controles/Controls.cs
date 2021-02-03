using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;
using FormCliente;
using Entities;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;




namespace Controles
{
    public class Controls
    {

        public Controls()
        {

        }
        public void SalvarTable(string nome, string endereco, string dataEntradaTable)
        {

            //idCliente = default;

            DateTime dataEntrada = DateTime.Parse(dataEntradaTable);


            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");


            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "INSERT INTO public.cliente( nome, endereco, dataentradas)" + "VALUES('" + nome + "','" + endereco + "','" + dataEntrada.ToString("dd/MM/yyyy") + "')";
            conn.Open();

            int i = comm.ExecuteNonQuery();
            if (i > 0)
            {

                MessageBox.Show("inserido com sucesso!");

            }
            else
            {
                MessageBox.Show("erro!");
            }


            comm.Dispose();
            conn.Close();
        }

        public void DeletarBd(string id)
        {

            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");


            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;


            comm.CommandText = "DELETE FROM public.cliente WHERE " + '"' + "IdCliente" + '"' + "=" + id + ";";

            conn.Open();
            MessageBox.Show(comm.CommandText);
            if (MessageBox.Show(" Deseja realmente excluir esse registro?", "Tem Certeza?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {




                int i = comm.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Registro excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("erro!");
                }
            }
            //Form1 nfrm = new Form1();
            //nfrm.;
            comm.Dispose();
            conn.Close();

        }
        public void UpdateBd(string id, string nome, string endereco, string dataEntrada)
        {
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comm.CommandText = "UPDATE public.cliente SET  nome=" + "'" + nome + "'" + ",endereco=" + "'" + endereco + "'" + ",dataEntradas=" + "'" + dataEntrada + "' WHERE " + '"' + "IdCliente" + '"' + "=" + id + ";";


            comm.CommandType = CommandType.Text;
            conn.Open();

            MessageBox.Show(comm.CommandText);
            if (MessageBox.Show(" Deseja realmente Atualizar esse registro?", "Tem Certeza?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {




                int i = comm.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Registro Atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("erro!");
                }
            }

            comm.Dispose();
            conn.Close();
        }


        //Controles da tabela serviços

        public void SalvarServ(string idCliente, string nameService, string equipamento, string pecasTrocadas, string executService, string valService, string valDesconto, string dataDoServico, string valTotal, string defeito)
        {

            //idCliente = default;

            DateTime dataValidate = DateTime.Now;
            int converid = int.Parse(idCliente);
            double converValor = double.Parse(valService);
            double converDesconto = double.Parse(valDesconto);
            double converValorTotal = double.Parse(valTotal);

            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");
            string sql = "INSERT INTO public.servicos(id_cliente, nameservice,equipamento,pecastrocadas, executservice,valservice,valdesconto,datadoservico,valtotal,defeito)" + "VALUES(@id_cliente,@nameservice,@equipamento,@pecasTrocadas,@executService,@valservices,@valdesconto,@datadoservico,@valTotal,@defeito )";

            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);


            //comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.Parameters.AddWithValue("@id_cliente", converid);
            comm.Parameters.AddWithValue("@nameservice", nameService);
            comm.Parameters.AddWithValue("@equipamento", equipamento);
            comm.Parameters.AddWithValue("@pecastrocadas", pecasTrocadas);
            comm.Parameters.AddWithValue("@executservice", executService);
            comm.Parameters.AddWithValue("@valservices", "" + converValor.ToString("F2") + "");
            comm.Parameters.AddWithValue("@valdesconto", converDesconto.ToString("F2"));
            comm.Parameters.AddWithValue("@datadoservico", dataValidate.ToString("dd/MM/yyyy"));
            comm.Parameters.AddWithValue("@valtotal", converValorTotal.ToString("F2"));
            comm.Parameters.AddWithValue("@defeito", defeito);
            conn.Open();

            //comm.CommandText = "INSERT INTO public.servicos(id_cliente, nameservice,equipamento,pecastrocadas, executservice,valservice,valdesconto,datadoservico,valtotal,defeito)" + "VALUES('" + idCliente + "','" + nameService + "','" + equipamento + "','" + pecasTrocadas + "','" + executService + "','" + converValor.ToString("f2") + "','" + converDesconto.ToString("f2") + "','" + dataValidate.ToString("dd/MM/yyyy") + "','" + converValorTotal.ToString("f2") + "','" + defeito + "')";


            //MessageBox.Show(comm.Prepare());
            comm.Prepare();
            int i = comm.ExecuteNonQuery();
            if (i > 0)
            {

                MessageBox.Show("inserido com sucesso!");

            }
            else
            {
                MessageBox.Show("erro!");
            }


            comm.Dispose();
            conn.Close();
        }


        public void limparText()
        {
            TextBox box = new TextBox();
            box.ResetText();
           
            
        }

    }



}





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
using FormClientes.Forms;




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

        public void SalvarUpSelectSevices(int code, string idCliente, string id_servicos, string nameService, string equipamento, string pecasTrocadas, string executService, string valService, string valDesconto, string dataDoServico, string valTotal, string defeito)
        {

            Servicos serv = new Servicos();


            //1==salvar //2==update //3 ==select//
            //idCliente = default;

            DateTime dataValidate = DateTime.Now;
            int converid = int.Parse(idCliente);
            double converValor = double.Parse(valService);
            double converDesconto = double.Parse(valDesconto);
            double converValorTotal = double.Parse(valTotal);

            converValorTotal = serv.ValorTotal(converDesconto, converValor);
            string sql = null;
            NpgsqlCommand comm = null;
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");
            if (code == 1)
            {
                sql = "INSERT INTO public.servicos (id_cliente, nameservice,equipamento,pecastrocadas, executservice,valservice,valdesconto,datadoservico,valtotal,defeito)" + "VALUES(@id_cliente,@nameservice,@equipamento,@pecasTrocadas,@executService,@valservices,@valdesconto,@datadoservico,@valTotal,@defeito )";

                comm = new NpgsqlCommand(sql, conn);


                //comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@id_cliente", converid);

                comm.Parameters.AddWithValue("@nameservice", nameService);
                comm.Parameters.AddWithValue("@equipamento", equipamento);
                comm.Parameters.AddWithValue("@pecastrocadas", pecasTrocadas);
                comm.Parameters.AddWithValue("@executservice", executService);
                comm.Parameters.AddWithValue("@valservices", converValor.ToString("F2"));
                comm.Parameters.AddWithValue("@valdesconto", converDesconto.ToString("F2"));
                comm.Parameters.AddWithValue("@datadoservico", dataValidate.ToString("dd/MM/yyyy"));
                comm.Parameters.AddWithValue("@valtotal", converValorTotal.ToString("F2"));
                comm.Parameters.AddWithValue("@defeito", defeito);

            }
            else if (code == 2)
            {
                DateTime converData = DateTime.Parse(dataDoServico);
                int converid_servicos = int.Parse(id_servicos);
                sql = "UPDATE public.servicos SET id_cliente=@id_cliente,nameservice=@nameservice,equipamento=@equipamento,pecastrocadas=@pecastrocadas," +
                    "executservice=@executservice,valservice=@valservice,valdesconto=@valdesconto,datadoservico=@datadoservico,valtotal=@valtotal,defeito=@defeito where" + '"' + "id_servicos" + '"' + "=@id_servicos";

                comm = new NpgsqlCommand(sql, conn);


                //comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@id_cliente", converid);
                comm.Parameters.AddWithValue("@id_servicos", converid_servicos);
                comm.Parameters.AddWithValue("@nameservice", nameService);
                comm.Parameters.AddWithValue("@equipamento", equipamento);
                comm.Parameters.AddWithValue("@pecastrocadas", pecasTrocadas);
                comm.Parameters.AddWithValue("@executservice", executService);
                comm.Parameters.AddWithValue("@valservice", converValor.ToString("F2"));
                comm.Parameters.AddWithValue("@valdesconto", converDesconto.ToString("F2"));
                comm.Parameters.AddWithValue("@datadoservico", converData.ToString("dd/MM/yyyy"));
                comm.Parameters.AddWithValue("@valtotal", converValorTotal.ToString("F2"));
                comm.Parameters.AddWithValue("@defeito", defeito);


            }
            else
            {
                sql = "DELETE FROM public.servicos WHERE " + '"' + "id_servicos" + '"' + "=" + id_servicos + ";";
                comm = new NpgsqlCommand(sql, conn);

            }

            conn.Open();

            //comm.CommandText = "INSERT INTO public.servicos(id_cliente, nameservice,equipamento,pecastrocadas, executservice,valservice,valdesconto,datadoservico,valtotal,defeito)" + "VALUES('" + idCliente + "','" + nameService + "','" + equipamento + "','" + pecasTrocadas + "','" + executService + "','" + converValor.ToString("f2") + "','" + converDesconto.ToString("f2") + "','" + dataValidate.ToString("dd/MM/yyyy") + "','" + converValorTotal.ToString("f2") + "','" + defeito + "')";


            //MessageBox.Show(comm.Prepare());
            comm.Prepare();
            int i = comm.ExecuteNonQuery();
            if (i > 0)
            {

                MessageBox.Show("Executado com sucesso!");

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

        public void SalvarUpSelectRevisao(int code, string idCliente, string id_servicos, string idRevisao, string datarevisao)
        {
            //1==salvar //2==update //3 ==select//

            Revisao rev = new Revisao();
            DateTime converData = DateTime.Parse(datarevisao);
            int converIdCliente = int.Parse(idCliente);
            int converIdServico = int.Parse(id_servicos);
            


            string sql = null;
            NpgsqlCommand comm = null;
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");
            if (code == 1)
            {
                sql = "INSERT INTO public.revisao (idcliente, IdServicos,DataRevisao)" + "VALUES(@id_cliente,@IdServicos,@DataRevisao )";

                comm = new NpgsqlCommand(sql, conn);


                //comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@id_cliente", converIdCliente);
                comm.Parameters.AddWithValue("@IdServicos", converIdServico);
                comm.Parameters.AddWithValue("@DataRevisao", converData.ToString("dd/MM/yyyy"));


            }
            else if (code == 2)
            {
                int converIdRevisao = int.Parse(idRevisao);

                sql = "UPDATE public.revisao SET idcliente=@id_cliente,idservicos=@idservicos,DataRevisao=@DataRevisao where idrevisao=@IdRevisao";

                comm = new NpgsqlCommand(sql, conn);


                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@id_cliente", converIdCliente);
                comm.Parameters.AddWithValue("@IdServicos", converIdServico);
                comm.Parameters.AddWithValue("@IdRevisao", converIdRevisao);
                comm.Parameters.AddWithValue("@DataRevisao", converData.ToString("dd/MM/yyyy"));




            }
            else
            {
                sql = "DELETE FROM public.revisao WHERE " + '"' + "idrevisao" + '"' + "=" + idRevisao + ";";
                comm = new NpgsqlCommand(sql, conn);

            }

            conn.Open();

            //comm.CommandText = "INSERT INTO public.servicos(id_cliente, nameservice,equipamento,pecastrocadas, executservice,valservice,valdesconto,datadoservico,valtotal,defeito)" + "VALUES('" + idCliente + "','" + nameService + "','" + equipamento + "','" + pecasTrocadas + "','" + executService + "','" + converValor.ToString("f2") + "','" + converDesconto.ToString("f2") + "','" + dataValidate.ToString("dd/MM/yyyy") + "','" + converValorTotal.ToString("f2") + "','" + defeito + "')";


            //MessageBox.Show(comm.Prepare());
            comm.Prepare();
            int i = comm.ExecuteNonQuery();
            if (i > 0)
            {

                MessageBox.Show("Executado com sucesso!");

            }
            else
            {
                MessageBox.Show("erro!");
            }


            comm.Dispose();
            conn.Close();
        }

        public void ConsultarCliente()
        {

        }


    }



}





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

        public void DeletarBd(String id)
        {

            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");
            string sql = "DELETE FROM CLIENTE WHERE '"IdCliente"'=@Id";

            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            if (MessageBox.Show(" Deseja realmente excluir esse registro?", "Tem Certeza?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
                

               
                comm.Parameters.AddWithValue("@Id", id);
                comm.CommandType = CommandType.Text;
                conn.Open();
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

            comm.Dispose();
            conn.Close();

        }


    }
}




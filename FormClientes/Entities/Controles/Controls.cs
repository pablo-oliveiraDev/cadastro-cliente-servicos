using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;
using FormCliente;



namespace Controles
{
    public class Controls
    {

        public Controls()
        {

        }
        public void SalvarTable( string nome,string endereco,string dataEntradaTable)
        {

            //idCliente = default;

            DateTime dataEntrada = DateTime.Parse(dataEntradaTable);


            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");


            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "INSERT INTO public.cliente( nome, endereco, dataentradas)" + "VALUES('" + nome + "','" +endereco + "','" + dataEntrada.ToString("dd/MM/yyyy") + "')";
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

    }
}




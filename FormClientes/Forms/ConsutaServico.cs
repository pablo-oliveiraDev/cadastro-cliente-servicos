using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Entities;
using Controles;
using System.Drawing.Printing;
using FormClientes.Entities;
using FormClientes.Forms;


namespace FormClientes.Forms
{
   
    public partial class ConsultaServico : Form
    {
        Impressao imp = new Impressao();
        public ConsultaServico()
        {
            InitializeComponent();
            

        }
        public string NomeCli(string id)
        {
            int ConvId = int.Parse(id);
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $"select nome FROM cliente Where" + '"' +"IdCliente" + '"' +"=" + ConvId;
            NpgsqlDataReader nc = comm.ExecuteReader();


            DataTable clientes = new DataTable();
            clientes.Load(nc);



            MessageBox.Show("");

            dataGridViewConsulta.DataSource = clientes;

            MessageBox.Show(comm.CommandText);




            string idrow = dataGridViewConsulta.Rows[0].Cells[0].Value.ToString();
            return idrow;

        }
        public void ConsultaCliente(string nome)
        {

            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select" + '"' + "IdCliente" + '"' + " FROM cliente Where nome Like" + "'%" + nome + "%'";
            NpgsqlDataReader nc = comm.ExecuteReader();


            DataTable clientes = new DataTable();
            clientes.Load(nc);



            MessageBox.Show("");

            dataGridViewConsulta.DataSource = clientes;

            MessageBox.Show(comm.CommandText);




            string idrow = dataGridViewConsulta.Rows[0].Cells[0].Value.ToString();
            int numberGrid = int.Parse(idrow);

            MessageBox.Show(idrow);
            comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from servicos where" + '"' + "id_cliente" + '"' + "=" + numberGrid;
            MessageBox.Show(comm.CommandText);
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {


                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewConsulta2.DataSource = dt;


            }
            else
            {
                MessageBox.Show("Ainda nao exite serviço para esse cliente!", "ATENÇÃO!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            }

            conn.Close();





        }

        public void consultaData(string dataDoServico)
        {
            
            DateTime converData = DateTime.Parse(dataDoServico);
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from servicos where datadoservico  Like" + "'%" + converData.ToString("dd/MM/yyyy") + "%'";
            MessageBox.Show(comm.CommandText);
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {


                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewConsulta2.DataSource = dt;


            }

            conn.Close();

        }
        private void CadRevisao_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormRevisao frmRev = new FormRevisao();
            frmRev.refreshGrid();

            this.Dispose();

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void textNomeCliente_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (textNomeCliente.Text != null && textNomeCliente.Text.Length > 2)
            {
                ConsultaCliente(textNomeCliente.Text);

            }

            else if (textDataServico.Text != null && textDataServico.Text.Length > 2)
            {
                
                consultaData(textDataServico.Text);

            }
            else
            {
                MessageBox.Show("Error!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

        }
        
        public void dataGridViewConsulta2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            int show_row;

            
            string nomeDoServico, dataDoServico, valorTotal, idServico, idCliente, equip, exeServ, pecasTroc, valorServ, desconto, defeito;


            show_row = e.RowIndex;
            DataGridViewRow grv = dataGridViewConsulta2.Rows[show_row];
            idCliente = grv.Cells[0].Value.ToString();
            idServico = grv.Cells[1].Value.ToString();
            nomeDoServico = grv.Cells[2].Value.ToString();
            equip = grv.Cells[3].Value.ToString();
            pecasTroc = grv.Cells[4].Value.ToString();
            exeServ = grv.Cells[5].Value.ToString();
            valorServ = grv.Cells[6].Value.ToString();
            desconto = grv.Cells[7].Value.ToString();
            dataDoServico = grv.Cells[8].Value.ToString();
            valorTotal = grv.Cells[9].Value.ToString();
            defeito = grv.Cells[10].Value.ToString();
            string nomeCliente = NomeCli(idCliente);

            imp = new Impressao(nomeCliente, nomeDoServico, dataDoServico, valorTotal,idCliente,idServico,equip,pecasTroc,valorServ,desconto,exeServ);
            
             
        }
        
        public void btnImprimir_Click(object sender, EventArgs e)
        {

            using (PrintDocument print = new PrintDocument())
            using (PrintPreviewDialog dialog = new PrintPreviewDialog())
            {
                
                print.PrintPage += Print_PrintPage;
                dialog.Document = print;
                
                dialog.ShowDialog();
            }



        }
        public void Print_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
           /* Image image = Image
                .FromFile(string.Format("{0}{1}",
                Application.StartupPath,
                "\\sistemaInformatica\\informaticaEManut\\IMG\\cliente2.png"));*/

            using (Font font = new Font("Arial", 16))
            {
                Font font1 = new Font("Arial-Black", 12);

                g.DrawString($"nome : {imp.NomeCliente}            Data: {imp.DataDoServico}           O.S: {imp.IdServicos}", font, Brushes.Black, 40, 40);
                g.DrawString($"Serviço: {imp.NomeDoServico}", font, Brushes.Black, 40, 65);
                g.DrawString($"Descrição do serviço Equipamento: {imp.Equipamento} -", font1, Brushes.Black, 40, 100);
                g.DrawString($" Peças trocadas: {imp.PecasTrocadas}", font1, Brushes.Black, 60, 125);
                g.DrawString($"Serviços prestados: {imp.ExeServ}", font1, Brushes.Black, 60, 165);
                
                g.DrawString($"Valor do Serviço: {imp.ValorServico}  Deconto: {imp.Desconto}%   valor Total: {imp.ValorTotal}", font, Brushes.Black, 40, 215);
                
            }
        }

    }
}

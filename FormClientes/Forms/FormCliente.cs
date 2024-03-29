﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Controles;
using FormClientes.Forms;


namespace FormClientes.Forms
{
    public partial class FormCliente : Form
    {
        public  FormCliente FrmCliente { get; set; }

        public FormCliente()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from cliente order by" + '"' + "IdCliente" + '"';
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {


                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewCliente.DataSource = dt;


            }


        }


        public void refreshGrid()
        {
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;Port=5432;user id=admin; password=admin123;database=ManutInfor");

            conn.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from cliente order by" + '"' + "IdCliente" + '"', conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "cliente");
            dataGridViewCliente.DataSource = ds;
            dataGridViewCliente.DataMember = "cliente";
            conn.Close();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            //int idCliente = 11;
            Controls ctrl = new Controls();
            ctrl.SalvarTable(TextNome.Text, textEndereco.Text, textDataEntrada.Text);
            TextNome.Clear();
            textEndereco.Clear();
            textDataEntrada.Clear();
            refreshGrid();


        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int select_row;


            if (e.RowIndex >= 0)
            {
                select_row = e.RowIndex;
                DataGridViewRow grv = dataGridViewCliente.Rows[select_row];
                textId.Text = grv.Cells[0].Value.ToString();
                TextNome.Text = grv.Cells[1].Value.ToString();
                textEndereco.Text = grv.Cells[2].Value.ToString();
                textDataEntrada.Text = grv.Cells[3].Value.ToString();
            }

            else
            {

            }
        }

        private void BtnCadNovo(object sender, EventArgs e)
        {


            NovoCliente cliform = new NovoCliente();
            cliform.Show();
            cliform.TopMost = true;
            FormCliente frmCli = new FormCliente();
            this.Close();


        }

        private void BtncadCancel(object sender, EventArgs e)
        {

            this.Close();
        }

        private void BtnAtualizar(object sender, EventArgs e)
        {
            Controls ctrl = new Controls();
            ctrl.UpdateBd(textId.Text, TextNome.Text, textEndereco.Text, textDataEntrada.Text);
            refreshGrid();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {




        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {

            Controls crtl = new Controls();

            crtl.DeletarBd(textId.Text);
            refreshGrid();
        }

        public void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormServicos formsevices = new FormServicos();

            FormCliente formCliente = new FormCliente();
            formsevices.Show();


        }

        private void revisaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRevisao frm = new FormRevisao();
            frm.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaServico frm = new ConsultaServico();
            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
            FormCliente frmCli = new FormCliente();
            this.Close();
           
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciadorTarefas
{
    public partial class consultar : Form
    {
        DAO consul;
        public consultar()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();
            NomeColunas();
            AdicionarDados();
        }

        public void NomeColunas()
        {
            
            dataGridView1.Columns[0].Name = "Tarefas";
            dataGridView1.Columns[1].Name = "Descrição";
            dataGridView1.Columns[2].Name = "Data de Vencimento";
            dataGridView1.Columns[3].Name = "Prioridade";
            dataGridView1.Columns[4].Name = "Status";
        }

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.ColumnCount = 5;
        }

        public void AdicionarDados()
        {
            consul.PreencherVetor();
            for(int i = 0;i < consul.QuantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.titulo[i], consul.descricao[i], consul.dtVencimento[i], consul.prioridade[i], consul.statu[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            atualizar atua = new atualizar();
            atua.ShowDialog();
        }//Fim do Editar tarefa

        private void button11_Click(object sender, EventArgs e)
        {
            atualizar atu = new atualizar();
            atu.ShowDialog();
        }//Fim do editar tarefas

        private void button12_Click(object sender, EventArgs e)
        {
            cadastrar cad = new cadastrar();
            cad.ShowDialog();
        }//Fim do cadastrar

        private void button6_Click(object sender, EventArgs e)
        {
            listar lis = new listar();
            lis.ShowDialog();
        }//Fim do listar

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class listarPrio : Form
    {
        DAO consul;
        public listarPrio()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid3();
            NomeColunas3();
            AdicionarDados3();
        }

        public void NomeColunas3()
        {

            dataGridView3.Columns[0].Name = "Tarefas";
            dataGridView3.Columns[1].Name = "Descrição";
            dataGridView3.Columns[2].Name = "Data de Vencimento";
            dataGridView3.Columns[3].Name = "Prioridade";
        }

        public void ConfigurarDataGrid3()
        {
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToResizeColumns = false;
            dataGridView3.AllowUserToResizeRows = false;

            dataGridView3.ColumnCount = 4;
        }

        public void AdicionarDados3()
        {
            consul.VerPrioridade();
            for (int ip = 0; ip < consul.QuantidadeDePrioridade(); ip++)
            {
                dataGridView3.Rows.Add(consul.tituloPrio[ip], consul.descricaoPrio[ip], consul.dtVencimentoPrio[ip], consul.prioridadePrio[ip]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }//Fim do Listar

        private void atualizarTarefa_Click(object sender, EventArgs e)
        {
            cadastrar cad = new cadastrar();
            cad.ShowDialog();
        }//Fim do adicionar

        private void button4_Click(object sender, EventArgs e)
        {
            atualizar atu = new atualizar();
            atu.ShowDialog();
        }//Fim do atualizar

        private void button2_Click(object sender, EventArgs e)
        {
            consultar con = new consultar();
            con.ShowDialog();
        }//Fim do consultar

        private void button3_Click(object sender, EventArgs e)
        {
            listar lis = new listar();
            lis.ShowDialog();
        }//Fim do listar das Datas

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

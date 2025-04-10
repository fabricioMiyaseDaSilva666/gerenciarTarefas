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
    public partial class listar : Form
    {
        DAO consul;
        public listar()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid2();
            NomeColunas2();
            AdicionarDados2();
        }

        public void NomeColunas2()
        {

            dataGridView2.Columns[0].Name = "Tarefas";
            dataGridView2.Columns[1].Name = "Descrição";
            dataGridView2.Columns[2].Name = "Data de Vencimento";
            dataGridView2.Columns[3].Name = "Prioridade";
        }

        public void ConfigurarDataGrid2()
        {
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;

            dataGridView2.ColumnCount = 4;
        }

        public void AdicionarDados2()
        {
            consul.VerDatas();
            for (int id = 0; id < consul.QuantidadeDeDatas(); id++)
            {
                dataGridView2.Rows.Add(consul.titulod[id], consul.descricaod[id], consul.dtVencimentod[id], consul.prioridaded[id]);
            }
        }

        private void atualizarTarefa_Click(object sender, EventArgs e)
        {
            cadastrar cad = new cadastrar();
            cad.ShowDialog();
        }//Fim do Adicionar

        private void button4_Click(object sender, EventArgs e)
        {
            atualizar atu = new atualizar();
            atu.ShowDialog();
        }//Fim do Editar

        private void button2_Click(object sender, EventArgs e)
        {
            consultar con = new consultar();
            con.ShowDialog();
        }//Fim do consultar

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }//Fim do Listar Datas

        private void button7_Click(object sender, EventArgs e)
        {
            listarPrio lisPrio = new listarPrio();
            lisPrio.ShowDialog();
        }//Fim do Listar Prioridades
    }
}

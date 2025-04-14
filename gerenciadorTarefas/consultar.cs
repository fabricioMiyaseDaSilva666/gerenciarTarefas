using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            excluir exc = new excluir();
            exc.ShowDialog();
        }

        private void consultar_Load(object sender, EventArgs e)
        {
                ArredondarBotao(button9);
                ArredondarBotao(button11);
                ArredondarBotao(button12);
                ArredondarBotao(button6);
                ArredondarBotao(button1);
                
     
            }

            // Função para arredondar botões
            private void ArredondarBotao(System.Windows.Forms.Button btn)
            {
                GraphicsPath path = new GraphicsPath();
                int radius = 25;

                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                btn.Region = new Region(path);
            
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            dataGridView3.Columns[4].Name = "Status";
        }

        public void ConfigurarDataGrid3()
        {
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToResizeColumns = false;
            dataGridView3.AllowUserToResizeRows = false;

            dataGridView3.ColumnCount = 5;
        }

        public void AdicionarDados3()
        {
            consul.VerPrioridade();
            for (int ip = 0; ip < consul.QuantidadeDePrioridade(); ip++)
            {
                dataGridView3.Rows.Add(consul.tituloPrio[ip], consul.descricaoPrio[ip], consul.dtVencimentoPrio[ip], consul.prioridadePrio[ip], consul.statuPrio[ip]);
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

        private void listarPrio_Load(object sender, EventArgs e)
        
            {
                ArredondarBotao(button6);
                ArredondarBotao(atualizarTarefa);
                ArredondarBotao(button2);
                ArredondarBotao(button4);
                ArredondarBotao(button3);
                ArredondarBotao(button7);
                ArredondarBotao(button9);
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
        

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            excluir exc = new excluir();
            exc = new excluir();
        }
    }
}

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
    public partial class excluir : Form
    {
        DAO exc;
        public excluir()
        {
            InitializeComponent();
            exc= new DAO();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void atualizarTarefa_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }//Fim do Adicionar tarefa

        private void button4_Click(object sender, EventArgs e)
        {
            atualizar atua = new atualizar();
            atua.ShowDialog();
        }//Fim do Editar Tarefa

        private void button2_Click(object sender, EventArgs e)
        {
            consultar consult = new consultar();
            consult.ShowDialog();
        }//Fim do Consultar

        private void button3_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            MessageBox.Show(exc.Excluir(codigo));
            this.Close();
        }//fim do botão excluir

        private void button9_Click(object sender, EventArgs e)
        {
            consultar con = new consultar();
            con.ShowDialog();
        }//Fim do Consultar

        private void button11_Click(object sender, EventArgs e)
        {
            atualizar atu = new atualizar();
            atu.ShowDialog();
        }//Fim do Editar tarefas

        private void button12_Click(object sender, EventArgs e)
        {
            cadastrar cad = new cadastrar();
            cad.ShowDialog();
        }//Fim do Cadastrar

        private void button6_Click(object sender, EventArgs e)
        {
            listar lis = new listar();
            lis.ShowDialog();
        }//Fim do listar

        private void excluir_Load(object sender, EventArgs e)
        
            {
                ArredondarBotao(button6);
                ArredondarBotao(button12);
                ArredondarBotao(button11);
                ArredondarBotao(button9);
                ArredondarBotao(button3);
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
    }
}

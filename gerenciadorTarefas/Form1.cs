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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DAO conexao = new DAO();
        }

        private void Form1_Load(object sender, EventArgs e)


        {
                ArredondarBotao(button1);
               
            }

            // Função para arredondar botões
            private void ArredondarBotao(System.Windows.Forms.Button btn)
            {
                GraphicsPath path = new GraphicsPath();
                int radius = 65;
            

                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                btn.Region = new Region(path);
            }
        

        

        private void novaTarefa_Click(object sender, EventArgs e)
        {
            
        }//Fim do Listar tarefas

        private void atualizarTarefa_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultar consult = new consultar();
            consult.ShowDialog();
        }//FIm do Consultar tarefa

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            atualizar atua = new atualizar();
            atua.ShowDialog();
        }//Fim do Editar Tarefa

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastrar cad = new cadastrar();
            cad.ShowDialog();
        }
    }
}

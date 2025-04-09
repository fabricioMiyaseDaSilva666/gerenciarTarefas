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
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gerenciadorTarefas
{
    public partial class cadastrar : Form
    {

        private void cadastrar_Load(object sender, EventArgs e)
        {
            ArredondarBotao(atualizarTarefa);
            ArredondarBotao(button4);
            ArredondarBotao(button2);
            ArredondarBotao(button6);
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

       
        public cadastrar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAO inserir = new DAO();
            int codigo = Convert.ToInt32(textBox1.Text);
            string titulo = textBox1.Text;
            string descricao = textBox2.Text;
            string dtVencimento = RemoverCampoData(dateTimePicker1.Text);
            string prioridade = comboBox1.Text;

            MessageBox.Show(inserir.Inserir(codigo, titulo, descricao, dtVencimento, prioridade));
            this.Close();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string RemoverCampoData(string data)
        {
            string dt = data.Replace("/", "");
            string dia = dt.Substring(0, 2);
            string mes = dt.Substring(2, 2);
            string ano = dt.Substring(4, 4);

            return $"{ano}-{mes}-{dia}";
        }//fim da remoção
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void novaTarefa_Click(object sender, EventArgs e)
        {

        }//Fim do  Listar tarefa

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void atualizarTarefa_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            atualizar atu = new atualizar();
            atu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

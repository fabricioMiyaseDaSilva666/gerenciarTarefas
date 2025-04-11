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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace gerenciadorTarefas
{
    public partial class atualizar : Form
    {
        DAO atu;
        public atualizar()
        {
            atu = new DAO();
            InitializeComponent();
            textBox1.ReadOnly = false;           
        }

        private void atualizar_Load(object sender, EventArgs e)
        {
            ArredondarBotao(button11);
            ArredondarBotao(button12);
            ArredondarBotao(button2);
            ArredondarBotao(button9);
            ArredondarBotao(button3);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox2.Text = "Informe o Código";
                comboBox1.Text = "Informe o Código";
            }
            else
            {
                string titulo = textBox1.Text;
                textBox2.Text = atu.RetornarDescricao(titulo);
                //comboBox1.Text = atu.RetornarDescricao(titulo);
                //comboBox2.Text = atu.RetornarDescricao(titulo);
                



                textBox1.ReadOnly = true;
                //textBox2.ReadOnly= false;
                
            }
        }

        private void atualizarTarefa_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }//Fim do Adicionar tarefa

        private void button2_Click(object sender, EventArgs e)
        {
            consultar consult = new consultar();
            consult.ShowDialog();
        }//Fim do Consultar tarefa

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            string titulo =  textBox1.Text;
            string descricao = textBox2.Text;
            string dtVencimento = dateTimePicker1.Text;
            string prioridade = comboBox1.Text;
            string statu = comboBox2.Text;

            atu.Atualizar(codigo, "titulo", titulo);
            atu.Atualizar(codigo, "descricao", descricao);
            atu.Atualizar(codigo, "dtVencimento", dtVencimento);
            atu.Atualizar(codigo, "prioridade", prioridade);
            atu.Atualizar(codigo, "statu", statu);
            MessageBox.Show("Dados Atualizados com Sucesso!");
            this.Close();
        }//Fim do botão atualizar


    

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            consultar con = new consultar();
            con.ShowDialog();
        }//Fim do Consultar tarefas

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }//Fim do editar

        private void button12_Click(object sender, EventArgs e)
        {
            cadastrar cad = new cadastrar();
            cad.ShowDialog();
        }//Fim do Adicionar 

        private void button2_Click_1(object sender, EventArgs e)
        {
            listar lis = new listar();
            lis.ShowDialog();
        }//Fim do Adicionar tarefas

        private void button6_Click(object sender, EventArgs e)
        {
            excluir exclui = new excluir();
            exclui.ShowDialog();
        }//Fim do Excluir

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            textBox2.ReadOnly = true;
            maskedTextBox1.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void atualizar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox2.Text = "Informe o Código";
                maskedTextBox1.Text = "Informe o Código";
                textBox3.Text = "Informe o Código";
            }
            else
            {
                int codigo = Convert.ToInt32(textBox1);
                textBox2.Text = atu.RetornarDescricao(codigo);
                maskedTextBox1.Text = atu.RetornarDtVencimento(codigo);
                textBox3.Text = atu.RetornarPrioridade(codigo);

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                maskedTextBox1.ReadOnly = false;
                textBox3.ReadOnly=false;
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
            string dtVencimento = maskedTextBox1.Text;
            string prioridade = textBox3.Text;

            atu.Atualizar(codigo, "descricao", descricao);
            atu.Atualizar(codigo, "dtVencimento", dtVencimento);
            atu.Atualizar(codigo, "prioridade", prioridade);
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
    }
}

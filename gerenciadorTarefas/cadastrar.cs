using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace gerenciadorTarefas
{
    public partial class cadastrar : Form
    {
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
            string prioridade = textBox3.Text;

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

        private void cadastrar_Load(object sender, EventArgs e)
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
    }
}

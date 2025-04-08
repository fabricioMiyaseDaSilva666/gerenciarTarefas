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
    public partial class consultar : Form
    {
        public consultar()
        {
            InitializeComponent();
        }

        private void atualizarTarefa_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }//Fim do Adicionar tarefa

        private void button5_Click(object sender, EventArgs e)
        {
            atualizar atua = new atualizar();
            atua.ShowDialog();
        }//Fim do Editar tarefa
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace gerenciadorTarefas
{
    class DAO
    {
        public MySqlConnection conexao;
        public int[] codigo;
        public string[] titulo;
        public string[] descricao;
        public string[] dtVencimento;
        public string[] prioridade;
        public int i;
        public int contador;


        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=projetoCSharp;Uid=root;password=;Convert Zero Datetime=True");
            try
            {
                conexao.Open();
            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n\n" + erro);
            }
        }//Fim do constructor

        public string Inserir(int codigo, string titulo, string descricao, string dtVencimento, string prioridade)
        {
            string inserir = $"Insert into tarefas(codigo, titulo, descricao, dtVencimento, prioridade) values('{codigo}','{titulo}','{descricao}','{dtVencimento}','{prioridade}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado!";
            return resultado;
        }//Fim do método de inserir

        public void PreencherVetor()
        {
            string query = "select + from tarefas";

            this.codigo = new int[100];
            this.titulo = new string[100];
            this.descricao = new string[100];
            this.dtVencimento = new string[100];
            this.prioridade = new string[100];

            MySqlCommand sql = new MySqlCommand(query, conexao);
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;//Instanciando o contador
            contador = 0;
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                titulo[i] = leitura["titulo"] + "";
                descricao[i] = leitura["descricao"] + "";
                dtVencimento[i] = leitura["dtVencimento"]+ "";
                prioridade[i] = leitura["prioridade"] + "";
                i++;
                contador++;
            }//Fim do while
            leitura.Close();
        }//Fim do método

        public int ConsultarPorCodigo(int cod)
        {
            PreencherVetor();

            i = 0;
            while (i < QuantidadeDeDados())
            {
                if (codigo[i] == cod)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }//Fim do método

        public string RetornarTitulo(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return titulo[posicao];
            }
            return "Código digitado não é valido";
        }//Fim do retornar titulo

        public string RetornarDescricao(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return descricao[posicao];
            }
            return "Código digitado não é valido";
        }//Fim do retornar descrição

        public string RetornarDtVencimento(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return dtVencimento[posicao];
            }
            return "Código digitado não é valido";

        }//Fim do retornar data de vencimento

        public string RetornarPrioridade(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return prioridade[posicao];
            }
            return "Código digitado não é valido";
        }//Fim do retornar prioridade

        public int QuantidadeDeDados()
        {
            return contador;
        }//Fim do método

        public string Atualizar(int codigo, string campo, string dado)
        {
            string query = $"update tarefas set {campo} = '{dado}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Atualizado";
            return resultado;
        }//Fim do método de atualizar

        public string Excluir(int codigo)
        {
            string query = $"delete from tarefas where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Deletado";
            return resultado;
        }//Fim do método excluir

        public int ConsultarPorData(int dt)//FAZ ALGO PARECIDO COM ISSO, MAS PRA VER AS DATAS
        {
            PreencherVetor();

            i = 0;
            while (i < QuantidadeDeDados())
            {
                if (codigo[i] == dt)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }//Fim do método

       
    }
}

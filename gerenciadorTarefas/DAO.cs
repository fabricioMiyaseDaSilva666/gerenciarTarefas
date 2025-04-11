using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Microsoft.Win32;

namespace gerenciadorTarefas
{
    class DAO
    {
        public MySqlConnection conexao;
        public int[] codigo;
        public string[] titulo;
        public string[] titulod;
        public string[] tituloPrio;
        public string[] descricao;
        public string[] descricaod;
        public string[] descricaoPrio;
        public string[] dtVencimento;
        public string[] dtVencimentod;
        public string[] dtVencimentoPrio;
        public string[] prioridade;
        public string[] prioridaded;
        public string[] prioridadePrio;
        public string[] statu;
        public string[] statuD;
        public string[] statuPrio;
        public int i;
        public int contador;
        public int id;
        public int contadores;
        public int ip;
        public int contadorP;
        public int contadorPrio;
        public int registros;


        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=projetoCSharps;Uid=root;password=;Convert Zero Datetime=True");
            try
            {
                conexao.Open();
            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n\n" + erro);
            }
        }//Fim do constructor

        public string Inserir(int codigo, string titulo, string descricao, string dtVencimento, string prioridade, string statu)
        {
            string inserir = $"Insert into tarefas(codigo, titulo, descricao, dtVencimento, prioridade, statu) values('{codigo}','{titulo}','{descricao}','{dtVencimento}','{prioridade}','{statu}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado!";
            return resultado;
        }//Fim do método de inserir

        public void PreencherVetor()
        {
            string query = "select * from tarefas";
              
            this.titulo = new string[100];
            this.descricao = new string[100];
            this.dtVencimento = new string[100];
            this.prioridade = new string[100];
            this.statu = new string[100];

            MySqlCommand sql = new MySqlCommand(query, conexao);
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;//Instanciando o contador
            contador = 0;
            while (leitura.Read())
            { 
                titulo[i] = leitura["titulo"] + "";
                descricao[i] = leitura["descricao"] + "";
                dtVencimento[i] = leitura["dtVencimento"]+ "";
                prioridade[i] = leitura["prioridade"] + "";
                statu[i] = leitura["statu"] + "";
                i++;
                contador++;
            }//Fim do while
            leitura.Close();
        }//Fim do método

        public void VerDatas()
        {
            string query = "select * from tarefas order by dtVencimento";

            this.titulod = new string[100];
            this.descricaod = new string[100];
            this.dtVencimentod = new string[100];
            this.prioridaded = new string[100];
            this.statuD = new string[100];

            MySqlCommand sql = new MySqlCommand(query, conexao);
            MySqlDataReader leituras = sql.ExecuteReader();

            id = 0;//Instanciando o contador
            contadores = 0;
            while (leituras.Read())
            {
                titulod[id] = leituras["titulo"] + "";
                descricaod[id] = leituras["descricao"] + "";
                dtVencimentod[id] = leituras["dtVencimento"] + "";
                prioridaded[id] = leituras["prioridade"] + "";
                statuD[id] = leituras["statu"] + "";
                id++;
                contadores++;
            }//Fim do while
            leituras.Close();
        }//Fim do método

        public void VerPrioridade()
        {
            string query = "select * from tarefas order by prioridade";

            this.tituloPrio = new string[100];
            this.descricaoPrio = new string[100];
            this.dtVencimentoPrio = new string[100];
            this.prioridadePrio = new string[100];
            this.statuPrio = new string[100];

            MySqlCommand sql = new MySqlCommand(query, conexao);
            MySqlDataReader leituras = sql.ExecuteReader();

            ip = 0;//Instanciando o contador
            contadorPrio = 0;
            while (leituras.Read())
            {
                tituloPrio[ip] = leituras["titulo"] + "";
                descricaoPrio[ip] = leituras["descricao"] + "";
                dtVencimentoPrio[ip] = leituras["dtVencimento"] + "";
                prioridadePrio[ip] = leituras["prioridade"] + "";
                statuPrio[ip] = leituras["statu"] + "";
                ip++;
                contadorPrio++;
            }//Fim do while
            leituras.Close();
        }//Fim do método

        public int ConsultarPorTitulo(string titu)
        {
            PreencherVetor();

            i = 0;
            while (i < QuantidadeDeDados())
            {
                if (titulo[i] == titu)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }//Fim do método

        public int ConsultarPorData(int cod)
        {
            PreencherVetor();

            i = 0;
            while (i < QuantidadeDeDatas())
            {
                if (codigo[i] == cod)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }//Fim do método

        public string RetornarTitulo(string titu)
        {
            int posicao = ConsultarPorTitulo(titu);
            if (posicao > -1)
            {
                return titulo[posicao];
            }
            return "Código digitado não é valido";
        }//Fim do retornar titulo

        public string RetornarDescricao(string titulo)
        {
            int posicao = ConsultarPorTitulo(titulo);
            if (posicao > -1)
            {
                return descricao[posicao];
            }
            return "Código digitado não é valido";
        }//Fim do retornar descrição

        public string RetornarDtVencimento(string titulo)
        {
            int posicao = ConsultarPorTitulo(titulo);
            if (posicao > -1)
            {
                return dtVencimento[posicao];
            }
            return "Código digitado não é valido";

        }//Fim do retornar data de vencimento

        public string RetornarPrioridade(string titulo)
        {
            int posicao = ConsultarPorTitulo(titulo);
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

        public int QuantidadeDeDatas()
        {
            return contadores;
        }//Fim do método

        public int QuantidadeDePrioridade()
        {
            return contadorPrio;
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

        

      
    }
}

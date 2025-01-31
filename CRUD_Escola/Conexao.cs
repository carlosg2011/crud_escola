using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.SqlServer.Server;

namespace CRUD_Escola
{
    internal class Conexao
    {

        MySqlConnection conn;

        private void Conectar()
        {
            string dadosConexao = "Persist Security info = false; server=localhost; database=CRUD_Escola; user=root; pwd=;";
            conn = new MySqlConnection(dadosConexao);
            conn.Open();
        }

        public DataTable ExecultarConsulta(string sql)
        {

            Conectar();
            MySqlDataAdapter dados = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dados.Fill(dt);
            conn.Close();
            return dt;

        }

        public void ExecutarComando(string sql)
        {
            Conectar();
            MySqlCommand comando = new MySqlCommand(sql, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }

    }
}

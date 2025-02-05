using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CRUD_Escola
{
    internal class Professores
    {
        Conexao conn = new Conexao();

        public int cod_professor{ get; set; }
        public string nome { get; set; }
        public string disciplina { get; set; }

        public void InserirProfessor()
        {
            string sql = $"insert into professores (cod_professor, nome, disciplina) values ('{this.cod_professor} ', ' {this.nome} ', ' {this.disciplina}');";
            conn.ExecutarComando(sql);
        }

        public void AlterarProfessor()
        {
            string sql = $"update professores set nome = '{this.nome}', disciplina = '{this.disciplina}' where cod_professor = '{this.cod_professor}';";
            conn.ExecutarComando(sql);
        }

        public void ExcluirProfessor()
        {
            string sql = $"delete from professores where cod_professor = '{this.cod_professor}';";
            conn.ExecutarComando(sql);
        }

        public void ConsultarProfessor()
        {
            string sql = $"select * from professores where cod_professor = '{this.cod_professor}';";
            conn.ExecultarConsulta(sql);
        }

        public DataTable ListarDados()
        {
            string sql = "select * from professores order by cod_professor;";
            return conn.ExecultarConsulta(sql);
        }
    }
}

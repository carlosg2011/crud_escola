using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Escola
{
    internal class Alunos
    {
        Conexao conn = new Conexao();

        public int matricula { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string turno { get; set; }
        public int serie { get; set; }
        public string turma { get; set; }
        public char unidade { get; set; }

        public void InserirAluno()
        {
            string sql = $"insert into alunos (matricula, nome, idade, turno, serie, turma, unidade) values ('{ this.matricula } ', ' { this.nome } ', ' {this.idade}', '{this.turno}', ' {this.serie} ', '{this.turma}', '{this.unidade}');";
            conn.ExecutarComando(sql);
        }

        public void AlterarAluno()
        {
            string sql = $"update alunos set nome = '{this.nome}', idade = '{this.idade}', turno = '{this.turno}', serie = '{this.serie}', turma = '{this.turma}', unidade = '{this.unidade}' where matricula = '{this.matricula}';";
            conn.ExecutarComando(sql);
        }

        public void ExcluirAluno()
        {
            string sql = $"delete from alunos where matricula = '{this.matricula}';";
            conn.ExecutarComando(sql);
        }

        public void ConsultarAluno()
        {
            string sql = $"select * from alunos where matricula = '{this.matricula}';";
            conn.ExecultarConsulta(sql);
        }

        public DataTable ListarDados()
        {
            string sql = "select * from alunos order by matricula;";
            return conn.ExecultarConsulta(sql);
        }

    }
}

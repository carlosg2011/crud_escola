using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Escola
{
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent();
        }

        Alunos alunos = new Alunos();


        public void ArmazenaDados()
        {
            char turno = rdb_manha.Checked ? 'M' : rdb_tarde.Checked ? 'T' : ' ';
            int serie = rdb_1.Checked ? 1 : rdb_2.Checked ? 2 : rdb_3.Checked ? 3 : ' ';
            char unidade = rdb_barroca.Checked ? 'B' : rdb_Floresta.Checked ? 'F' : ' ';

            alunos.matricula = int.Parse(txt_matricula.Text);
            alunos.nome = txtNome.Text;
            alunos.idade = int.Parse(txtIdade.Text);
            alunos.turno = turno.ToString();
            alunos.serie = serie;
            alunos.turma = cmb_Turma.Text;
            alunos.unidade = unidade;
        }

        private void ExibirDados() //preencher o DataGridView com o resultado do select
        {

            dtg_Tela.DataSource = alunos.ListarDados();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ArmazenaDados();
            alunos.InserirAluno();
            ExibirDados();
            MessageBox.Show("Dados cadastrados com sucesso");
            LimparDados();
        }


        private void frmAluno_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            alunos.matricula = int.Parse(txt_matricula.Text);
            alunos.ConsultarAluno();
            ExibirDados();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {

            alunos.matricula = int.Parse(txt_matricula.Text);
            ArmazenaDados();
            alunos.AlterarAluno();
            ExibirDados();
            MessageBox.Show("Dados alterados com sucesso");
            LimparDados();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            alunos.matricula = int.Parse(txt_matricula.Text);
            alunos.ExcluirAluno();
            ExibirDados();
            MessageBox.Show("Aluno Excluido");
            LimparDados();
        }

        private void dtg_Tela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_matricula.Text = dtg_Tela.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dtg_Tela.CurrentRow.Cells[1].Value.ToString();
            txtIdade.Text = dtg_Tela.CurrentRow.Cells[2].Value.ToString();
            string turno = dtg_Tela.CurrentRow.Cells[3].Value.ToString();
            string serie = dtg_Tela.CurrentRow.Cells[4].Value.ToString();
            string turma = dtg_Tela.CurrentRow.Cells[5].Value.ToString();
            if (turno == "M")
            {
                rdb_manha.Checked = true;
            }
            else if (turno == "T")
            {
                rdb_tarde.Checked = true;
            }
            if (serie == "1")
            {
                rdb_1.Checked = true;
            }
            else if (serie == "2")
            {
                rdb_2.Checked = true;
            }
            else if (serie == "3")
            {
                rdb_3.Checked = true;
            }
            cmb_Turma.Text = turma;
        }

      public void LimparDados()
        {
            txt_matricula.Text = "";
            txtNome.Text = "";
            txtIdade.Text = "";
            rdb_manha.Checked = false;
            rdb_tarde.Checked = false;
            rdb_1.Checked = false;
            rdb_2.Checked = false;
            rdb_3.Checked = false;
            rdb_barroca.Checked = false;
            rdb_Floresta.Checked = false;
            cmb_Turma.Text = "";
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Escola
{
    public partial class Professor : Form
    {
        public Professor()
        {
            InitializeComponent();
        }

        Professores prof = new Professores();

        private void ArmazenaDados()
        {
            
            prof.cod_professor = int.Parse(txtCodProf.Text);
            prof.nome = txtNome.Text;
            prof.disciplina = cmbDisciplina.Text;

        }

        public void ExibirDados()
        {
            dtgView.DataSource = prof.ListarDados();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            ArmazenaDados();
            prof.InserirProfessor();
            ExibirDados();
            MessageBox.Show("Dados cadastrados com sucesso");
            LimparDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ArmazenaDados();
            prof.ConsultarProfessor();
            ExibirDados();
            LimparDados();        
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ArmazenaDados();
            prof.AlterarProfessor();
            ExibirDados();
            MessageBox.Show("Dados atualizados com sucesso");
            LimparDados();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ArmazenaDados();
            prof.ExcluirProfessor();
            ExibirDados();
            MessageBox.Show("Dados deletados com sucesso");
            LimparDados();
        }

        private void Professor_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }



        public void LimparDados()
        {
            txtCodProf.Clear();
            txtNome.Clear();
            cmbDisciplina.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
        }
    }


}

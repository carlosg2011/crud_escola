namespace CRUD_Escola
{
    partial class frmAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdb_manha = new System.Windows.Forms.RadioButton();
            this.rdb_tarde = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_1 = new System.Windows.Forms.RadioButton();
            this.rdb_2 = new System.Windows.Forms.RadioButton();
            this.rdb_3 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_Turma = new System.Windows.Forms.ComboBox();
            this.rdb_barroca = new System.Windows.Forms.RadioButton();
            this.rdb_Floresta = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtg_Tela = new System.Windows.Forms.DataGridView();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Tela)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(23, 40);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(172, 16);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "NÚMERO DE MATRICULA:";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(26, 59);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(136, 20);
            this.txt_matricula.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(23, 91);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "NOME:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(26, 110);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(136, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "IDADE:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(26, 162);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(136, 20);
            this.txtIdade.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "TURNO;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "SÉRIE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "TURMA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(630, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "UNIDADE:";
            // 
            // rdb_manha
            // 
            this.rdb_manha.AutoSize = true;
            this.rdb_manha.Location = new System.Drawing.Point(27, 8);
            this.rdb_manha.Name = "rdb_manha";
            this.rdb_manha.Size = new System.Drawing.Size(64, 17);
            this.rdb_manha.TabIndex = 10;
            this.rdb_manha.TabStop = true;
            this.rdb_manha.Text = "MANHÃ";
            this.rdb_manha.UseVisualStyleBackColor = true;
            // 
            // rdb_tarde
            // 
            this.rdb_tarde.AutoSize = true;
            this.rdb_tarde.Location = new System.Drawing.Point(97, 8);
            this.rdb_tarde.Name = "rdb_tarde";
            this.rdb_tarde.Size = new System.Drawing.Size(62, 17);
            this.rdb_tarde.TabIndex = 11;
            this.rdb_tarde.TabStop = true;
            this.rdb_tarde.Text = "TARDE";
            this.rdb_tarde.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_manha);
            this.panel1.Controls.Add(this.rdb_tarde);
            this.panel1.Location = new System.Drawing.Point(291, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 34);
            this.panel1.TabIndex = 12;
            // 
            // rdb_1
            // 
            this.rdb_1.AutoSize = true;
            this.rdb_1.Location = new System.Drawing.Point(18, 7);
            this.rdb_1.Name = "rdb_1";
            this.rdb_1.Size = new System.Drawing.Size(31, 17);
            this.rdb_1.TabIndex = 13;
            this.rdb_1.TabStop = true;
            this.rdb_1.Text = "1";
            this.rdb_1.UseVisualStyleBackColor = true;
            // 
            // rdb_2
            // 
            this.rdb_2.AutoSize = true;
            this.rdb_2.Location = new System.Drawing.Point(62, 7);
            this.rdb_2.Name = "rdb_2";
            this.rdb_2.Size = new System.Drawing.Size(31, 17);
            this.rdb_2.TabIndex = 14;
            this.rdb_2.TabStop = true;
            this.rdb_2.Text = "2";
            this.rdb_2.UseVisualStyleBackColor = true;
            // 
            // rdb_3
            // 
            this.rdb_3.AutoSize = true;
            this.rdb_3.Location = new System.Drawing.Point(111, 7);
            this.rdb_3.Name = "rdb_3";
            this.rdb_3.Size = new System.Drawing.Size(31, 17);
            this.rdb_3.TabIndex = 15;
            this.rdb_3.TabStop = true;
            this.rdb_3.Text = "3";
            this.rdb_3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdb_3);
            this.panel2.Controls.Add(this.rdb_2);
            this.panel2.Controls.Add(this.rdb_1);
            this.panel2.Location = new System.Drawing.Point(308, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 37);
            this.panel2.TabIndex = 16;
            // 
            // cmb_Turma
            // 
            this.cmb_Turma.FormattingEnabled = true;
            this.cmb_Turma.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmb_Turma.Location = new System.Drawing.Point(326, 162);
            this.cmb_Turma.Name = "cmb_Turma";
            this.cmb_Turma.Size = new System.Drawing.Size(121, 21);
            this.cmb_Turma.TabIndex = 17;
            // 
            // rdb_barroca
            // 
            this.rdb_barroca.AutoSize = true;
            this.rdb_barroca.Location = new System.Drawing.Point(17, 16);
            this.rdb_barroca.Name = "rdb_barroca";
            this.rdb_barroca.Size = new System.Drawing.Size(77, 17);
            this.rdb_barroca.TabIndex = 18;
            this.rdb_barroca.TabStop = true;
            this.rdb_barroca.Text = "BARROCA";
            this.rdb_barroca.UseVisualStyleBackColor = true;
            // 
            // rdb_Floresta
            // 
            this.rdb_Floresta.AutoSize = true;
            this.rdb_Floresta.Location = new System.Drawing.Point(118, 16);
            this.rdb_Floresta.Name = "rdb_Floresta";
            this.rdb_Floresta.Size = new System.Drawing.Size(81, 17);
            this.rdb_Floresta.TabIndex = 19;
            this.rdb_Floresta.TabStop = true;
            this.rdb_Floresta.Text = "FLORESTA";
            this.rdb_Floresta.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdb_Floresta);
            this.panel3.Controls.Add(this.rdb_barroca);
            this.panel3.Location = new System.Drawing.Point(561, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 51);
            this.panel3.TabIndex = 20;
            // 
            // dtg_Tela
            // 
            this.dtg_Tela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Tela.Location = new System.Drawing.Point(26, 211);
            this.dtg_Tela.Name = "dtg_Tela";
            this.dtg_Tela.Size = new System.Drawing.Size(744, 160);
            this.dtg_Tela.TabIndex = 21;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(26, 394);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(122, 44);
            this.btn_Cadastrar.TabIndex = 22;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(181, 394);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(122, 44);
            this.btn_Pesquisar.TabIndex = 23;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(339, 394);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(122, 44);
            this.btn_Atualizar.TabIndex = 24;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Location = new System.Drawing.Point(496, 394);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(122, 44);
            this.btn_Deletar.TabIndex = 25;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(648, 394);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(122, 44);
            this.btn_Sair.TabIndex = 26;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.dtg_Tela);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmb_Turma);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmAluno";
            this.Text = "Aluno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Tela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdb_manha;
        private System.Windows.Forms.RadioButton rdb_tarde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_1;
        private System.Windows.Forms.RadioButton rdb_2;
        private System.Windows.Forms.RadioButton rdb_3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_Turma;
        private System.Windows.Forms.RadioButton rdb_barroca;
        private System.Windows.Forms.RadioButton rdb_Floresta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtg_Tela;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Sair;
    }
}
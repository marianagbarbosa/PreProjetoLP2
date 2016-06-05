namespace PreProjetoLP2
{
    partial class PagAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagAluno));
            this.gb_CaixaAluno = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SemestreAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdgDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.linkVoltar = new System.Windows.Forms.LinkLabel();
            this.gb_CaixaAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_CaixaAluno
            // 
            this.gb_CaixaAluno.Controls.Add(this.label7);
            this.gb_CaixaAluno.Controls.Add(this.label6);
            this.gb_CaixaAluno.Controls.Add(this.label5);
            this.gb_CaixaAluno.Controls.Add(this.label4);
            this.gb_CaixaAluno.Controls.Add(this.label3);
            this.gb_CaixaAluno.Controls.Add(this.label2);
            this.gb_CaixaAluno.Controls.Add(this.label1);
            this.gb_CaixaAluno.Controls.Add(this.dataGridView1);
            this.gb_CaixaAluno.Controls.Add(this.btnEditar);
            this.gb_CaixaAluno.Location = new System.Drawing.Point(16, 25);
            this.gb_CaixaAluno.Name = "gb_CaixaAluno";
            this.gb_CaixaAluno.Size = new System.Drawing.Size(664, 298);
            this.gb_CaixaAluno.TabIndex = 0;
            this.gb_CaixaAluno.TabStop = false;
            this.gb_CaixaAluno.Text = "Bem-vindo(a) \"Nome do Aluno\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Aprovado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "7,8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Engenharia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ENGT2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "01/2013";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Histórico do aluno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SemestreAno,
            this.CdgDisciplina,
            this.NomeDisciplina,
            this.Nota,
            this.Faltas,
            this.Situacao});
            this.dataGridView1.Location = new System.Drawing.Point(11, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 163);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SemestreAno
            // 
            this.SemestreAno.HeaderText = "Semestre/Ano";
            this.SemestreAno.Name = "SemestreAno";
            // 
            // CdgDisciplina
            // 
            this.CdgDisciplina.HeaderText = "Código";
            this.CdgDisciplina.Name = "CdgDisciplina";
            // 
            // NomeDisciplina
            // 
            this.NomeDisciplina.HeaderText = "Disciplina";
            this.NomeDisciplina.Name = "NomeDisciplina";
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            // 
            // Faltas
            // 
            this.Faltas.HeaderText = "Faltas";
            this.Faltas.Name = "Faltas";
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(567, 255);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar Perfil";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // linkVoltar
            // 
            this.linkVoltar.AutoSize = true;
            this.linkVoltar.Location = new System.Drawing.Point(631, 9);
            this.linkVoltar.Name = "linkVoltar";
            this.linkVoltar.Size = new System.Drawing.Size(34, 13);
            this.linkVoltar.TabIndex = 1;
            this.linkVoltar.TabStop = true;
            this.linkVoltar.Text = "Voltar";
            // 
            // PagAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 335);
            this.Controls.Add(this.linkVoltar);
            this.Controls.Add(this.gb_CaixaAluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PagAluno";
            this.Text = "Área do Aluno";
            this.gb_CaixaAluno.ResumeLayout(false);
            this.gb_CaixaAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_CaixaAluno;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.LinkLabel linkVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemestreAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdgDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
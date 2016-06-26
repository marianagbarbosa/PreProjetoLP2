namespace PreProjetoLP2
{
    partial class PagFuncionario
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
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnDisciplina = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnSala = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(264, 110);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(116, 23);
            this.btnAluno.TabIndex = 2;
            this.btnAluno.Text = "Alunos";
            this.btnAluno.UseVisualStyleBackColor = true;
            // 
            // btnDisciplina
            // 
            this.btnDisciplina.Location = new System.Drawing.Point(264, 139);
            this.btnDisciplina.Name = "btnDisciplina";
            this.btnDisciplina.Size = new System.Drawing.Size(116, 23);
            this.btnDisciplina.TabIndex = 3;
            this.btnDisciplina.Text = "Disciplinas";
            this.btnDisciplina.UseVisualStyleBackColor = true;
            // 
            // btnProfessor
            // 
            this.btnProfessor.Location = new System.Drawing.Point(264, 168);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(116, 23);
            this.btnProfessor.TabIndex = 4;
            this.btnProfessor.Text = "Professores";
            this.btnProfessor.UseVisualStyleBackColor = true;
            // 
            // btnSala
            // 
            this.btnSala.Location = new System.Drawing.Point(264, 197);
            this.btnSala.Name = "btnSala";
            this.btnSala.Size = new System.Drawing.Size(116, 23);
            this.btnSala.TabIndex = 5;
            this.btnSala.Text = "Salas";
            this.btnSala.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSala);
            this.groupBox1.Controls.Add(this.btnProfessor);
            this.groupBox1.Controls.Add(this.btnDisciplina);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAluno);
            this.groupBox1.Location = new System.Drawing.Point(52, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 294);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bem-vindo(a)!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta e cadastro:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Relatórios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PagFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 328);
            this.Controls.Add(this.groupBox1);
            this.Name = "PagFuncionario";
            this.Text = "Administração ArtEduBr";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnDisciplina;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnSala;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
using System.Drawing;
using System.Windows.Forms;

namespace CadastroAlunos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblRM;
        private Label lblNome;
        private Label lblCPF;
        private Label lblEmail;

        private TextBox txtRm;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtEmail;

        private Button btnCadastrar;
        private Button btnListar;

        private DataGridView dgvAlunos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblRM = new Label();
            lblNome = new Label();
            lblCPF = new Label();
            lblEmail = new Label();
            txtRm = new TextBox();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtEmail = new TextBox();
            btnCadastrar = new Button();
            btnListar = new Button();
            dgvAlunos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            SuspendLayout();
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lblRM.Location = new Point(26, 24);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(120, 17);
            lblRM.TabIndex = 0;
            lblRM.Text = "RM (7 dígitos)";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lblNome.Location = new Point(26, 64);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(52, 17);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lblCPF.Location = new Point(26, 104);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(136, 17);
            lblCPF.TabIndex = 2;
            lblCPF.Text = "CPF (11 dígitos)";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(26, 144);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(56, 17);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "E-mail";
            // 
            // txtRm
            // 
            txtRm.Font = new Font("Verdana", 9.75F);
            txtRm.Location = new Point(180, 22);
            txtRm.MaxLength = 7;
            txtRm.Name = "txtRm";
            txtRm.Size = new Size(400, 23);
            txtRm.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Verdana", 9.75F);
            txtNome.Location = new Point(180, 62);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(400, 23);
            txtNome.TabIndex = 5;
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Verdana", 9.75F);
            txtCPF.Location = new Point(180, 102);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(400, 23);
            txtCPF.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Verdana", 9.75F);
            txtEmail.Location = new Point(180, 142);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Verdana", 10F, FontStyle.Bold);
            btnCadastrar.Location = new Point(180, 180);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(140, 36);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Verdana", 10F, FontStyle.Bold);
            btnListar.Location = new Point(340, 180);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(140, 36);
            btnListar.TabIndex = 9;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // dgvAlunos
            // 
            dgvAlunos.AllowUserToAddRows = false;
            dgvAlunos.AllowUserToDeleteRows = false;
            dgvAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlunos.Location = new Point(26, 235);
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.ReadOnly = true;
            dgvAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlunos.Size = new Size(554, 260);
            dgvAlunos.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 520);
            Controls.Add(lblRM);
            Controls.Add(lblNome);
            Controls.Add(lblCPF);
            Controls.Add(lblEmail);
            Controls.Add(txtRm);
            Controls.Add(txtNome);
            Controls.Add(txtCPF);
            Controls.Add(txtEmail);
            Controls.Add(btnCadastrar);
            Controls.Add(btnListar);
            Controls.Add(dgvAlunos);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alunos";
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

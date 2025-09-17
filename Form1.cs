using System;
using System.Windows.Forms;

namespace CadastroAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCadastrar.Click += BtnCadastrar_Click;
            btnListar.Click += BtnListar_Click;
        }

        private void BtnCadastrar_Click(object? sender, EventArgs e)
        {
            var aluno = new CadastroAluno
            {
                Rm = txtRm.Text.Trim(),
                Nome = txtNome.Text.Trim(),
                Cpf = txtCPF.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            var (ok, erro) = aluno.Validar();
            if (!ok)
            {
                MessageBox.Show(erro, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (aluno.Inserir())
            {
                MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarGrid();
            }
        }

        private void BtnListar_Click(object? sender, EventArgs e) => CarregarGrid();

        private void CarregarGrid()
        {
            var dados = CadastroAluno.ListarTodos();
            dgvAlunos.DataSource = null;
            dgvAlunos.DataSource = dados;

            if (dgvAlunos.Columns.Contains("Id"))
                dgvAlunos.Columns["Id"].HeaderText = "Código";

            dgvAlunos.Refresh();
        }

        private void LimparCampos()
        {
            txtRm.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtRm.Focus();
        }
    }
}

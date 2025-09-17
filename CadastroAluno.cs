using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CadastroAlunos
{
    internal class CadastroAluno
    {
        public int Id { get; set; }
        public string Rm { get; set; } = "";
        public string Nome { get; set; } = "";
        public string Cpf { get; set; } = "";
        public string Email { get; set; } = "";

        public (bool Ok, string Erro) Validar()
        {
            if (string.IsNullOrWhiteSpace(Rm) || Rm.Length != 7 || !Rm.All(char.IsDigit))
                return (false, "RM deve ter exatamente 7 dígitos numéricos.");

            if (string.IsNullOrWhiteSpace(Nome))
                return (false, "Informe o nome.");

            if (string.IsNullOrWhiteSpace(Cpf) || Cpf.Length != 11 || !Cpf.All(char.IsDigit))
                return (false, "CPF deve conter exatamente 11 dígitos (apenas números).");

            if (string.IsNullOrWhiteSpace(Email) || !Regex.IsMatch(Email, @"^\S+@\S+\.\S+$"))
                return (false, "E-mail inválido.");

            return (true, "");
        }

        public bool Inserir()
        {
            try
            {
                using var conexao = ConexaoBanco.ObterConexao();
                conexao.Open();

                // Tabela correta: Alunos (igual ao seu dbAlunos.sql)
                const string sql = @"INSERT INTO Alunos (rm, nome, cpf, email)
                                     VALUES (@rm, @nome, @cpf, @Email)";

                using var cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@rm", Rm);
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@cpf", Cpf);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex) when (ex.Number == 1062) // duplicidade (se tiver UNIQUE no banco)
            {
                MessageBox.Show("RM/CPF/E-mail já cadastrado.", "Duplicado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir: " + ex.Message, "Banco de Dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static List<CadastroAluno> ListarTodos()
        {
            var lista = new List<CadastroAluno>();

            try
            {
                using var conexao = ConexaoBanco.ObterConexao();
                conexao.Open();

                const string sql = @"SELECT id, rm, nome, cpf, email
                                     FROM Alunos
                                     ORDER BY id DESC";

                using var cmd = new MySqlCommand(sql, conexao);
                using var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new CadastroAluno
                    {
                        Id = dr.GetInt32("id"),
                        Rm = dr.GetString("rm"),
                        Nome = dr.GetString("nome"),
                        Cpf = dr.GetString("cpf"),
                        Email = dr.GetString("email")
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar: " + ex.Message, "Banco de Dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lista;
        }
    }
}

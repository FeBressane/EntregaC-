# Cadastro de Alunos (WinForms + MySQL)

## 📝 Descrição breve

Este projeto é uma aplicação **Windows Forms (.NET)** para **cadastro de alunos** com os campos **RM (7 dígitos), Nome, CPF (11 dígitos) e E-mail**.  
A interface (`Form1`) coleta os dados, executa **validações simples** e aciona a classe `CadastroAluno`, que concentra a **regra de negócio** e as operações com o banco (hoje **Create** e **Read**). A conexão com o **MySQL** é centralizada em `ConexaoBanco`, e o **DataGridView** exibe a listagem de registros.

- **Arquitetura enxuta**: UI (Form) → Model (`CadastroAluno`) → Infra (`ConexaoBanco`) → MySQL.  
- **Banco**: script `dbAlunos.sql` cria a base `dbAluno` e a tabela `Alunos`.  
- **Segurança**: consultas **parametrizadas** para evitar SQL injection; use `ConexaoBanco.cs.example` para não versionar credenciais.  
- **Status das funcionalidades**: **Cadastrar** e **Listar** prontos; **Editar/Excluir** e **Exportar/Importar (JSON/TXT)** planejados.

> ⚠️ Segurança: o repositório deve conter **`ConexaoBanco.cs.example`** (sem senha).  
> No ambiente local, copie/renomeie para **`ConexaoBanco.cs`** e configure sua senha. Não faça commit do arquivo com credenciais.

---

## 🧱 Tecnologias

- .NET (Windows Forms)
- MySQL Server + MySQL Workbench
- NuGet: `MySql.Data`

---

## 🗄️ Banco de Dados

Execute o script abaixo no MySQL:

```sql
CREATE DATABASE IF NOT EXISTS dbAluno
  DEFAULT CHARACTER SET utf8mb4
  DEFAULT COLLATE utf8mb4_general_ci;

USE dbAluno;

CREATE TABLE IF NOT EXISTS Alunos (
  id    INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  rm    VARCHAR(7)   NOT NULL,
  nome  VARCHAR(100) NOT NULL,
  cpf   VARCHAR(11)  NOT NULL,
  email VARCHAR(100) NOT NULL
) DEFAULT CHARSET=utf8mb4;

-- (Opcional) Evitar duplicidades
-- ALTER TABLE Alunos
--   ADD UNIQUE KEY uq_alunos_rm (rm),
--   ADD UNIQUE KEY uq_alunos_cpf (cpf),
--   ADD UNIQUE KEY uq_alunos_email (email);

create database dbaluno
default character set utf8mb4
default collate utf8mb4_general_ci;

use dbAluno;

create table if not exists Alunos (
	id int not null auto_increment primary key,
    rm varchar(7) not null,
    nome varchar(100) not null,
    cpf varchar(11) not null,
    email varchar(100) not null
) default char set utf8mb4;
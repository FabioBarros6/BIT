/* Criar bando de dados */
create database bd_Crud

/* seleciona o banco de dados */
use db_Crud

/*Criação da tabela */
create table cadastro (
	Id int not null identity,
    Nome varchar(60) not null,
    Endereço varchar(60) not null,
    CEP varchar(9)
    Bairro varchar (50)
    Cidade varchar (50)
    UF varchar (2)
    Telefone varchar(15)
    constraint pk_cadastro primary key(Id)
)

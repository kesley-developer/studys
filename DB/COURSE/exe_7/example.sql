drop database cadaster; /* Este comando elimina a base de dados */

/* Criando nova base e definido os tipos de caractéres como acentuação em letras */
create database cadaster 
default character set utf8mb4 
default collate utf8mb4_general_ci;

/* Criando tabela */
use cadaster;
create table persons(
    
    id int not null auto_increment, /* Criando campo para a chave primária */    

    nome varchar(30) not null,
    nascimento date,
    sexo enum('M','F'),
    peso decimal(5,2),
    altura decimal(3,2),
    nacionalidade varchar(20) default 'Brasil',

    primary key(id) /* Definindo a chave primária */

) default charset = utf8mb4;
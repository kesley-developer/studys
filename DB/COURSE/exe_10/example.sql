use cadaster;

/* Criando a tabela */
create table persons(

    id int not null auto_increment,
    nome varchar(30) not null,
    cpf varchar(12) not null unique /* UNIQUE informa que o campo tem valor único */

) default charset = utf8mb4;
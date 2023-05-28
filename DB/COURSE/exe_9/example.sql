use cadaster;
desc persons; /* Descrevendo(visualizando) tabela */

/* INSERINDO CAMPO */
alter table persons 
add column profissao varchar(20);

/* INSERINDO CAMPO NA PRIMEIRA POSIÇÃO */
alter table persons
add column profissao varchar(10) first; 

/* INSERINDO CAMPO DEPOIS DE UM OUTRO */
alter table persons
add column profissao varchar(30) after nome; 

/* MODIFICANDO COLUNA EXISTENTE */
alter table persons
modify column profissao varchar(40) not null default '';

/* RENOMEANDO COLUNA */
alter table persons
change profissao profission varchar(30);

/* RENOMEANDO TABELA */
alter table persons
rename to pessoas;

/* ADICIONANDO UMA CHAVE PRIMARIA COM ALTER TABLE */
alter table persons
add column id_register int first;

alter table persons
add primary key(id);


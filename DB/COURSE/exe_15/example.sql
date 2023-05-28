use cadaster;

/* CRIANDO TABELA COM A FOREIGN KEY(CHAVE ESTRANGEIRA) */
create table view(
    'id' int not null auto_increment,
    'data' date,
    'idusuario' int,
    'idcurso' int,
    primary key('id'), /* Definindo PRIMARY KEY(CHAVE PRIMÁRIA) */
    foreign key('idusuario') references persons('id'), /* Definindo FOREIGN KEY(CHAVE ESTRANGEIRA) e sua ligação */
    foreign key('idcurso') references courses('idcurso'); /* Definindo outra FOREIGN KEY(CHAVE ESTRANGEIRA)
)


/* ADICIONANDO A FOREIGN KEY(CHAVE ESTRANGEIRA) A UMA TABELA EXISTENTE */
alter table persons
add column cursodousuario; /* Coluna para chave estrangeira */

alter table persons
add foreign key(cursoodousuario)
references courses(idcurso); /* Passando a refêrencia para a relação */

/* JUNÇÃO DE DUAS TABELAS */
select persons.nome,courses.nome,courses.ano from persons join courses /* join - sem prioridade */
on courses.idcurso = persons.cursodousuario /* on - fundamental para indicar a relação */

select persons.nome,courses.nome,courses.ano from persons left join courses /* left join - prioridade a esquerda */
on courses.idcurso = persons.cursodousuario;

select persons.nome, courses.nome,courses.ano from persons right join courses /* right join - prioridade a direita */
on courses.idcurso = persons.cursodousuario;

/* JUNÇÃO DE VÁRIAS TABELAS */
select persons.nome, courses.nome from persons join view on persons.id = view.idusuario
join courses on courses.idcurso = view.idcurso; 
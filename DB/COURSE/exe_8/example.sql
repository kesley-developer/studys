use cadaster;

/* INSERÇÃO DE FORMA DEFINIDA ↓ */

/* Informando campos da tabela */
insert into persons
(id,nome,nascimento,sexo,peso,altura,nacionalidade)

/* Adicionando valores aos campos */
values
(default,'Mario','1995-12-20','M','90.5','1.90',default)


/* INSERÇÃO DE FORMA SEQUÊNCIAL ↓ */

insert into persons values
(default,'Kesley','2002-04-03','M','80.5','1.72','México'),
(default,'Isabella','200-04-05','F','90.7','1.75',default)
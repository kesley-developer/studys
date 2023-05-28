use cadaster;

/* SELECIONAR TUDO */
select * from persons;

/* ORDENAÇÃO CRESCENTE */
select * from persons
order by nome asc;

/* ORDENAÇÃO DECRESCENTE */
select * from persons
order by nome desc;

/* SELEÇÃO DE COLUNAS */
select nome,sexo from persons;

/* SELECIONANDO LINHAS */
select * from persons
where sexo = 'M';

/* OPERADORES DE RELAÇÃO */
select nome,sexo,ano from persons
where ano between 1990 and 2000; /* entre */

select nome,sexo,ano from persons
where in('2000','2001','2002'); /* Em */

select nome,sexo,ano from persons
where ano >= 2000; /* Maior ou igual */

select nome,sexo,ano from persons
where ano <= 2000; /* Menor ou igual */

select nome,sexo,ano from persons
where ano = 2000 or ano = 2001; /* Ou */

select nome,sexo,ano from persons
where ano != 2000; /* Diferente */

select nome,sexo,ano from persons
where nome like 'A%'; /* Registros que começam com tal caractere */

/* DISTINGUINDO */
select distinct ano from persons;

/* FUNÇÕES DE AGREGAÇÃO */
select count(*) from persons; /* Contar */

select max(ano) from persons; /* Valor máximo do campo */

select min(ano) from persons; /* Valor mínimo do campo */

select sum(ano) from persons; /* Somar valores do campo */

select avg(ano) from persons; /* Média do campo */

/* AGRUPANDO */
select ano,count(ano) from persons
group by ano;

/* AGRUPAMENTO ESPECÍFICO */
select ano,count(ano) from persons
group by ano
having ano >= 2000 /* Agrupar somente quem tem... */

/* JUNÇÃO DE SELECT */
select nome,ano,peso from persons
where peso > (select avg(peso) from persons); /* Passando SELECT no parâmetro */
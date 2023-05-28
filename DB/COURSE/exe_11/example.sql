use cadaster;

/* MODIFICANDO LINHAS */

update courses /* Aplicando comando */
set nome = 'HTML5', ano = '2021' /* Atualizando os campos de NOME e ANO e informando novo valor */
where id = '1' /* Informando chave primária(identificação do registro)

/* REMOVENDO LINHA */

delete from courses; 
where id = '2' /* Informando linha a ser deletada através da chave primária */

/* REMOVENDO TODAS AS LINHAS */

truncate table courses; /* Removendo todos os registros da tabela COURSES */
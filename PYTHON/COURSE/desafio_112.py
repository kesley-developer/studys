'''Dentro do pacote utilidadesCeV que criamos no desafio 111, temos um módulo chamado dado. Crie
    uma função chamada leiaDinheiro() que seja capaz de funcionar como a função input(), mas com
    uma validação de dados para aceitar apenas valores que sejam monetários'''

from desafio111_112.utilidadesCEV import moeda,dado

val = dado.leiadinheiro('Digite um valor R$: ')
moeda.resumo(val,20,40)
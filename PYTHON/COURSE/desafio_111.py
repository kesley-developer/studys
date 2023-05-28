'''Crie um pacote chamado utilidadesCeV que tenha dois módulos internos chamados moeda e dado.
    Transfira todas as funções utilizadas nos desafios 107,108,109 e 110 para o primeiro pacote e
    mantenha tudo funcionando'''

from desafio111_112.utilidadesCEV import moeda

val = float(input('Valor R$: '))
moeda.resumo(val,20,40)

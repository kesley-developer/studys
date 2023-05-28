'''Modifique as funções que foram criadas no desafio 107 para que elas aceitem um
    parâmetro a mais, informando se o valor retornado por elas vai ser ou não formatado
    pela função moeda(), desenvolvida no desafio 108'''

from desafio109 import moeda

money = float(input('Valor R$: '))
print(f'{moeda.moeda(money)} com 20% de aumento é igual a {moeda.aumentar(money,20,True)}')
print(f'{moeda.moeda(money)} com 15% de desconto é igual a {moeda.diminuir(money,15,True)}')      # Aplicando o módulo no programa principal
print(f'{moeda.moeda(money)} dobrado é igual a {moeda.dobro(money,True)}')
print(f'{moeda.moeda(money)} pela metade é igual a {moeda.metade(money,True)}')

help(moeda.ajuda)                           # Ajuda interativa

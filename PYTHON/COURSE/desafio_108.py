'''Adapte o código do desafio 107, criando uma função adicional chamada
    moeda() que consiga mostrar os valores como um valor monetário formatado'''

from desafio108 import moeda

money = float(input('Valor R$: '))
print(f'{moeda.moeda(money)} com 20% de aumento é igual a {moeda.moeda(moeda.aumentar(money,20))}')
print(f'{moeda.moeda(money)} com 15% de desconto é igual a {moeda.moeda(moeda.diminuir(money,15))}')      # Aplicando o módulo no programa principal
print(f'{moeda.moeda(money)} dobrado é igual a {moeda.moeda(moeda.dobro(money))}')
print(f'{moeda.moeda(money)} pela metade é igual a {moeda.moeda(moeda.metade(money))}')

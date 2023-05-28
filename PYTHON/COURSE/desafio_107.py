'''Crie um módulo chamado moeda.py que tenha as funções incorporadas aumentar(),
    diminuir(),dobro() e metade(). Faça também um programa que importe esse módulo
    e use algumas dessas funções'''

from desafio107 import moeda                    # Importando o módulo criado

money = float(input('Valor R$: '))
print(f'{money} com 20% de aumento é igual a {moeda.aumentar(money,20)}')
print(f'{money} com 15% de desconto é igual a {moeda.diminuir(money,15)}')      # Aplicando o módulo no programa principal
print(f'{money} dobrado é igual a {moeda.dobro(money)}')
print(f'{money} pela metade é igual a {moeda.metade(money)}')

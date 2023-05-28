'''Faça um programa que leia 5 valores numéricos e guarde - os em uma lista.
   No final, mostre qual foi o maior e o menor valor digitado e as suas respectivas posições na lista'''

print('{:^50}'.format('LEITURA DE 5 VALORES'))
maior = menor = 0
lista = []
for p in range(0,5):
    lista.append(int(input(f'Digite um valor para a posição {p}: ')))
    if p == 0:
        maior = menor = lista[p] 
    else:
        if lista[p] >= maior:
            maior = lista[p]
        if lista[p] <= menor:
            menor = lista[p]
print(f'Valores digitados: {lista}')
print(f'O Maior valor digitado é {maior} que apareceu nas posições ',end = '') # Método para descobrir as posiçoes dos maiores
for posic,numero in enumerate(lista):
    if numero >= maior:
        print(f'{posic}... ',end = '')
print()

print(f'O Menor valor digitado é {menor} que apareceu nas posições ',end = '') # Método para descobrir as posições dos menores
for posic,numero in enumerate(lista):
    if numero <= menor:
        print(f'{posic}... ',end = '')
print()
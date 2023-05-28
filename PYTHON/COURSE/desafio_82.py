'''Crie um programa que vai ler vários números e colocar em uma lista. Depois
    disso, crie duas listas extras que vão conter apenas os valores pares e os
    valores ímpares digitados respectivamente. Ao final, mostre o conteúdo das três lista geradas'''

print('{:^50}'.format('ÍMPARES E PARES COM LISTA'))
numeros = []
pares = []
impares = []
while True:
    num = int(input('Digite um valor: '))
    numeros.append(num)
    if num % 2 == 0:
        pares.append(num)
    else:
        impares.append(num)
    cont = str(input('Deseja continuar?[S/N]: ')).upper().strip()[0]
    while cont not in 'SN':
        print('Digito inválido! Tente novamente!')
        cont = str(input('Deseja continuar?[S/N]: ')).upper().strip()[0]
    if cont in 'N':
        print('-' * 40)
        break
print(f'Valores digitados: {numeros}')
print(f'Pares: {pares}')
print(f'Impares: {impares}')
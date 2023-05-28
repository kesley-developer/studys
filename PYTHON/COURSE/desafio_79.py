'''Crie um programa onde o usuario possa digitar vários valores numéricos
    e cadastre - os em uma lista. Caso o número já exista lá dentro, ele não será adicionado. 
    No final, serão exibidos todos os valores únicos digitados, em ordem crescente'''

print('{:^50}'.format('CADASTRO NUMÉRICO'))
numeros = []
while True:
    num = int(input('Digite um numero para adicionar a lista: '))
    if num not in numeros:
        numeros.append(num)                                       # Metodo para verificar se o numero ja foi adicionado a lista
        print(f'Valor {num} adicionado!')
        cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]  
    else:
        print('Este valor já foi adicionado! Tente outro!')
    while cont not in 'SsNn':
        print('Digito inválido! Tente novamente!')
        cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    if cont in 'Nn':
        print('-' * 40)
        break
print(f'Valores adicionados: {sorted(numeros)}')





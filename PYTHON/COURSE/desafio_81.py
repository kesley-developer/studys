'''Crie um programa que vai ler vários números e colocar em uma lista, depois disso, mostre
    quantos números foram digitados, a lista de valores ordenada de forma decrescente e se 
    o valor 5 foi digitado e está ou não na lista'''

print('{:^50}'.format('LEITURA DE VALORES 2.0'))
lista = []
cinco = False
while True:
    num = int(input('Digite um número: '))
    if num == 5:
        cinco += True
    lista.append(num)
    cont = str(input('Deseja continuar?[S/N]: ')).upper().strip()[0]
    while cont not in 'SN':
        print('Digito inválido! Tente novamente!')
        cont = str(input('Deseja continuar?[S/N]: ')).upper().strip()[0]
    if cont in 'N':
        print('-' * 40)
        break
lista.sort(reverse= True)
print(f'Lista em ordem decrescente: {lista}')
print(f'Quantidades de números na lista: {len(lista)}')    
if cinco == True:
    print('O Numero 5 está na lista!')
else:
    print('O Numero 5 não foi digitado!')
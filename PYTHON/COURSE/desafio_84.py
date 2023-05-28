'''Faça um programa que leia nome e peso de várias pessoas, guardando tudo
    em uma lista. No final, mostre quantas pessoas foram cadastradas
    uma listagem com as pessoas mais pesadas e uma mensagem com as
    pessoas mais leves'''

dados = []
maior = menor = 0
pesados = []
leves = []
count = 0
while True:
    nom = str(input('Nome: ')).capitalize()
    pes = float(input('Peso: '))
    dados.append([nom,pes])
    if count == 0:
        maior = menor = pes
    else:
        if pes > maior:
            maior = pes
        if pes < menor:
            menor = pes
    count += 1
    cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    while cont not in 'SsNn':
        print('Digito inválido! Tente novamente!')
        cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    if cont in 'Nn':
        print('-' * 40)
        break
print(f'Foram registradas {len(dados)} Pessoas')
print(f'{maior} KG foi o maior peso registrado que é o peso de ',end = ' ')
for posic in dados:
    if posic[1] == maior:               # Analisando e reconhecendo os mais pesados e mais leves
        print(f'{posic[0]}')
print()
print(f'{menor} KG foi o menor peso registrado que e o peso de ',end = ' ')
for posic in dados:                             
    if posic[1] == menor:
        print(f'{posic[0]}')
print()
    
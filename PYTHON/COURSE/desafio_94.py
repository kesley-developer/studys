'''Crie um programa que leia nome, sexo e idade de várias pessoas, guardando os dados de cada
    pessoa em um dicionário e todos os dicionários em uma lista. No final, mostre quantas pessoas
    foram cadastradas, a média de idade do grupo, uma lista com todas as mulheres e uma lista com todas 
    as pessoas com idade acima da média'''

pessoa = {}
dados = []
count = soma = 0
females = []
while True:
    pessoa['NOME'] = str(input('Nome: ')).capitalize()
    sex = str(input('Sexo[M/F]: ')).strip()[0]
    while sex not in 'MmFf':                                
        print('Sexo inválido! Tente novamente!')           # Adicionando os dicionarios de cada pessoa na lista
        sex = str(input('Sexo[M/F]: ')).strip()[0]
    if sex in 'Mm':
        pessoa['SEXO'] = 'Masculino'
    if sex in 'Ff':
        pessoa['SEXO'] = 'Feminino'
        females.append(pessoa['NOME'])
    pessoa['IDADE'] = int(input('Idade: '))
    soma += pessoa['IDADE']
    count += 1
    dados.append(pessoa.copy())
    cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    while cont not in 'SsNn':
        print('Digito inválido! Tente novamente!')
        cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    if cont in 'Nn':
        break
media = soma / count
print('-' * 40)
print(f'--- Foram cadastradas {count} pessoas ---')
print(f'--- A média de idade do grupo é de {media:.2f} anos ---')
if females != []:
    count = 0
    print(f'Lista de mulheres cadastradas: ',end = '')          # Montando a listagem de mulheres cadastradas
    for posic in females:
        print(f'{females[count]}',end =' ')
        count += 1
else:
    print('--- Mulheres não foram cadastradas! ---')
print()
print('-' * 40)
print('Pessoas com idade acima da média')
print()
for posic in dados:                                             
    if posic['IDADE'] >= media:                      # Montando a listagem de pessoas com idade acima da média
        print(f'Nome: {posic["NOME"]}')
        print(f'Idade: {posic["IDADE"]}')
        print(f'Sexo: {posic["SEXO"]}')
        print()
    


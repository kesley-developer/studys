'''CADASTRO DE PESSOAS COM VISUALIZAÇÃO EM TABELA'''

pessoas = {}
dados = []
while True:
    pessoas['NOME'] = str(input('Nome: ')).capitalize().split()[0]
    
    pessoas['SEXO'] = str(input('Sexo[M/F]: ')).strip()[0]
    while pessoas['SEXO'] not in 'MmFf':
        print('Sexo inválido! Tente novamente!')
        pessoas['SEXO'] = str(input('Sexo[M/F]: ')).strip()[0]
    if pessoas['SEXO'] in 'Mm':
        pessoas['SEXO'] = 'Masculino'
    if pessoas['SEXO'] in 'Ff':
        pessoas['SEXO'] = 'Feminino'
    
    pessoas['IDADE'] = int(input('Idade: '))
    if pessoas['IDADE'] >= 0:
        pessoas['GENERO'] = 'Criança'
    if pessoas['IDADE'] >= 11:
        pessoas['GENERO'] = 'Pré - adolescente'
    if pessoas['IDADE'] >= 14:
        pessoas['GENERO'] = 'Adolescente'
    if pessoas['IDADE'] >= 21:
        pessoas['GENERO'] = 'Adulto'
    if pessoas['IDADE'] >= 50:
        pessoas['GENERO'] = 'Idoso'
    dados.append(pessoas.copy())
    cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    while cont not in 'SsNn':
        print('Digito inválido! Tente novamente!')
        cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    if cont in 'Nn':
        break
print()
print('{:^50}'.format('TABELA DOS CADASTRADOS'))
print('_' * 52)
for key in pessoas:
    print(f'{key:^12}',end = '|')
print()
print('_' * 52)
for posic in dados:
    print(f'{posic["NOME"]:^12}|{posic["SEXO"]:^12}|{posic["IDADE"]:^12}|{posic["GENERO"]:^12}|')

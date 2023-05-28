'''Faça um programa que leia nome e média de um aluno, guardando também a situação
    em um dicionário. No final, mostre o counteúdo da estrutura na tela'''

alunos = {}
dados = []
med = 0
while True:
    alunos['NOME'] = str(input('Nome do aluno: ')).capitalize()
    n1 = float(input('Primeira nota: '))
    n2 = float(input('Segunda nota: '))
    med = (n1 + n2) / 2
    alunos['MEDIA'] = med
    if med < 5:
        alunos['SITUAÇÃO'] = 'Reprovado'
    if med >= 5:
        alunos['SITUAÇÃO'] = 'Recuperação'
    if med >= 6:
        alunos['SITUAÇÃO'] = 'Aprovado'        # Adicionando os dados do aluno dentro do dicionario
    dados.append(alunos.copy())
    alunos.clear()
    cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    while cont not in 'SsNn':
        print('Digito inválido! Tente novamente!')
        cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    if cont in 'Nn':
        print('-' * 40)
        break
for posic in dados:
    print(f'Nome do aluno: {posic["NOME"]}')
    print(f'Média do aluno: {posic["MEDIA"]}')              # Mostrando dados e situação de todos os alunos
    print(f'Situação do aluno: {posic["SITUAÇÃO"]}')    
    print('-' * 40)

    
    
    
    

    
'''Crie um programa que leia nome e duas notas de vários alunos e guarde tudo em uma
    lista composta. No final, mostre um boletim contendo a média de cada um e permita
    que o usuário possa mostrar as notas de cada aluno individualmente'''

dados = []
while True:
    nom = str(input('Nome do aluno: ')).capitalize()
    n1 = float(input('1º Nota: '))
    n2 = float(input('2º Nota: '))
    med = f'{(n1 + n2) / 2:.1f}'
    dados.append([nom,n1,n2,med])
    cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    while cont not in 'SsNn':
        print('Digito inválido! Tente novamente!')
        cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    if cont in 'Nn':
        break
print('-' * 40)
print('Nº  ALUNO            MÉDIA      ')
print('-' * 40)
count = 0
for posic in dados:
    print(f'{count:<} - {posic[0]:<10} {posic[3]:>10}')         # Organizando o boletim
    count += 1
print('-' * 40)
while True:
    user = int(input('Deseja ver dados de qual aluno?[999 para encerrar]: '))
    while user < 0 or user > count:
        print('Digito inválido! Tente novamente!')
        user = int(input('Deseja ver dados de qual aluno?[999 para encerrar]: '))
    if user == 999:
        break
    print(f'{dados[user][0]} Teve as seguintes notas: {dados[user][1:3]}')   # Montagem dos dados individuais
print('-' * 40)
print('PROGRAMA ENCERRADO')
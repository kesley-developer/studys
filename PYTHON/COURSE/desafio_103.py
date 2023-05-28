'''Faça um programa que tenha uma função chamada ficha(), que receba dois parâmetros opcionais:
    o nome de um jogador e quantos gols ele marcou. O programa deverá ser capaz de mostrar a ficha
    do jogador, mesmo que algum dado não tenha sido informado corretamente'''

def ficha(name = 'Desconhecido',goals = 0):
    if n in '':
        name = 'Desconhecido'                                       # Definindo funcionalidades do parâmetro
    if goals in '' or g.isnumeric() == False:
        goals = 0
    print('-' * 40)
    print(f'O jogador {name} marcou {goals} no total')
    print('-' * 40)
n = str(input('Nome do jogador: ')).capitalize().strip()            # Ajustando o nome e gols do jogador
g = input('Gols: ').strip()
ficha(n,g)





    









    

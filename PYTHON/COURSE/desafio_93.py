'''Crie um programa que gerencie o aproveitamento de um jogador de futebol. O programa vai ler o nome
    do jogador e quantas partidas ele jogou. Depois vai ler a quantidade de gols feitos em cada
    partida. No final, tudo isso será guardado em um dicionário, incluindo o total de gols feitos durante o campeonato'''

import time
gols = []
jogador = {}
total = 0
nom = str(input('Nome do jogador: ')).capitalize()
jogador['NOME'] = nom
part = int(input(f'{nom} jogou quantas partidas?: '))
for c in range(part):
    gol = int(input(f'Gols na {c + 1}º partida: '))
    gols.append(gol)
    total += gol
jogador['GOLS'] = gols
jogador['TOTAL'] = total
print(jogador)
print('-' * 40)
lista = []
lista.append(jogador)
for posic in lista:
    print(f'Nome do jogador: {posic["NOME"]}')
    print(f'Gols por partida: {posic["GOLS"]}')
    print(f'Total de gols: {posic["TOTAL"]}')
print(f'-' * 40)
print(f'{nom} jogou {part} partidas')
time.sleep(1)
count = 0
for posic in gols:
    print(f'--- Na {count + 1}º partida ele marcou {gols[count]} gols ---')
    count += 1
    time.sleep(1)
print()
print(f'--- {nom} marcou {total} gols na temporada ---')

    


    

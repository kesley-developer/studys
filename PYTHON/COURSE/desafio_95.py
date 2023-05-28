'''Aprimore o desafio 093 para que ele funcione com vários jogadores, incluindo um sistema
    de visualização de detalhes do aproveitamento de cada jogador'''

import time
jogador = {}
gols = []
dados = []
total = 0
while True:
    gols.clear()
    total = 0
    jogador['NOME'] = str(input('Nome do jogador: ')).capitalize()
    part = int(input(f'{jogador["NOME"]} jogou quantas partidas?: '))
    for c in range(part):
        gol = int(input(f'Gols na {c + 1}º partida: '))
        total += gol
        gols.append(gol)
    jogador['GOLS'] = gols[:]
    jogador['TOTAL'] = total
    dados.append(jogador.copy())
    cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    while cont not in 'SsNn':
        print('Digito inválido! Tente novamente!')
        cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    if cont in 'Nn':
        break
print('-' * 40)
print(' Nº ',end = '')
for key in dados[0].keys():
    print(f'{key:<15}',end = '')
print()
for key,val in enumerate(dados):            # Enumerando cada dicionario dentro da lista
    print(f'{key:>3} ',end = '')              
    for posic in val.values():
        print(f'{str(posic):<15} ',end = '')
    print()
print()        
print('-' * 40)
while True:
    jog = int(input('Deseja ver os dados de qual jogador?[999 encerrar]: '))                # Montando a estatistica de acordo com a numeração do jogador
    if jog == 999:
        break
    if jog < 0 or jog > len(dados) - 1:
        print('Numeração inválida! Tente novamente!')
    else:   
        print('-' * 40)
        print(f'--- Estatisticas do jogador {dados[jog]["NOME"]} ---')
        count = 0
        for c in range(len(dados[jog]["GOLS"])):
            print(f'Na {c + 1}º partida marcou {dados[jog]["GOLS"][c]} gols')
            time.sleep(1)
        print()
        print(f'{dados[jog]["NOME"]} marcou {dados[jog]["TOTAL"]} gols no total')
        print()
print('-' * 40)
print('PROGRAMA ENCERRADO')
        
       

        


        
    


    
'''SIMULADOR DA MEGA - SENA'''

import colorama; colorama.init()
from random import randint
from time import sleep

print(f'\n\033[1;32m{"MEGA - SENA PYTHON VERSION":^40}\033[m\n')
sleep(0.5)
jog = [] 
for c in range(6):
        user = int(input(f'{c + 1}º Palpite: '))
        print()
        while user < 1 or user > 60 or user in jog:
            print('\033[1;31mO seu palpite deve ser entre 1 a 60! Não repita digitos!\033[m')
            user = int(input(f'{c + 1}º Palpite: '))
        else:
            jog.append(user)
            print()
            print(f'Sua aposta: \033[1;33m{jog}\033[m')
sleep(1)
print()
print(f'Seu palpite é: \033[1;33m{jog}\033[m')
print()
load = ['.','.','.']
print('Sorteando números',end ='')
for p in load:
    sleep(00.50)
    print(f'\033[1;33m{p}\033[m',end ='')
    sleep(00.50)
print()

act = []
numeros = []
for c in range(6):
    num = randint(1,60)
    while num in numeros:
        num = randint(1,60)
    else:
        numeros.append(num)
        if num in jog[:]:
            act.append(num)

print()
print('Numeros sorteados: ',end=' ')
for p in numeros:
    print(f'\033[1;32m{p}\033[m',end=' ')
    sleep(0.5)
print()
sleep(1)

if len(act) > 0:
    print('Seus acertos: ',end =' ')
    for p in act:
        print(f'\033[1;33m{p}\033[m',end =' ')
        sleep(0.5)
    print()
    print()
    sleep(1)
    if len(act) == 1:
        print('- \033[1;34mA sua sorte pode aumentar, tente na próxima!\033[m')
    if len(act) == 2:
        print('- \033[1;34mVocê pode acertar mais nas próximas tentativas\033[m')
    if len(act) == 3:
        print('- \033[1;34mFaltou apenas um para você faturar, talvez na próxima você consiga render\033[m')
    if len(act) == 4:
        print('- \033[1;34mParábens! Você acertou 4 números e faturou \033[1;33mR$ 2000,00\033[m')
    if len(act) == 5:
        print('- \033[1;34mSuper parábens! Você acertou 5 números e faturou \033[1;33mR$ 10000.00\033[m')
    if len(act) == 6:
        print('- \033[1;34mMega parábens! Você acaba de ganhar \033[1;34m10 MILHÕES de reais\033[m')


else:
    print()
    print(f'- \033[1;31mQue pena, você não acertou nenhum! Tente na próxima!\033[m')



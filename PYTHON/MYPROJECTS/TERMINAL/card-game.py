'''JOGO DE CARTAS'''

import colorama ; colorama.init()
from time import sleep
from random import *

def over():
    load = ['G','A','M','E','O','V','E','R']
    for p in load:
        sleep(00.25)
        print(p,end = ''.center(5))

def atrib():
    atr = ['\033[1;31mATAQUE\033[m','\033[1;34mDEFESA\033[m','\033[1;32mAGILIDADE\033[m',
    '\033[1;33mSORTE\033[m','\033[1;35mMAGIA\033[m']
    for p in atr:
        print(f'{p}'.center(40))
    print()

cont = 'S'
usercart = 0
cpucart = 0
cpu = ['Ana','João','Paulo','Maria','John','Isabela','Mario','Joana']
while cont in 'Ss':
    cpuname = choice(cpu)
    print('\033[1;33mJOGO DE CARTAS\033[m'.center(80))
    name = str(input('\nNome do jogador: ')).capitalize().split()[0]
    usercart = int(input('Número de cartas(entre 1 e 10): '))
    while usercart < 1 or usercart > 10:
        print()
        print('\033[1;31mNúmero de cartas inválido! Tente novamente!\033[m')
        usercart = int(input('Número de cartas(entre 1 e 10): '))
        print()
    cpucart = usercart
    print()
    print(f'- Cada jogador irá iniciar o jogo com \033[1;33m{usercart}\033[m cartas')
    sleep(1)
    print(f'- O jogador que tiver o \033[1;33matributo mais elevado\033[m pega uma carta do oponente')
    sleep(1)
    print(f'- Perde aquele que tiver o número de cartas igual a \033[1;33m0\033[m')
    sleep(1)
    print(f'- Seu oponente será \033[1;33m{cpuname}\033[m!')
    sleep(1)
    print(f'- Boa sorte \033[1;33m{name}\033[m!')
    sleep(1)
    print()
    while usercart > 0 and cpucart > 0:
        atrib()
        user = str(input('Escolha um atributo: ')).upper()
        if user not in ['ATAQUE','DEFESA','AGILIDADE','SORTE','MAGIA']:
            print()
            print('\033[1;31mAtributo inválido! Tente novamente!\033[m')
            print()
        
        else:
            jogataque = randint(1,100)
            cpuataque = randint(1,100)
        
            jogdefesa = randint(1,100)
            cpudefesa = randint(1,100)

            jogagilidade = randint(1,100)
            cpuagilidade = randint(1,100)
            
            jogsorte = randint(1,100)
            cpusorte = randint(1,100)
            
            jogmagia = randint(1,100)
            cpumagia = randint(1,100)

            atrjog = [jogataque,jogdefesa,jogagilidade,jogsorte,jogmagia]
            atrcpu = [cpuataque,cpudefesa,cpuagilidade,cpusorte,cpumagia]
                    
            game = ['ATAQUE','DEFESA','AGILIDADE','SORTE','MAGIA']
            
            c = 0
            print()
            print('_' * 40)
            print(f'\033[1;33m{name:<10}\033[m\033[1;31m{cpuname:>30}\033[m')
            for p in game:
                print(f'{p:<10}{atrjog[c]:<5}{"X":^10}{atrcpu[c]:>5}{p:>10}')
                c += 1
            print('_' * 40)
            sleep(2)
        
            if user == 'ATAQUE':
                print(f'\033[1;31mATAQUE\033[m {atrjog[0]:^10}X{atrcpu[0]:^10} \033[1;31mATAQUE\033[m')
                sleep(1)
                if jogataque > cpuataque:
                    print('- O seu atributo é mais elevado')
                    sleep(1)
                    print('\033[1;34m+1 Carta\033[m')
                    usercart += 1
                    cpucart -= 1
                
                if cpuataque > jogataque:
                    print('- O atributo do oponente é mais elevado')
                    sleep(1)
                    print('\033[1;31m-1 Carta\033[m')
                    usercart -= 1
                    cpucart += 1
                
                if jogataque == cpuataque:
                    print('- Os atributos tem a mesma capacidade')

            if user == 'DEFESA':
                print(f'\033[1;34mDEFESA\033[m {atrjog[1]:^10}X{atrcpu[1]:^10} \033[1;34mDEFESA\033[m')
                sleep(1)
                if jogdefesa > cpudefesa:
                    print('- O seu atributo é mais elevado')
                    sleep(1)
                    print('\033[1;34m+1 Carta\033[m')
                    usercart += 1
                    cpucart -= 1

                if cpudefesa > jogdefesa:
                    print('- O atributo do oponente é mais elevado')
                    sleep(1)
                    print('\033[1;31m-1 Carta\033[m')
                    usercart -= 1
                    cpucart += 1

                if jogdefesa == cpudefesa:
                    print('- Os atributos tem a mesma capacidade')

            if user == 'AGILIDADE':
                print(f'\033[1;32mAGILIDADE\033[m {atrjog[2]:^10}X{atrcpu[2]:^10} \033[1;32mAGILIDADE\033[m')
                sleep(1)
                if jogagilidade > cpuagilidade:
                    print('- O seu atributo é mais elevado')
                    sleep(1)
                    print('\033[1;34m+1 Carta\033[m')
                    usercart += 1
                    cpucart -= 1
                
                if cpuagilidade > jogagilidade:
                    print('- O atributo do oponente é mais elevado')
                    sleep(1)
                    print('\033[1;31m-1 Carta\033[m')
                    usercart -= 1
                    cpucart += 1

                if jogagilidade == cpuagilidade:
                    print('- Os atributos tem a mesma capacidade')

            if user == 'SORTE':
                print(f'\033[1;33mSORTE\033[m {atrjog[3]:^10}X{atrcpu[3]:^10} \033[1;33mSORTE\033[m')
                sleep(1)
                if jogsorte > cpusorte:
                    print('- O seu atributo é mais elevado')
                    sleep(1)
                    print('\033[1;34m+1 Carta\033[m')
                    usercart += 1
                    cpucart -= 1
                
                if cpusorte > jogsorte:
                    print('- O atributo do oponente é mais elevado')
                    sleep(1)
                    print('\033[1;31m-1 Carta\033[m')
                    usercart -= 1
                    cpucart += 1

                if jogsorte == cpusorte:
                    print('- Os atributos tem a mesma capacidade')

            if user == 'MAGIA':
                print(f'\033[1;35mMAGIA\033[m {atrjog[4]:^10}X{atrcpu[4]:^10} \033[1;35mMAGIA\033[m')
                sleep(1)
                if jogmagia > cpumagia:
                    print('- O seu atributo é mais elevado')
                    sleep(1)
                    print('\033[1;34m+1 Carta\033[m')
                    usercart += 1
                    cpucart -= 1

                if cpumagia > jogmagia:
                    print('- O atributo do oponente é mais elevado')
                    sleep(1)
                    print('\033[1;31m-1 Carta\033[m')
                    usercart -= 1
                    cpucart += 1

                if jogmagia == cpumagia:
                    print('- Os atributos tem a mesma capacidade')
            
            sleep(1)
            print()
            print(f'Número de cartas')
            print(f'\033[1;33m{name:<10}\033[m{usercart:>10}\n\033[1;31m{cpuname:<10}\033[m{cpucart:>10}')
            sleep(2)
            print()
            if usercart == 0:
                print('\033[1;31mYOU - LOSE\033[m'.center(40))    
                print()
                cont = str(input('Jogar novamente?[S/N]: ')).strip()[0]
                print()
                while cont not in 'SsNn':
                    print('\033[1;31mDigito inválido! Tente novamente!\033[m')
                    cont = str(input('Jogar novamente?[S/N]: ')).strip()[0]
                    print()
                else:
                    if cont in 'Nn':
                        print()
                        over()
                        break
                        
            if cpucart == 0:
                print('\033[1;34mYOU - WIN\033[m'.center(40))
                print()
                cont = str(input('Jogar novamente?[S/N]: ')).strip()[0]
                print()
                while cont not in 'SsNn':
                    print('\033[1;31mDigito inválido! Tente novamente!\033[m')
                    cont = str(input('Jogar novamente?[S/N]: ')).strip()[0]
                    print()
                else:
                    if cont in 'Nn':
                        print()
                        over()
                        break
                    
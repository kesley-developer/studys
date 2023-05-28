'''JOGO DE MATEMATICA'''

import colorama ; colorama.init()
import time
import random

ponto = 0
print('{:^50}'.format('\033[1;33mMATEMATICANDO\033[m'))
nom = str(input('Nome: ')).capitalize().split()[0]
time.sleep(0.5)
print(f'- Seja bem vindo \033[1;33m{nom}\033[m!')
time.sleep(1)
print('- Testarei suas habilidades em matematica\033[m')
time.sleep(0.5)
print('-' * 40)
while True:
    print('Opções:')
    print('0 - Fácil\n1 - Médio\n2 - Dificil\n3 - Avançado')
    nivel = int(input('Escolha uma dificuldade: '))
    while nivel < 0 or nivel > 3:
        print('\033[31mDigito inválido! Tente novamente!\033[m')
        nivel = int(input('Escolha uma dificuldade: '))

    if nivel == 0:
        print('-' * 40)
        print('\033[1;34mFÁCIL\033[m')
        print('-' * 40)
    if nivel == 1:
        print('-' * 40)
        print('\033[1;34mMÉDIO\033[m')
        print('-' * 40)
    if nivel == 2:
        print('-' * 40)
        print('\033[1;34mDIFICIL\033[m')
        print('-' * 40)
    if nivel == 3:
        print('-' * 40)
        print('\033[1;34mAVANÇADO\033[m')
        print('-' * 40)

    print('Opções:')
    print('0 - Soma\n1 - Subtração\n2 - Multiplicação\n3 - Divisão')
    dig = int(input('Escolha uma opção: '))
    while dig < 0 or dig > 3:
        print('\033[31mDigito inválido! Tente novamente!\033[m')
        dig = int(input('Escolha uma opção: '))

    # SOMA
    if dig == 0:
        print('-' * 40)
        print('\033[1;34mSOMA\033[m')
        print('-' * 40)

        if nivel == 0:
            num0 = random.randint(1,20)
            num1 = random.randint(1,20)
            soma = num0 + num1
            jog = int(input(f'{num0} + {num1} = ? '))
            while jog != soma:
                ponto -= 5
                print('\033[31m-5 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} + {num1} = ? '))

        if nivel == 1:
            num0 = random.randint(24,150)
            num1 = random.randint(24,150)
            soma = num0 + num1
            jog = int(input(f'{num0} + {num1} = ? '))
            while jog != soma:
                ponto -= 10
                print('\033[31m-10 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente\033[m')
                jog = int(input(f'{num0} + {num1} = ? '))

        if nivel == 2:
            num0 = random.randint(59,249)
            num1 = random.randint(59,249)
            num2 = random.randint(59,249)
            soma = num0 + num1 + num2
            jog = int(input(f'{num0} + {num1} + {num2} = ? '))
            while jog != soma:
                ponto -= 15
                print('\033[31m-15 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} + {num1} + {num2} = ? '))

        if nivel == 3:
            num0 = random.randint(189,3587)
            num1 = random.randint(285,4557)
            num2 = random.randint(412,5734)
            num3 = random.randint(556,6687)
            soma = num0 + num1 + num2 + num3
            jog = int(input(f'{num0} + {num1} + {num2} + {num3} = ? '))
            while jog != soma:
                ponto -= 20
                print('\033[31m-20 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} + {num1} + {num2} + {num3} = ? '))

        if jog == soma:
            if nivel == 0:
                ponto += 15
                print('\033[34m+15 Pontos\033[m')
            if nivel == 1:
                ponto += 20
                print('\033[34m+20 Pontos\033[m')
            if nivel == 2:
                ponto += 25
                print('\033[34m+25 Pontos\033[m')
            if nivel == 3:
                ponto += 35
                print('\033[34m+35 Pontos\033[m')
            time.sleep(1)
            print('\033[34mParábens! Você acertou!\033[m')


    # SUBTRAÇÃO
    if dig == 1:
        print('-' * 40)
        print('\033[1;34mSUBTRAÇÃO\033[m')
        print('-' * 40)

        if nivel == 0:
            num0 = random.randint(10,20)
            num1 = random.randint(1,10)
            subt = num0 - num1
            jog = int(input(f'{num0} - {num1} = ? '))
            while jog != subt:
                ponto -= 10
                print('\033[31m-10 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} - {num1} = ? '))

        if nivel == 1:
            num0 = random.randint(40,80)
            num1 = random.randint(10,40)
            subt = num0 - num1
            jog = int(input(f'{num0} - {num1} = ? '))
            while jog != subt:
                ponto -= 15
                print('\033[31m-15 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} - {num1} = ? '))

        if nivel == 2:
            num0 = random.randint(80,100)
            num1 = random.randint(40,60)
            num2 = random.randint(10,20)
            subt = num0 - num1 - num2
            jog = int(input(f'{num0} - {num1} - {num2} = ? '))
            while jog != subt:
                ponto -= 20
                print('\033[31m-20 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} - {num1} - {num2} = ? '))

        if nivel == 3:
            num0 = random.randint(180,220)
            num1 = random.randint(80,120)
            num2 = random.randint(60,90)
            num3 = random.randint(40,100)
            subt = num0 - num1 - num2 - num3
            jog = int(input(f'{num0} - {num1} - {num2} - {num3} = ? '))
            while jog != subt:
                ponto -= 25
                print('\033[31m-25 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} - {num1} - {num2} - {num3} = ? '))

        if jog == subt:
            if nivel == 0:
                ponto += 20
                print('\033[34m+20 Pontos\033[m')
            if nivel == 1:
                ponto += 25
                print('\033[34m+25 Pontos\033[m')
            if nivel == 2:
                ponto += 30
                print('\033[34m+30 Pontos\033[m')
            if nivel == 3:
                ponto += 45
                print('\033[34m+45 Pontos\033[m')
            time.sleep(1)
            print('\033[34mParábens! Você acertou!\033[m')

    # MULTIPLICAÇÃO
    if dig == 2:
        print('-' * 40)
        print('\033[1;34mMULTIPLICAÇÃO\033[m')
        print('-' * 40)

        if nivel == 0:
            num0 = random.randint(1,10)
            num1 = random.randint(1,10)
            mult = num0 * num1
            jog = int(input(f'{num0} x {num1} = ? '))
            while jog != mult:
                ponto -= 15
                print('\033[31m-15 Pontos')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} x {num1} = ? '))

        if nivel == 1:
            num0 = random.randint(10,50)
            num1 = random.randint(10,50)
            mult = num0 * num1
            jog = int(input(f'{num0} x {num1} = ? '))
            while jog != mult:
                ponto -= 20
                print('\033[31m-20 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} x {num1} = ? '))

        if nivel == 2:
            num0 = random.randint(59,119)
            num1 = random.randint(59,119)
            mult = num0 * num1
            jog = int(input(f'{num0} x {num1} = ? '))
            while jog != mult:
                ponto -= 25
                print('\033[31m-25 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} x {num1} = ? '))

        if nivel == 3:
            num0 = random.randint(60,246)
            num1 = random.randint(79,357)
            num2 = random.randint(2,5)
            mult = num0 * num1 * num2
            jog = int(input(f'{num0} x {num1} x {num2} = ? '))
            while jog != mult:
                ponto -= 30
                print('\033[31m-30 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} x {num1} = ? '))

        if jog == mult:
            if nivel == 0:
                ponto += 30
                print('\033[34m+30 Pontos\033[m')
            if nivel == 1:
                ponto += 35
                print('\033[34m+35 Pontos\033[m')
            if nivel == 2:
                ponto += 40
                print('\033[34m+40 Pontos\033[m')
            if nivel == 3:
                ponto += 60
                print('\033[34m+60 Pontos\033[m')
            time.sleep(1)
            print('\033[34mParábens! Você acertou!\033[m')

    # DIVISÃO
    if dig == 3:
        print('-' * 40)
        print('\033[1;34mDIVISÃO\033[m')
        print('-' * 40)

        if nivel == 0:
            num0 = random.randint(10,20)
            num1 = random.randint(1,10)
            divi = num0 // num1
            jog = int(input(f'{num0} ÷ {num1} = ? '))
            while jog != divi:
                ponto -= 10
                print('\033[31m-10 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} ÷ {num1} = ? '))

        if nivel == 1:
            num0 = random.randint(80,120)
            num1 = random.randint(10,25)
            divi = num0 // num1
            jog = int(input(f'{num0} ÷ {num1} = ? '))
            while jog != divi:
                ponto -= 15
                print('\033[31m-15 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} ÷ {num1} = ? '))

        if nivel == 2:
            num0 = random.randint(115,359)
            num1 = random.randint(29,60)
            divi = num0 // num1
            jog = int(input(f'{num0} ÷ {num1} = ? '))
            while jog != divi:
                ponto -= 20
                print('\033[31m-20 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} ÷ {num1} = ? '))

        if nivel == 3:
            num0 = random.randint(349,3587)
            num1 = random.randint(119,348)
            divi = num0 // num1
            jog = int(input(f'{num0} ÷ {num1} = ? '))
            while jog != divi:
                ponto -= 40
                print('\033[31m-40 Pontos\033[m')
                time.sleep(1)
                print('\033[31mVocê errou! Tente novamente!\033[m')
                jog = int(input(f'{num0} ÷ {num1} = ? '))

        if jog == divi:
            if nivel == 0:
                ponto += 30
                print('\033[34m+30 Pontos\033[m')
            if nivel == 1:
                ponto += 35
                print('\033[34m+35 Pontos\033[m')
            if nivel == 2:
                ponto += 45
                print('\033[34m+45 Pontos\033[m')
            if nivel == 3:
                ponto += 65
                print('\033[34m+65 Pontos\033[m')
            time.sleep(1)
            print('\033[34mParábens! Você acertou!\033[m')

    cont = str(input('Deseja continuar?[S/N]: ')).upper().strip()[0]
    while cont not in 'SN':
        print('\033[31mDigito inválido! Tente novamente!\033[m')
        cont = str(input('Deseja continuar?[S/N]: ')).upper().strip()[0]
    if cont == 'S':
        time.sleep(0.5)
        print('- Legal\033[m')
        time.sleep(0.5)
        print('-' * 40)
    if cont == 'N':
        time.sleep(1)
        break
print('-' * 40)
print(f'- Você fez \033[1;33m{ponto}\033[m Pontos')
time.sleep(1)
if ponto < 0:
    print(f'- Que pena \033[1;33m{nom}\033[m! Matematica é seu ponto fraco ')
if ponto < 15:
    print(f'- Sinto muito \033[1;33m{nom}\033[m! Seu nivel esta muito baixo em matematica')
if ponto >= 15 and ponto <= 30:
    print(f'- Você precisa treinar mais \033[1;33m{nom}\033[m! Você errou muito')
if ponto >= 31 and ponto <= 60:
    print(f'- Nada mal \033[1;33m{nom}\033[m! Você deu o seu melhor')
if ponto >= 61 and ponto <= 90:
    print(f'- Legal \033[1;33m{nom}\033[m! Você foi bem continue assim')
if ponto >= 91 and ponto <= 120:
    print(f'- Excelente \033[1;33m{nom}\033[m! Você é bom em matematica')
if ponto > 120:
    print(f'- Incrivel \033[1;33m{nom}\033[m! Você é um mestre em matematica')


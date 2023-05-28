'''BANDEIRAS DE PAISES'''

import colorama
import time
colorama.init()

band = ['ALEMANHA','AUSTRIA','RUSSIA','INDONÉSIA','ITALIA','FRANÇA','NIGERIA','ROMENIA','SUIÇA','POLONIA','HOLANDA','JAPÃO','UCRANIA','COLOMBIA','BÉLGICA']
while True:
    print(f'\033[1;4;31m{"BANDEIRAS DISPONIVEIS":^75}\033[m')
    print()
    c = 0
    for p in band:
        print(f'\033[1;33m{band[c]}\033[m',end = '     ')
        c += 1
    print()
    user = str(input('Deseja ver a bandeira de qual pais: ')).strip().upper()
    print()
    if user not in band:
        print('\033[1;31mBandeira indisponivel ou erro de digitação! Tente novamente!\033[m')
    if user == 'ALEMANHA':
        def alemanha():
            print('     ALEMANHA')
            for c in range(2):
                print('\033[40m  ' * 10)
            for c in range(2):
                print('\033[41m  ' * 10)
            for c in range(2):
                print('\033[43m  ' * 10)
        alemanha()

    if user == 'AUSTRIA':
        def austria():
            print('     AUSTRIA')
            for c in range(2):
                print('\033[41m  ' * 10)
            for c in range(2):
                print('\033[107m  ' * 10)
            for c in range(2):
                print('\033[41m  ' * 10)
        austria()    

    if user == 'RUSSIA':
        def russia():
            print('      RUSSIA')
            for c in range(2):
                print('\033[107m  ' * 10)
            for c in range(2):
                print('\033[44m  ' * 10)
            for c in range(2):
                print('\033[41m  ' * 10)
        russia()

    if user == 'INDONÉSIA':
        def indonesia():
            print('      INDONÉSIA')
            for c in range(3):
                print('\033[41m  ' * 10)
            for c in range(3):
                print('\033[107m  ' * 10)
        indonesia()

    if user == 'ITALIA':
        def italia():
            print('      ITALIA')
            for c in range(2):
                print('\033[42m      \033[107m      \033[41m      ')    
                print('\033[42m      \033[107m      \033[41m      ')    
                print('\033[42m      \033[107m      \033[41m      ')    
        italia()

    if user == 'FRANÇA':
        def franca():
            print('      FRANÇA')
            for c in range(2):
                print('\033[44m       \033[107m       \033[41m       ')
                print('\033[44m       \033[107m       \033[41m       ')
                print('\033[44m       \033[107m       \033[41m       ')
        franca()

    if user == 'NIGERIA':
        def nigeria():
            print('      NIGERIA')
            for c in range(2):
                print('\033[42m       \033[107m       \033[42m       ')
                print('\033[42m       \033[107m       \033[42m       ')
                print('\033[42m       \033[107m       \033[42m       ')
        nigeria()

    if user == 'ROMENIA':
        def romenia():
            print('      ROMENIA')
            for c in range(2):
                print('\033[44m       \033[43m       \033[41m       ')
                print('\033[44m       \033[43m       \033[41m       ')
                print('\033[44m       \033[43m       \033[41m       ')
        romenia()

    if user == 'SUIÇA':
        def suica():
            print('      SUIÇA') 
            for c in range(1):
                print('\033[41m                    ')
                print('\033[41m         \033[107m  \033[41m         ')
                print('\033[41m      \033[107m   \033[107m  \033[107m   \033[41m      ')
                print('\033[41m         \033[107m  \033[41m         ')
                print('\033[41m                    ')
        suica()

    if user == 'POLÔNIA':
        def polonia():
            print('      POLÔNIA')
            for c in range(3):
                print('\033[107m  ' * 10)
            for c in range(3):
                print('\033[41m  ' * 10)
        polonia()

    if user == 'HOLANDA':
        def holanda():
            print('      HOLANDA')
            for c in range(2):
                print('\033[41m  ' * 10)
            for c in range(2):
                print('\033[107m  ' * 10)
            for c in range(2):
                print('\033[44m  ' * 10)
        holanda()

    if user == 'JAPÃO':
        def japao():
            print('            JAPÃO')
            for c in range(1):
                print('\033[107m                              ')
                print('\033[107m                              ')
                print('\033[107m          \033[41m          \033[107m          ')
                print('\033[107m          \033[41m          \033[107m          ')
                print('\033[107m          \033[41m          \033[107m          ')
                print('\033[107m                              ')
                print('\033[107m                              ')
        japao()

    if user == 'UCRANIA':
        def ucrania():
            print('      UCRANIA')
            for c in range(3):
                print('\033[104m  ' * 10)
            for c in range(3):
                print('\033[103m  ' * 10)
        ucrania()

    if user == 'COLOMBIA' or user == 'COLÔMBIA':
        def colombia():
            print('      COLÔMBIA')
            for c in range(2):
                print('\033[43m  ' * 10)
            for c in range(2):
                print('\033[44m  ' * 10)
            for c in range(2):
                print('\033[41m  ' * 10)
        colombia()

    if user == 'BÉLGICA':
        def belgica():
            print('      BÉLGICA')
            for c in range(2):
                print('\033[40m       \033[43m       \033[41m       ')
                print('\033[40m       \033[43m       \033[41m       ')
                print('\033[40m       \033[43m       \033[41m       ')
        belgica()
    
    print('\033[m')
    cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    while cont not in 'SsNn':
        print('\033[1;31mDigito inválido! Tente novamente!\033[m')
        cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    if cont in 'Nn':
        break
print('-' * 40)
print('\033[1;97mTHANK YOU\033[m')
print('-' * 40)
'''CADASTRO DE PESSOAS COM USO DE CLASSES'''

import colorama ; colorama.init()
from time import sleep

info = ['1 - Mais pesado','2 - Mais Velho','3 - Sair']
pessoas = []
maior = 0
class pessoa:
    def __init__():
        pass
    
    def cadastro():
        loop = True
        while loop == True:
            n = str(input('Nome: ')).capitalize().split()[0]
            i = int(input('Idade: '))
            p = float(input('Peso: '))
            pessoas.append([n,i,p])
            while loop == True:
                cont = str(input('Deseja continuar?: ')).upper()
                print()
                if cont not in ['SIM','NAO','NÃO']:
                    print('\033[1;31mDigito inválido! Tente novamente!\033[m')
                if cont == 'SIM':
                    break
                if cont in ['NÃO','NAO']:
                    loop = False
                    
pessoa.cadastro()
print(f'{"Nome":<20}{"Idade":<20}{"Peso KG":<20}')
print('_' * 50)
for p in pessoas:
    print(f'{p[0]:<20}{p[1]:<20}{p[2]:<20.1f}')
print('_' * 50)

while True:
    try:
        while True:
            for p in info:
                print(f'{p}')
            user = int(input('Escolha uma opção para acessar: '))
            print()
            if user < 1 or user > 3:            
                print('\033[1;31mEscolha uma opção válida!\033[m')
                print()
                sleep(1)
            else:
                break
    except:
        print('\033[1;31mHouve um erro! Tente novamente!\033[m')
        print()
        sleep(1)
    else:
        if user == 1:
            # MAIOR PESO
            maior = 0
            for p in pessoas:
                if p == 0:
                    maior = p[2]
                else:
                    if p[2] > maior:
                        maior = p[2]
            print(f'Maior peso registrado: \033[1;33m{maior} KG\033[m')
            sleep(2)
            print()
        
        if user == 2:
            # MAIOR IDADE
            maior = 0
            for p in pessoas:
                if p == 0:
                    maior = p[1]
                else:
                    if p[1] > maior:
                        maior = p[1]
            print(f'Maior idade registrada: \033[1;33m{maior} Anos\033[m')
            sleep(2)
            print()

        if user == 3:
            # SAIR
            load = ['.','.','.']
            print('\033[1;33mLOADING\033[m',end ='')
            for p in load:
                sleep(0.5)
                print(f'\033[1;33m{p}\033[m',end='')
                sleep(0.5)
            print()
            print('\033[1;33mPROGRAMA FINALIZADO\033[m')
            break

        


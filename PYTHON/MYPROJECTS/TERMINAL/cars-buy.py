'''Compra de carros com uso de classes'''

import colorama ; colorama.init()
from time import sleep

class carro:
    def __init__(self,marca,velocidade,cor,val):
        self.marca = marca
        self.velocidade = velocidade
        self.cor = cor                                
        self.val = val
print()
print('\033[1;33mCONCESSIONÁRIA PYTHON\033[m'.center(40))
sleep(1)
print()
car1 = carro('Chevrolet','180 KM','\033[1;34mAzul\033[m','75.000.00') ; car6 = carro('Audi','200 KM','\033[1;97mBranco\033[m','83.000.00')
car2 = carro('Ferrari','360 KM','\033[1;33mAmarelo\033[m','170.000.00') ; car7 = carro('Ford','160 KM','\033[1;35mRoxo\033[m','55.000.00')
car3 = carro('Toyota','195 KM','\033[1;31mVermelho\033[m','65.000.00') ; car8 = carro('Hyundai','175 KM','\033[1;36mCiano\033[m','50.000.00')
car4 = carro('Renault','210 KM','\033[1;32mVerde\033[m','80.000.00') ; car9 = carro('Bmw','275 KM','\033[1;97mBranco\033[m','225.000.00')
car5 = carro('Volkswagen','195 KM','\033[1;90mCinza\033[m','60.000.00') ; car10 = carro('Fiat','160 KM','\033[1;34mAzul\033[m','45.000.00')
cars = ['CHEVROLET','FERRARI','TOYOTA','RENAULT','VOLKSWAGEN','AUDI','FORD','HYUNDAI','BMW','FIAT']

a = True

while a == True:
    print(f'{car1.marca:<20}{car1.velocidade:<15}{car1.cor:^10}')
    print(f'{car2.marca:<20}{car2.velocidade:<15}{car2.cor:^10}')
    print(f'{car3.marca:<20}{car3.velocidade:<15}{car3.cor:<10}')
    print(f'{car4.marca:<20}{car4.velocidade:<15}{car4.cor:<10}')
    print(f'{car5.marca:<20}{car5.velocidade:<15}{car5.cor:<10}')
    print(f'{car6.marca:<20}{car6.velocidade:<15}{car6.cor:<10}')
    print(f'{car7.marca:<20}{car7.velocidade:<15}{car7.cor:<10}')
    print(f'{car8.marca:<20}{car8.velocidade:<15}{car8.cor:<10}')
    print(f'{car9.marca:<20}{car9.velocidade:<15}{car9.cor:<10}')
    print(f'{car10.marca:<20}{car10.velocidade:<15}{car10.cor:<10}')
    print()
    user = str(input('Escolha uma marca\nou digite sair: ')).upper()
    if user == 'SAIR':
        p = ['.','.','.']
        print('Aguarde',end ='')
        for po in p:
            print(po,end ='')
            sleep(1)
        print()
        sleep(1)
        break
    print()
    if user not in cars:
        print('\033[1;31mEstá marca não está em nosso catalogo! Tente novamente!\033[m')
    sleep(2)
    print()
    if user in cars:
        print(f'Você escolheu \033[1;4;31m{user}\033[m')
        print('Valor do veiculo: ',end = 'R$ \033[1;32m')
        if user == cars[0]:
            print(f'{car1.val}')
        if user == cars[1]:
            print(f'{car2.val}')
        if user == cars[2]:
            print(f'{car3.val}')
        if user == cars[3]:
            print(f'{car4.val}')
        if user == cars[4]:
            print(f'{car5.val}')
        if user == cars[5]:
            print(f'{car6.val}')
        if user == cars[6]:
            print(f'{car7.val}')
        if user == cars[7]:
            print(f'{car8.val}')
        if user == cars[8]:
            print(f'{car9.val}')
        if user == cars[9]:
            print(f'{car10.val}')
        print('\033[m')
        while True:
            user = str(input('Prosseguir?[S/N]: ')).strip()[0]
            print()
            if user not in 'SsNn':
                print('\033[1;31mDigito inválido! Tente novamente!\033[m')
            print()
            if user in 'Nn':
                sleep(1)
                break
            if user in 'Ss':
                p = ['.','.','.']
                print('Aguarde',end = '')
                for po in p:
                    print(po,end = '')
                    sleep(1)
                sleep(2)
                print()
                print()
                print('\033[1;34mCOMPRA EFETUADA COM SUCESSO\033[m')
                sleep(2)
                print()
                break
p = ['V','O','L','T','E', '  ','S','E','M','P','R','E']
print()
for po in p:
    print(f'\033[1;33m{po}\033[m',end ='')
    sleep(00.25)
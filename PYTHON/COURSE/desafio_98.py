'''Faça um programa que tenha uma função chamada contador(), que receba três
    parâmetros: início,fim e passo e realize a contagem. Seu programa tem que
    realizar três contagens através da função criada.'''

# De 1 até 10, de 1 em 1
# de 10 até 0, de 2 em 2
# Uma contagem personalizada

import time
while True:
    def contador(i,f,p):
        if p < 0:
            p *= -1                                        
        if p == 0:
            p = 1
        print('-' * 40)
        print(f'CONTAGEM DE {i} ATÉ {f} DE {p} EM {p}')              # Nomeando a contagem do usuário        
        print('-' * 40)

        if i < f:
            cont = i
            while cont <= f:
                print(cont,end = ' ',flush= True)           
                time.sleep(00.25)                               # Montando a contagem padrão e a do usuário
                cont += p
            print(' - FIM')
            print()
                                                                    
        if i > f:
            cont = i
            while cont >= f:
                print(cont,end = ' ',flush= True)
                time.sleep(00.25)
                cont -= p
            print(' - FIM')
            print()
    
    contador(1,10,1)
    contador(10,0,2)
    print('-' * 40)
    print('CONTAGEM PERSONALIZADA')
    print('-' * 40)
    ini = int(input('INICIO: '))
    fim = int(input('FIM: '))
    pas = int(input('PASSO: '))                                 # Estrutura para o usuário introduzir sua contagem
    contador(ini,fim,pas)
    cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    while cont not in 'SsNn':
        print('Digito inválido! Tente novamente!')
        cont = str(input('Deseja continuar?[S/N]: ')).strip()[0]
    if cont in 'Nn':
        break
print('-' * 40)
print('Programa Encerrado')
        




        

    
    


        






        
        

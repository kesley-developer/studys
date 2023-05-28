'''Crie um programa que tenha uma função fatorial() que receba dois parâmetros: o número a
    calcular e o outro chamado show, que será um valor lógico(opcional) indicando se será
    mostrado ou não na tela o processo de cálculo do fatorial'''

from math import factorial

def fatorial(num=0,show=0):
                                                # Criando instruções para minha função
    ''' CALCULANDO O FATORIAL DE UM NÚMERO
    
    parâmetro num: O número a ser escolhido, no caso o número foi 5
    parâmetro show: parâmetro opcional que mostrara o processo da conta do fatorial
    
    '''
    print(f'--- Fatorial do número {num} ---')
    if show == True:                                # Organizando o parâmetro show caso True(Verdadeiro)
        for c in range(num,0,-1):               
            print(f'{c}',end = ' ')
            if c != 1:
                print(' X ',end = ' ')
            else:
                print('= ',end = f'{factorial(num)}')  
    if show == False:                               # Organizando o parâmetro show caso False(Falso)
        print(f'{factorial(num)}')
fatorial(num = 5,show = True)                    # Parâmetros escolhidos
help(fatorial)           # Sobre minha função
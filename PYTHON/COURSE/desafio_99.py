'''Faça um programa que tenha uma função chamada maior(), que receba vários parâmetros com
    valores inteiros. Seu programa tem que analisar todos os valores e dizer qual deles é o maior'''

import time

def maior(*nums):                           # Desempacontando os valores informados
    print('-' * 40)
    print(f'Valores informados: {nums}')    
    print('-' * 40)
    print(f'Foram informados {len(nums)} valores')              
    print(f'O maior valor foi o número {max(nums)}')
    time.sleep(2)
    print()


maior(1,6,7,2,3,10)
maior(3,5,7,11,14)
maior(8,9,11)
maior(0)


    





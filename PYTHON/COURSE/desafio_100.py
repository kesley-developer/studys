'''Faça um programa que tenha uma lista chamada números e duas funções chamadas sorteia()
    e somaPar(). A primeira função vai sortear 5 números e vai colocá - los dentro da lista
    e a segunda função vai mostrar a soma entre todos os valores PARES sorteados pela função anterior'''

from random import randint

nums = []

def sorteia():
    for c in range(5):                      # Inserindo valores aleatórios na lista pela função
        nums.append(randint(1,20))
    print('Números sorteados: ',end = '')
    print(nums)
sorteia()

def somapar():                          
    par = 0                                     # Montando a soma dos valores pares na função
    for p in nums:
       if p % 2 == 0:
           par += p 
    print(f'A soma dos valores pares é igual a {par}')
somapar()
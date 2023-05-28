'''Faça um programa que ajude um jogador da MEGA SENA a criar palpites. O programa vai
    perguntar quantos jogos serão gerados e vai sortear 6 números entre 1 e 60 para
    cada jogo, cadastrando tudo em uma lista composta'''

import time
import random
numero = 0
nums = []
print('-' * 40)
print('PALPITES PARA A MEGA - SENA')
print('-' * 40)
while True:
    nums.clear()
    palp = int(input('Quantos palpites deseja gerar?: '))
    for c in range(palp):
        for n in range(6):
                numero = random.randint(1,60)       # Montagem e verificação de numeros repetitivos na lista
                while numero in nums[:]:
                    numero = random.randint(1,60)
                nums.append(numero)
        print(f'{c + 1}º Jogo: {nums}')
        time.sleep(1)
        nums.clear()
    break
print('-' * 40)
print('Palpites gerados com sucesso')






    


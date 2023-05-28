import random
jog = int(input('Digite um número de 0 a 5: '))
cpu = random.randint(0,5)
print(f'Eu escolhi o número {cpu}')
if jog == cpu:
    print('Você acertou! Parábens!')
else:
    print('Você errou! Tente novamente!')

'''Crie um programa que crie uma matriz de dimensão 3x3 e preencha com
    valores lidos pelo teclado. No final mostre a matriz na tela, com 
    a formatação correta'''

nums = []
for posic in range(9):
    nums.append(int(input(f'{posic + 1}º Valor: ')))
print('MATRIZ')
for numero in range(0,len(nums)):
    if numero >= 0 and numero <= 2:
        print(f'[ {nums[numero]:^5} ]',end = '') # Alinhamento e montagem da matriz na lista
    if numero == 3:
        print()
    if numero >= 3 and numero <= 5:
        print(f'[ {nums[numero]:^5} ]',end = '')
    if numero == 6:
        print()
    if numero >= 6 and numero <= 8:
        print(f'[ {nums[numero]:^5} ]',end = '')

# 2º método

'''matriz = [[0,0,0],[0,0,0],[0,0,0]]
for l in range(0,3):
    for c in range(0,3):
        matriz[l][c] = int(input(f'Digite um valor para [{l},{c}]: '))
print('-' * 40)
for l in range(0,3):
    for c in range(0,3):
        print(f'[{matriz[l][c]:^5}]', end = '')
    print()'''
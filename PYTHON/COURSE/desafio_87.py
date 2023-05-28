'''Aprimore o desafio anterior(086), mostrando no final a soma de todos os valores pares digitados, a soma
   dos valores da terceira coluna e o maior valor da segunda linha'''

'''pares = maior = 0
nums = []
for posic in range(9):
    valor = int(input(f'Digite o {posic + 1}º valor: '))
    if valor % 2 == 0:
        pares += valor
    nums.append([valor])
print('-' * 40)
print(f'A Soma dos pares digitados é igual a {pares}')
for p in range(0,len(nums)):
    if p >= 0 and p <= 2:
        print(f'{nums[p]}',end = ' ')        
    if p == 3:
        print()                                 
    if p >= 3 and p <= 5:                     # Organizando a soma e montagem da matriz
        if p == 3:
            maior = nums[p][0]
        else:
            if nums[p][0] > maior:            # Analisando o maior valor da segunda linha
                maior = nums[p][0]
        print(f'{nums[p]}',end = ' ')
    if p == 6:
        print()
    if p >= 6 and p <= 8:
        print(f'{nums[p]}',end = ' ')
soma = nums[2][0] + nums[5][0] + nums[8][0] 
print(f'\nA Soma da terceira coluna da matriz é igual a {soma}')
print(f'O Maior valor da segunda linha é o número {maior}')'''

# 2º Método

somacol = somapar = maior = 0
matriz = [[0,0,0],[0,0,0],[0,0,0]]
for l in range(0,3):
    for c in range(0,3):
        matriz[l][c] = int(input(f'Digite um valor para [{l},{c}]: '))
print('-' * 40)
for l in range(0,3):
    for c in range(0,3):
        print(f'[{matriz[l][c]:^5}]', end = '')
        if matriz[l][c] % 2 == 0:
            somapar += matriz[l][c]
    print()
print(f'A soma dos pares digitados é igual a {somapar}')
for l in range(0,3):
    somacol += matriz[l][2]
print(f'A soma dos valores da terceira coluna é igual a {somacol}')
for c in range(0,3):
    if c == 0:
        maior = matriz[1][c]
    if matriz[1][c] > maior:
        maior = matriz[1][c]
print(f'O maior valor na segunda linha é o número {maior}')

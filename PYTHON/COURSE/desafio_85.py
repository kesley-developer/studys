'''Crie um programa onde o usuário possa digitar sete valores numéricos e
    cadastre - os em uma lista única que mantenha separados os valores pares
    e ímpares. No final, mostre os valores pares e ímpares em ordem crescente'''

nums = [[],[]]
for posic in range(7):
    valor = int(input(f'{posic + 1}º Valor: '))     
    if valor % 2 == 0:                              # Separando os pares e impares
        nums[0].append(valor)
    if valor % 2 != 0:
        nums[1].append(valor)
nums.sort(reverse = True)
print(f'Valores pares digitados: {nums[0]}')
print(f'Valores impares digitados: {nums[1]}')




    
        

'''Crie um programa onde o usuário possa digitar cinco valores numéricos
    e cadastre - os em uma lista, já na posição correta de inserção(sem usar o sort()).
    No final, mostre a lista ordenada na tela'''

print('CADASTRO NÚMERICO')
numeros = []
for p in range(0,5):
    num = int(input(f'Digite o {p + 1}º numero: '))
    if p == 0 or num > numeros[-1]:
        numeros.append(num)
        print(f'O Número {num} foi adicionado ao final da lista')
    else:
        pos = 0
        while pos < len(numeros):           # Método para verificar as posições dos numeros
            if num <= numeros[pos]:
                numeros.insert(pos,num)
                print(f'O Numero {num} foi adicionado na posição {pos} da lista')
                break
            pos += 1
print('-' * 40)
print(f'Valores digitados em ordem: {numeros}')

        
    
    
    
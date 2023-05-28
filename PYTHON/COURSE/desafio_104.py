'''Crie um programa que tenha a função leiaInt(),que vai funcionar de forma semelhante á função input() do python,
    só que fazendo a validação para aceitar apenas um valor numérico'''

def leiaint(num):
    while True:
        global n        # Transformando o n em uma variável global
        n = input(num).strip()
        if n.isnumeric() == False:                       # Enquanto o valor digitado não for numérico
            print('Digito inválido! Digite um valor númerico!')
        else:                                              # Caso seja númerico
            break
num = leiaint('Digite um número: ')
print(f'Você digitou o número {n}')



    
    
    

    







'''Reescreva a função leiaint() que fizemos no desafio 104, incluindo agora a possibilidade da 
    digitação de um número de tipo inválido. Aproveite e crie também uma função leiafloat() com a 
    mesma possibilidade'''



def leiaint():
    import colorama
    colorama.init()
    
    while True:
        try:
            num = int(input('Digite um número inteiro: '))              
            print('-' * 40)                                       # Montando situação de erro e validação do número inteiro
        except (ValueError, TypeError):
            print('\033[1;31mErro! Digite um número inteiro!\033[m')
        else:
            print(f'Você digitou o número {num}')
            print('-' * 40)
            break
leiaint()

def leiafloat():
    while True:
        try:
            num = float(input('Digite um número real: '))           
            print('-' * 40)
        except (ValueError, TypeError):                                     # Montando situação de erro e validação do número real
            print('\033[1;31mErro! Digite um número real!\033[m')
        else:
            print(f'Você digitou o número {num}')
            print('-' * 40)
            break
leiafloat()

    
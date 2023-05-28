'''Dentro do pacote utilidadesCeV que criamos no desafio 111, temos um módulo chamado dado. Crie
    uma função chamada leiaDinheiro() que seja capaz de funcionar como a função input(), mas com
    uma validação de dados para aceitar apenas valores que sejam monetários'''

import colorama
colorama.init()

def leiadinheiro(msg):
    valid = False
    while valid == False:
        entra = str(input(msg)).strip().replace(',','.')
        if entra.isalpha() or entra == '':
            print(f'\033[1;31m"{entra}" é um preço inválido! Tente novamente!\033[m')
        else:
            valid = True
            return float(entra)
    
    
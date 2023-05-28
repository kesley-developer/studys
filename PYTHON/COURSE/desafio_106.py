'''Faça um mini - sistema que utilize o interactive Help do Python. O usuário vai digitar o
    comando e o manual vai aparecer. Quando o usuário digitar a palavra 'FIM', o programa se
    encerrará'''

import time
import colorama
colorama.init()

print()
def sistema():    
    while True:
        print(f'\033[1;43;31m{"SISTEMA DE AJUDA INTERATIVO PYHELP":^50}\033[m')
        user = str(input('Função ou biblioteca( Digite fim para encerrar ): ')).lower()
        if user == 'fim':
            print('\033[1;44;31m☺ Programa Encerrado ☺\033[m')
            break
        print(f'\033[1;41mAcessando o manual do comando --- {user}\033[m')
        time.sleep(1)
        print('\033[1;107;31m')
        help(user)    

sistema()
    
    

def leiaint(msg):
    import time
    import colorama
    colorama.init()
    
    while True:
        try:
            num = int(input(msg))              
            print('-' * 40)                                                                                                      
        except:
            print('\033[1;31mErro! Digite um valor númerico!\033[m')
            time.sleep(2)
        else:
            return num
            

def linha(tam = 42):
    return '-' * tam

def cabecalho(txt):
    print(linha())
    print(txt.center(42))
    print(linha())

def menu(lista):
    import colorama ; colorama.init()
    cabecalho('\033[1;33mMENU PRINCIPAL\033[m')
    c = 1
    for p in lista:
        print(f'\033[1m{c}\033[m - \033[1;34m{p}\033[m')
        c += 1
    print(linha())
    opc = leiaint('Sua opção: ')
    return opc
'''ABRIR URL DIGITADA PELO USUARIO'''

from time import sleep
import webbrowser
import colorama ; colorama.init()


def options():
    opc = ('[1] Abrir uma janela','[2] Abrir duas janelas','[3] Abrir três janelas','[4] Encerrar')
    print('\033[1;33mOPÇÕES\033[m'.center(30))
    for p in opc:
        print(f'{p}')



def main(url1=0,url2=0,url3=0):
    while True:
        print('\033[1;34m>>>>>> OPEN URL <<<<<<\033[m'.center(80))
        print()
        options()
        try:
            print()
            user = int(input('Escolha uma opção: '))
        except:
            print()
            print('\033[1;31mSeu digito é invalido! Tente novamente!\033[m')
            sleep(1)
            print()
        else:
            if user < 1 or user > 4:
                print()
                print('\033[1;31mSua opção é inválida! Tente novamente!\033[m')
                print()
                sleep(1)
            else:
                print()
                if user == 1:
                    user0 = str(input('Digite a URL: '))
                    print(f'Abrindo --- \033[1;33m{user0}\033[m')
                    webbrowser.open(user0)
                
                if user == 2:
                    user0 = str(input('Digite a primeira URl: '))
                    user1 = str(input('Digite a segunda URL: '))
                    print(f'Abrindo --- \033[1;33m{user0}\033[m')
                    print(f'Abrindo --- \033[1;33m{user1}\033[m')
                    webbrowser.open(user0)
                    webbrowser.open(user1)

                if user == 3:
                    user0 = str(input('Digite a primeira URL: '))
                    user1 = str(input('Digite a segunda URL: '))
                    user2 = str(input('Digite a terceira URL: '))
                    print(f'Abrindo --- \033[1;33m{user0}\033[m')
                    print(f'Abrindo --- \033[1;33m{user1}\033[m')
                    print(f'Abrindo --- \033[1;33m{user2}\033[m')
                    webbrowser.open(user0)
                    webbrowser.open(user1)
                    webbrowser.open(user2)
                sleep(3)
                
                if user == 4:
                    print('\033[1;31mPROGRAMA FINALIZADO\033[m'.center(30))
                    break
                


                                            
main()
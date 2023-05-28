from desafio115.lib.interface import *

def arquivoexiste(nome):
    try:
        a = open(nome,'rt')
        a.close()
    except FileNotFoundError:
        return False
    else:
        return True

def criararquivo(nome):
    try:
        a = open(nome,'wt+')
        a.close()
    except:
        print('\033[1;31mHouve um erro na criação do arquivo!\033[m')
    else:
        print(f'Arquivo {nome} criado com sucesso!')

def lerarquivo(nome):
    try:
        a = open(nome,'rt')
    except:
        print('\033[1;31mErro ao ler o arquivo!\033[m')
    else:
        cabecalho('PESSOAS CADASTRADAS')
        for line in a:
            dado = line.split(';')
            dado[1] = dado[1].replace('\n',' ')
            print(f'{dado[0]:<30}{dado[1]:>3} anos')
    finally:
        a.close()

def cadastrar(arq,nome = 'Desconhecido',idade=0):
    try:
        a = open(arq,'at+')
    except:
        print('\033[1;31mHouve um erro na abertura do arquivo!\033[m')
    else:
        try:
            a.write(f'{nome};{idade}\n')
        except:
            print('\033[1;31mHouve um erro na digitação dos dados!\033[m')
        else:
            print(f'\033[1;34mRegistro de {nome} efetuado com sucesso!\033[m')
            a.close()





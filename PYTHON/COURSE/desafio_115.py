'''Crie um pequeno sistema modularizado que permita cadastrar pessoas pelo seu
    nome e idade em um arquivo de texto simples. O programa só vai ter 2 opções:
    cadastrar uma nova pessoa e listar todas as pessoas cadastradas'''

import colorama ; colorama.init()
import time
from desafio115.lib.arquivo import *
from desafio115.lib.interface import *

arq = 'arquivo115.txt'

if not arquivoexiste(arq):
    criararquivo(arq)
time.sleep(2)

while True:
    user = menu(['Pessoas cadastradas','Cadastrar nova pessoa','Sair'])
    if user == 1:
        lerarquivo(arq)                                             # Opção de listar o conteudo de um arquivo
    if user == 2:
        cabecalho('CADASTRAR'.center(40))               # Opção para cadastrar novas pessoas
        nome = str(input('Nome: ')).capitalize()
        idade = leiaint('Idade: ')
        cadastrar(arq,nome,idade)
    if user == 3:
        print('SAIR'.center(40))                                    # Opção para encerrar o programa
        time.sleep(1)
        print('\033[1;31mPROGRAMA ENCERRADO\033[m'.center(48))
        break
    if user != 1 and user != 2 and user != 3:
        print('\033[1;31mErro! Esta opção é inexistente! Tente novamente!\033[m')       # Caso o digito seja inválido
    time.sleep(2)

        

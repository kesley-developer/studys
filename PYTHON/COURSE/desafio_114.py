'''Crie um código em Python que teste se o site Pudim esta acessivel
    pelo computador usado'''


import colorama
colorama.init()

from urllib import request               # Biblioteca para acessar o site

try:
    site = request.urlopen('http://www.pudim.com.br')          # Comandos para acessar o site
except:
    print('\033[1;31mERRO: O site não está acessivel no momento!\033[m')
else:
    print('\033[1;34mO Site foi acessado com sucesso!\033[m')
    print(site.read())                          # Códigos que estão no site





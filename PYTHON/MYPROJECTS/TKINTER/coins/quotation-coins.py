'''COTAÇÃO ATUAL DAS MOEDAS'''

from cProfile import label
from tkinter.tix import COLUMN, TEXT
import requests
from tkinter import *

from setuptools import Command


def pegar_cotacoes():
    requisicao = requests.get("https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL")

    requisicao_dic = requisicao.json()

    cotacao_dolar = requisicao_dic['USDBRL']['bid']
    cotacao_euro = requisicao_dic['EURBRL']['bid']
    cotacao_btc = requisicao_dic['BTCBRL']['bid']

    texto = f'''
    Dólar: {cotacao_dolar}
    Euro: {cotacao_euro}
    BTC: {cotacao_btc}'''

    texto_cotacao['text'] = texto  # Editando os parametro TEXT da variavel criada TEXTO_COTACAO
    atualiz['text'] = 'Clique novamente para atualizar'

janela = Tk()                                                                        # Criando janela
janela.title('MONEY V1.0')                                             # Titulo da janela
janela.geometry('300x300')                                                           # Tamanho da janela
janela.resizable(width=False, height=False) 

texto = Label(janela,text='Clique no botão para exibir as cotações das moedas',font=('arial black',7))      # Adicionando texto dentro da janela
texto.grid(column=0,row=0,padx=10,pady=10)                                           # Posicionando TEXTO com base na COLUNA e LINHA
                            
                            # PADX = Distância do eixo HORIZONTAL    |
                            # PADY = Distância do eixo VERTICAL      __

botao = Button(janela,text='Buscar cotações Dólar/Euro/BTC',command=pegar_cotacoes) # Adicionando o BOTÃO e a sua FUNCÃO
botao.grid(column=0,row=1,padx=10,pady=10)                                           # Posicionando o BOTAO com base na COLUNA E LINHA
atualiz = Label(janela,text='',font=('Arial',10))
atualiz.grid(column=0,row=2,padx=10,pady=10)

texto_cotacao = Label(janela,text= '')
texto_cotacao.grid(column=0,row=3,padx=10,pady=10)

Exiting = False
fim = Button(janela,text='Sair',command=janela.quit)                                 # BOTÃO para fechar janela
fim.grid(column=0,row=4,padx=10,pady=10)

by = Label(janela,text='Desenvolvido por KESLEY',bg='green',font=('Arial black',5))
by.grid(column=0,row=5,padx=10,pady=10)




janela.mainloop()


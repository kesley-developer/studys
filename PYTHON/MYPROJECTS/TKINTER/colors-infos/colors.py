'''A REPRESENTAÇÃO DAS CORES'''

from cgitb import text
from tkinter import *

# Funcionalidades dos BOTÕES
def a():
    botao_a['text'] = '''Amarelo é a cor que representa\nluz,calor,descontração,otimismo e alegria'''

def b():
    botao_b['text'] = '''Vermelho é a cor que representa\npaixão,energia e excitação'''

def c():
    botao_c['text'] = '''Azul é a cor que representa\ntranquilidade,serenidade e harmonia'''

def d():
    botao_d['text'] = '''Verde é a cor que representa\nesperança,liberdade,saúde e vitalidade'''

def e():
    botao_e['text'] = '''Preto é a cor que representa\nrespeito,morte,isolamento,medo e solidão'''

def f():
    botao_f['text'] = '''Roxo é a cor que representa\nespiritualidade,magia e mistério'''

def g():
    botao_g['text'] = '''Branco é a cor que representa\npaz,pureza e limpeza'''

def h():
    botao_h['text'] = '''Rosa é a cor que representa\nromantismo,ternura e ingenuidade'''

def i():
    botao_i['text'] = '''Laranja é a cor que representa\nalegria,vitalidade,prosperidade e sucesso'''

def j():
    botao_j['text'] = '''Cinza é a cor que representa\nneutralidade e estabilidade'''

def k():
    botao_k['text'] = '''Marrom é a cor que representa\nseriedade e integridade'''


janela = Tk()
janela.title('COLORS V1.0')
janela.geometry('720x480')

t = '''Escolha uma cor para ver sua representação'''
texto = Label(janela,text=t,background='white')
texto.grid(column=0,row=0)

botao_a = Button(text='            ',background='yellow',command=a)
botao_a.grid(column=1,row=1)
botao_a = Label(text='',font=('Arial black',8))
botao_a.grid(column=2,row=1)

botao_b = Button(text='            ',background='red',command=b)
botao_b.grid(column=1,row=2)
botao_b = Label(text='',font=('Arial black',8))
botao_b.grid(column=2,row=2)

botao_c = Button(text='            ',background='blue',command=c)
botao_c.grid(column=1,row=3)
botao_c = Label(text='',font=('Arial black',8))
botao_c.grid(column=2,row=3)

botao_d = Button(text='            ',background='green',command=d)
botao_d.grid(column=1,row=4)
botao_d = Label(text='',font=('Arial black',8))
botao_d.grid(column=2,row=4)

botao_e = Button(text='            ',background='black',command=e)
botao_e.grid(column=1,row=5)
botao_e = Label(text='',font=('Arial black',8))
botao_e.grid(column=2,row=5)

botao_f = Button(text='            ',background='purple',command=f)
botao_f.grid(column=1,row=6)
botao_f = Label(text='',font=('Arial black',8))
botao_f.grid(column=2,row=6)

botao_g = Button(text='            ',background='white',command=g)
botao_g.grid(column=1,row=7)
botao_g = Label(text='',font=('Arial black',8))
botao_g.grid(column=2,row=7)

botao_h = Button(text='            ',background='pink',command=h)
botao_h.grid(column=1,row=8)
botao_h = Label(text='',font=('Arial black',8))
botao_h.grid(column=2,row=8)

botao_i = Button(text='            ',background='orange',command=i)
botao_i.grid(column=1,row=9)
botao_i = Label(text='',font=('Arial black',8))
botao_i.grid(column=2,row=9)

botao_j = Button(text='            ',background='gray',command=j)
botao_j.grid(column=1,row=10)
botao_j = Label(text ='',font=('Arial black',8))
botao_j.grid(column=2,row=10)

botao_k = Button(text='            ',background='brown',command=k)
botao_k.grid(column=1,row=11)
botao_k = Label(text='',font=('Arial black',8))
botao_k.grid(column=2,row=11)

exit = Button(janela,text='  EXIT  ',command=janela.destroy)
exit.grid(column=0,row=1)

by = Label(janela,text='Desenvolvido por KESLEY',bg='green',font=('Arial black',5))
by.grid(column=0,row=2,padx=5,pady=5)


janela.mainloop()

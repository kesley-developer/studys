'''ABRIR LINKS DE SITES COM TKINTER'''

from tkinter import *
import webbrowser
import os

# Funções da categoria de MIDIA SOCIAL
def midia_a():
    url = webbrowser.open('www.youtube.com')    
    
def midia_b():
    url = webbrowser.open('www.instagram.com')

def midia_c():
    url = webbrowser.open('www.facebook.com')

def midia_d():
    url = webbrowser.open('www.linkedin.com')

def midia_e():
    url = webbrowser.open('www.tiktok.com')

# Funções da categoria de EMAIL
def email_a():
    url = webbrowser.open('www.gmail.com')

def email_b():
    url = webbrowser.open('www.outlook.com')

def email_c():
    url = webbrowser.open('www.yahoo.com')

# Funções da categoria de ENTRETENIMENTO
def entre_a():
    url = webbrowser.open('www.netflix.com')

def entre_b():
    url = webbrowser.open('www.spotify.com')

def entre_c():
    url = webbrowser.open('www.uol.com')

# Funcôes da categoria de OUTROS
def outros_a():
    url = webbrowser.open('www.google.com')

def outros_b():
    url = webbrowser.open('www.wikipedia.com')

janela = Tk()
janela.title('FAST ACESS V1.0')
janela.geometry('720x240')
janela.resizable(width=False, height=False) # Bloqueando o redimensionamento da janela

text = Label(janela,text='ACESSO RÁPIDO V1.0',background='white',font=('Arial black',13))
text.grid()
exit = Button(janela,text='CLIQUE AKI PARA SAIR',background='red',command=quit,font=('Arial black',9))
exit.grid(column=0,row=1,padx=5,pady=5)

# MIDIAS SOCIAIS

text = Label(janela,text='MIDIAS SOCIAIS',font=('Impact',11))
text.grid(column=0,row=2)

mid_a = Button(janela,text='Youtube',command=midia_a,font=('courier',12))
mid_a.grid(column=1,row=2,padx=5,pady=5)

mid_b = Button(janela,text='Instagram',command=midia_b,font=('courier',12))
mid_b.grid(column=2,row=2,padx=5,pady=5)

mid_c = Button(janela,text='Facebook',command=midia_c,font=('courier',12))
mid_c.grid(column=3,row=2,padx=5,pady=5)

mid_d = Button(janela,text='Linkedin',command=midia_d,font=('courier',12))
mid_d.grid(column=4,row=2,padx=5,pady=5)

mid_e = Button(janela,text='Tiktok',command=midia_e,font=('courier',12))
mid_e.grid(column=5,row=2,padx=5,pady=5)

# EMAIL

text = Label(janela,text='EMAIL',font=('Impact',11))
text.grid(column=0,row=3,padx=5,pady=5)

ema_a = Button(janela,text='Gmail',command=email_a,font=('courier',12))
ema_a.grid(column=1,row=3,padx=5,pady=5)

ema_b = Button(janela,text='Outlook',command=email_b,font=('courier',12))
ema_b.grid(column=2,row=3,padx=5,pady=5)

ema_c = Button(janela,text='Yahoo',command=email_c,font=('courier',12))
ema_c.grid(column=3,row=3,padx=5,pady=5)

# ENTRETENIMENTO

text = Label(janela,text='ENTRETENIMENTO',font=('Impact',11))
text.grid(column=0,row=4,padx=5,pady=5)

ent_a = Button(janela,text='Netflix',command=entre_a,font=('courier',12))
ent_a.grid(column=1,row=4,padx=5,pady=5)

ent_b = Button(janela,text='Spotify',command=entre_b,font=('courier',12))
ent_b.grid(column=2,row=4,padx=5,pady=5)

ent_c = Button(janela,text='Uol',command=entre_c,font=('courier',12))
ent_c.grid(column=3,row=4,padx=5,pady=5)

# OUTROS

text = Label(janela,text='OUTROS',font=('Impact',11))
text.grid(column=0,row=5,padx=5,pady=5)

out_a = Button(janela,text='Google',command=outros_a,font=('courier',12))
out_a.grid(column=1,row=5,padx=5,pady=5)

out_b = Button(janela,text='Wikipedia',command=outros_b,font=('courier',12))
out_b.grid(column=2,row=5,padx=5,pady=5)

by = Label(janela,text='Desenvolvido por KESLEY',bg='green',font=('Arial black',5))
by.grid(column=4,row=5,padx=5,pady=5)

janela.mainloop()
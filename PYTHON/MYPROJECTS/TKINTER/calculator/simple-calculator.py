'''CALCULADORA COM INTERFACE GRÁFICA'''

from tkinter import *
from Archives import *

# Configurando JANELA
window = Tk()
window.title('K CALCULATOR V1.0')
window.geometry('300x300+500+200')  # Definindo tamanho da janela e sua posição
window.configure(bg='blue',cursor='plus')
window.resizable(width=False,height=False)

# Funcionalidades para BOTÕES (Pegando o digito do usuário)
def Sum_Button():
    get_input0 = user_input0.get('1.0','end')
    get_input1 = user_input1.get('1.0','end')        
    
    # Tratamento de ERROS
    try:
        result = float(get_input0) + float(get_input1)
        Label(text=f'{result:.2f}{" ":>15}',font=('arial black',15),bg='white').place(x=110,y=30)
        Sound1()

    except:         
        Label(text=f'{"ERRO!":^5}{" ":>15}',font=('arial black',15),bg='white').place(x=110,y=30)
        Sound0()

    
def Mult_Button():
    get_input0 = user_input0.get('1.0','end')
    get_input1 = user_input1.get('1.0','end')
    
    try:
        result = float(get_input0) * float(get_input1)
        Label(text=f'{result:.2f}{" ":>15}',font=('arial black',15),bg='white').place(x=110,y=30)
        Sound1()    

    except:
        Label(text=f'{"ERRO!":^5}{" ":>15}',font=('arial black',15),bg='white').place(x=110,y=30)
        Sound0()


def Div_Button():
    get_input0 = user_input0.get('1.0','end')
    get_input1 = user_input1.get('1.0','end')
    
    try:
        result = float(get_input0) / float(get_input1)
        Label(text=f'{result:.2f}{" ":>15}',font=('arial black',15),bg='white').place(x=110,y=30)
        Sound1()

    except:
        Label(text=f'{"ERRO!":^5}{" ":>15}',font=('arial black',15),bg='white').place(x=110,y=30)
        Sound0()


def Sub_Button():
    get_input0 = user_input0.get('1.0','end')
    get_input1 = user_input1.get('1.0','end')
    
    try:
        result = float(get_input0) - float(get_input1)
        Label(text=f'{result:.2f}{" ":>15}',font=('arial black',15),bg='white').place(x=110,y=30)
        Sound1()

    except:
        Label(text=f'{"ERRO!":^5}{" ":>15}',font=('arial black',15),bg='white').place(x=110,y=30)
        Sound0()


# Configurando TEXTO,BOTÕES ETC...
name = Label(window,text='K CALCULATOR ®',bg='blue',foreground='White',font=('Arial Black',10))
name.pack()

r_bg = '    '  * 50

result_background = Label(window,text=f'{r_bg}\n' * 3,bg='white')
result_background.pack()

# Digito do USUÁRIO 1
txt_0 = Label(window,text='NUM 1',foreground='blue',font=('arial black',8))
txt_0.pack()

user_input0 = Text(window,height=1,width=10,font=('arial black',8),cursor='plus')
user_input0.pack()

# Digito do USUÁRIO 2
txt_1 = Label(window,text='NUM 2',foreground='blue',font=('arial black',8))
txt_1.pack()

user_input1 = Text(window,height=1,width=10,font=('arial black',8),cursor='plus')
user_input1.pack()

# Somar
sum = Button(window,text='+',bg='blue',foreground='yellow',font=('arial black',12),command=Sum_Button).place(x=90,y=170)

# Multiplicação
mult = Button(window,text='x',bg='blue',foreground='yellow',font=('arial black',12),command=Mult_Button).place(x=120,y=170)

# Divisão
div = Button(window,text='÷',bg='blue',foreground='yellow',font=('arial black',12),command=Div_Button).place(x=150,y=170)

# Subtração
sub = Button(window,text='-',bg='blue',foreground='yellow',font=('arial black',12),command=Sub_Button).place(x=180,y=170)

by = Label(text='Desenvolvido por KESLEY',bg='yellow',font=('arial black',5)).place(x=95,y=250)

window.mainloop()



    








    
    








    


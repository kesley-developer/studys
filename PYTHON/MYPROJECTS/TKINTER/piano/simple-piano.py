'''PIANO COM INTERFACE GRÁFICA'''

from tkinter import *
from Archives import *

janela = Tk()
janela.title('SIMPLY PIANO V1.0')
janela.resizable(width=False,height=False)

t = '        \n\n\n\n\n\n\n        '

text = Label(janela,text='PYTHON PIANO V1.0\n\n',font=('Arial black',20))
text.grid(column=0,row=2)

by = Label(janela,text='Desenvolvido por KESLEY',bg='green',font=('Arial black',7))
by.grid(column=0,row=2)

tecla_a = Button(janela,text=t,bg='white',command=p0)
tecla_a.grid(column=3,row=2)

tecla_b = Button(janela,text=t,bg='black',command=p1)
tecla_b.grid(column=4,row=2)

tecla_c = Button(janela,text=t,bg='white',command=p2)
tecla_c.grid(column=5,row=2)

tecla_d = Button(janela,text=t,bg='black',command=p3)
tecla_d.grid(column=6,row=2)

tecla_e = Button(janela,text=t,bg='white',command=p4)
tecla_e.grid(column=7,row=2)

tecla_f = Button(janela,text=t,bg='black',command=p5)
tecla_f.grid(column=8,row=2)

tecla_g = Button(janela,text=t,bg='white',command=p6)
tecla_g.grid(column=9,row=2)

tecla_h = Button(janela,text=t,bg='black',command=p7)
tecla_h.grid(column=10,row=2)

tecla_i = Button(janela,text=t,bg='white',command=p8)
tecla_i.grid(column=11,row=2)

tecla_j = Button(janela,text=t,bg='black',command=p9)
tecla_j.grid(column=12,row=2)

tecla_k = Button(janela,text=t,bg='white',command=p10)
tecla_k.grid(column=13,row=2)

janela.mainloop()

'''MÓDULO PARA O PROGRAMA 5'''

from pygame import mixer
mixer.init()

# Efeitos sonoros
def Sound0():
    mixer.music.load('PYTHON/MYPROJECTS/TKINTER/calculator/sound/Voice0.mp3')
    mixer.music.play(1)


def Sound1():
    mixer.music.load('PYTHON/MYPROJECTS/TKINTER/Cinco/Voice1.mp3')
    mixer.music.play(1)
'''DESENHANDO UM ROSTO PIXEALIZADO COM PYGAME'''

import pygame
import colorama ; colorama.init()
from time import sleep

pygame.init()

# CARREGAMENTO
def loading():
    load = ['.','.','.']
    print('\n\033[1;36mLOADING\033[m',end='')
    for p in load:
        print(f'\033[1;31m{p}\033[m',end='')
        sleep(0.5)
    print()
loading()

display = pygame.display.set_mode([700,500])           
pygame.display.set_caption('FACE 1')                   
loop = True

while loop:  
    for event in pygame.event.get():            
        if event.type == pygame.QUIT:           
            load = ['.','.','.']
            print('\033[1;31mCLOSE\033[m',end='')
            for p in load:
                print(f'\033[1;36m{p}\033[m',end='')
                sleep(0.5)
            loop = False

    display.fill([191, 135, 71])                                       
    
    # Adicionando formas geométricas
                       
                       # X,Y,WIDHT,HEIGHT 
    form0 = pygame.Rect(100,100,100,100)                              
    pygame.draw.rect(display,[0,0,0,0],form0)                         
    
    form1 = pygame.Rect(100,100,50,50)
    pygame.draw.rect(display,[255,255,255,0],form1)

    form2 = pygame.Rect(500,100,100,100)
    pygame.draw.rect(display,[0,0,0,0],form2)
    
    form3 = pygame.Rect(500,100,50,50)
    pygame.draw.rect(display,[255,255,255,0],form3)

    form4 = pygame.Rect(240,380,200,80)         
    pygame.draw.rect(display,[255, 3, 3],form4)

    form5 = pygame.Rect(80,70,150,50)
    pygame.draw.rect(display,[0,0,0,0],form5)

    form6 = pygame.Rect(480,70,150,50)
    pygame.draw.rect(display,[0,0,0,0],form6)

    form7 = pygame.Rect(270,380,20,30) 
    pygame.draw.rect(display,[255,255,255,0],form7)

    form8 = pygame.Rect(390,380,20,30)
    pygame.draw.rect(display,[255,255,255,0],form8)

    form9 = pygame.Rect(365,290,5,5)
    pygame.draw.rect(display,[0,0,0,0],form9)

    form10 = pygame.Rect(345,290,5,5)
    pygame.draw.rect(display,[0,0,0,0],form10)

    form11 = pygame.Rect(120,270,50,50)
    pygame.draw.rect(display,[227,116,116],form11)

    form12 = pygame.Rect(520,270,50,50)
    pygame.draw.rect(display,[227,116,116],form12)
    
    pygame.display.update()                             



'''JOGO NEW SPACE PYTHON'''

import pygame 
from Archives import *
from time import sleep
import colorama ; colorama.init()
import random

# INSTRUÇÕES
def intro():
    print('\n\033[1;33mMANUAL\033[m\n'.center(40))
    keys = ['←','→']
    for p in keys:
        print(f'\033[1;33m{p}\033[m',end = ' ')
    print('- Movement(Movimentar)')
    print()
    load = ['.','.','.']
    print('\033[1;34mLOADING\033[m',end='')
    for p in load:
        print(f'\033[1;33m{p}\033[m',end='')
        sleep(1)
    print()
    print('\033[1;32mPLAY ►\033[m')
intro()    


# TRILHA SONORA
SoundTrack()

# PROGRAMA PRINCIPAL E FUNCIONALIDADES
display = pygame.display.set_mode([500,500])
pygame.display.set_caption('NEW SPACE PYTHON V1.0')
Program = True
Game_Over = False

Fps = pygame.time.Clock()
timer = 0

# SPRITES
ImageGroup = pygame.sprite.Group()
CpuObjectsGroup = pygame.sprite.Group()

fundo = Wallpaper(ImageGroup)
jogador = Player(ImageGroup)

met_0 = Cpu0(CpuObjectsGroup)
met_1 = Cpu1(CpuObjectsGroup)
met_2 = Cpu2(CpuObjectsGroup)
met_3 = Cpu3(CpuObjectsGroup)
rocket = Cpu4(CpuObjectsGroup)

# TEXTO NA TELA
pygame.font.init()
points = 0
font = pygame.font.Font('freesansbold.ttf',10)
text = font.render("POINTS " + str(points),True,(255, 255, 255))
textRect = text.get_rect()
textRect.center = (25,5)

while Program:
    Fps.tick(60)
    for event in pygame.event.get():
        
        if event.type == pygame.QUIT:
            Program = False

    if not Game_Over:        
        timer += 1
        if timer > 30:
            timer = 0

            # Atualizando pontuação
            if random.random() < 00.10:
                points += 1
                text = font.render("POINTS " + str(points),True,(255, 255, 255))

            if random.random() < 00.20:
                points += 2
                text = font.render("POINTS " + str(points),True,(255, 255, 255))

            if random.random() < 00.30:
                points += 3
                text = font.render("POINTS " + str(points),True,(255, 255, 255))

        Collision = pygame.sprite.spritecollide(jogador,CpuObjectsGroup,False,pygame.sprite.collide_mask)

        ImageGroup.update()
        ImageGroup.draw(display)
        CpuObjectsGroup.update()
        CpuObjectsGroup.draw(display)
        display.blit(text,textRect)
        
        # Fim de jogo
        if Collision:
            print('\033[1;31mGAME OVER\033[m')
            pygame.mixer.quit()
            Game_Over = True
        
        # Texto para fim de jogo
        if Game_Over:
            GameOver_Song()
            
            # Game over
            font = pygame.font.Font('freesansbold.ttf',20)
            text = font.render("G A M E O V E R",True,(255, 255, 255))
            textRect = text.get_rect()
            textRect.center = (250,180)
            display.blit(text,textRect)

            # Pontuação
            font = pygame.font.Font('freesansbold.ttf',15)
            textPoint = font.render(f"Points {points}",True,(255,255,255))
            textPoint_Rect = text.get_rect()
            textPoint_Rect.center = (290,245)
            display.blit(textPoint,textPoint_Rect)

        
    pygame.display.update()






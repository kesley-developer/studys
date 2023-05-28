'''JOGO CLOUD BALLOON '''

import pygame
import colorama ; colorama.init()
from time import sleep
from Archives import *
import random

# INSTRUÇÕES
def intro():
    print('\n\033[1;33mMANUAL\033[m\n')
    print('\033[1;32mSPACE\033[m',end='')
    print('- Fly(Voar)')
    print()
    load = ['.','.','.']
    print()
    print('\033[1;34mLOADING\033[m',end = '')
    for p in load:
        print(f'\033[1;33m{p}\033[m',end ='')
        sleep(1)
    print()
    print('\033[1;32mPLAY ►\033[m')
intro()

# TRILHA SONORA
def music():
    pygame.mixer.init()
    pygame.mixer.music.load('PYTHON/MYPROJECTS/PYGAME/cloud-balloon/sound/SoundTrack.mp3')
    pygame.mixer.music.play(-1)
music()

# PROGRAMA PRINCIPAL
display = pygame.display.set_mode([500,500])
pygame.display.set_caption('CLOUD BALLON V1.0')
Game = True
Over = False
Fps = pygame.time.Clock()
timer = 0

# SPRITES
ImageGroup = pygame.sprite.Group()
Cpu0ObjectGroup = pygame.sprite.Group()
Cpu1ObjectGroup = pygame.sprite.Group()
Cpu2ObjectGroup = pygame.sprite.Group()

fundo = Wallpaper(ImageGroup)
jog = Player(ImageGroup)

# ESCREVENDO NA TELA (Pontuação)
pygame.font.init()
pontos = 0
font = pygame.font.Font('freesansbold.ttf',20)
text = font.render("" + str(pontos),True,(191, 2, 185))
textRect = text.get_rect()
textRect.center = (450,20)

# TELA DE GAME OVER
Game_Over_Image = pygame.sprite.Group()
Background = pygame.sprite.Sprite(Game_Over_Image)
Background.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/cloud-balloon/images/GameOverImage.png')
Background.image = pygame.transform.scale(Background.image,[500,500])
Background.rect = pygame.Rect(0,0,0,0)

while Game:
    Fps.tick(60)
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            Game = False
    
    if not Over:
        ImageGroup.update()

        # Com 60 FPS a cada meio segundo essa ação será executada
        timer += 1
        if timer > 30:
            timer = 0
            
            # Nuvem
            if random.random() < 00.30: # 50% de chance de um novo obstaculo aparecer     
                NewCloud = Cpu0(ImageGroup,Cpu0ObjectGroup)
            
            # Nuvem inimiga
            if random.random() < 00.30:
                NewCloud_Enemy = Cpu1(ImageGroup,Cpu1ObjectGroup)
            
            # Objeto para pontos
            if random.random() < 00.40:
                NewPoint = Cpu2(ImageGroup,Cpu2ObjectGroup)
    
        # Verificar a colisão entre o PLAYER e OBJETOS        
        CloudCollision = pygame.sprite.spritecollide(jog,Cpu1ObjectGroup,False,pygame.sprite.collide_mask)     # False → Não eliminara o grupo 
                                                                                # ↑ Deixar a colisão justa 
        PointCollision = pygame.sprite.spritecollide(jog,Cpu2ObjectGroup,True,pygame.sprite.collide_mask)

        if CloudCollision:    
            print('\033[1;31mGAME OVER\033[m')
            Over = True
            
        # Atualizando pontuação
        if PointCollision:
            pontos += 1
            text = font.render("" + str(pontos),True,(191, 2, 185))

        ImageGroup.draw(display)    
        display.blit(text,textRect)
        
        # Fim de jogo
        if Over:
            pygame.mixer.quit()

            Game_Over_Image.draw(display)
            pygame.mixer.init()
            pygame.mixer.music.load('PYTHON/MYPROJECTS/PYGAME/cloud-balloon/sound/GameOverSong.mp3')
            pygame.mixer.music.play(1)
            textRect.center = (285,440)
            text = font.render("SUA PONTUAÇÃO: " + str(pontos),True,(255,255,255))
            display.blit(text,textRect)
            
        pygame.display.update()




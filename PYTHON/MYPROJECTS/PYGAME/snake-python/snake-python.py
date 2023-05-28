'''JOGO SNAKE PYTHON'''

import pygame ; pygame.init()
from time import sleep
import colorama ; colorama.init()
import random
from Archives import *

# Instruções
def intro():
    print('\n\033[1;33mMANUAL\033[m\n')
    keys = ['↑','←','↓','→']
    for p in keys:
        if p == '↑':
            print(f'\033[1;32m{p}\033[m'.center(15))
        else:
            print(f'\033[1;32m{p}\033[m',end=' ')
    print(' - Movement(Movimentação)')
    print()
    load = ['.','.','.']
    print('\033[1;34mLOADING\033[m',end='')
    for p in load:
        print(f'\033[1;33m{p}\033[m',end='')
        sleep(0.5)
    print()
    print('\033[1;32mPLAY ►\033[m')
intro()


# Display
display = pygame.display.set_mode([400,400])
pygame.display.set_caption('SNAKE PYTHON V1.0')

Game = True
Over = False

# Efeitos sonoros
def Song_Effect():
    pygame.mixer.music.load('PYTHON/MYPROJECTS/PYGAME/snake-python/sound/Effect.mp3')
    pygame.mixer.music.play(1)


def GameOver_Song():
    pygame.mixer.music.load('PYTHON/MYPROJECTS/PYGAME/snake-python/sound/GameOverSong.mp3')
    pygame.mixer.music.play(1)


# Colisão 1 (Player com ele mesmo) 
def collision(posicion1,posicion2):
    return posicion1 == posicion2


# Colisão 2 (Nas bordas)
def limit_display(pos):
    if 0 <= pos[0] < 400 and 0 <= pos[1] < 400:     # Se o PLAYER não estiver nos limites da tela 
        return False 
    else:
        return True 


# Função para o objeto aparecer aleatóriamente na tela (Maça)
def random_on_grid():
    x = random.randint(0,400)
    y = random.randint(0,400)
    return x // 10 * 10,y // 10 * 10


# Definindo player (COBRA)
Snake_Position = [(250,50),(260,50),(270,50)]
Snake_Surface = pygame.Surface([10,10])
Snake_Surface.fill((255,255,255))
Snake_Direction = pygame.K_LEFT

# Definindo o objeto (MAÇA)
Apple_Surface = pygame.Surface([10,10])
Apple_Surface.fill((255,255,255))
Apple_Position = random_on_grid()   

# Background e Sprites
MainGroup = pygame.sprite.Group()
Wallpaper = Background(MainGroup)

GameOver_Group = pygame.sprite.Group()

speed = 0

while Game:
    fps = 15 + speed
    pygame.time.Clock().tick(fps)        # FPS 
    for event in pygame.event.get():
        
        if event.type == pygame.QUIT:
            Game = False

        # Criando teclas digitadas
        elif event.type == pygame.KEYDOWN and not Over:
            if event.key in [pygame.K_UP,pygame.K_DOWN,pygame.K_LEFT,pygame.K_RIGHT]:
                Snake_Direction = event.key

    
    MainGroup.draw(display)
    
    if not Over:
        
        # Desenhando o OBJETO na tela
        display.blit(Apple_Surface,Apple_Position)
        
        # PLAYER colidindo com OBJETO
        if collision(Apple_Position,Snake_Position[0]):
            Snake_Position.append((-10,-10))                # Aumentar o tamanho do PLAYER
            Apple_Position = random_on_grid()             # Redefinindo posição do OBJETO
            speed += 1
            Song_Effect()

        # Desenhando o PLAYER na tela
        for p in Snake_Position:
            display.blit(Snake_Surface,p)

        # Movimentando todas as partes do PLAYER
        for c in range(len(Snake_Position) -1,0,-1):    
            
            # Caso aconteça a colisão
            if collision(Snake_Position[0],Snake_Position[c]):
                print('\033[1;31mGAME OVER\033[m')
                GameOver_Song()
                Over = True
            
            Snake_Position[c] = Snake_Position[c-1]

        # Caso o PLAYER colida com a borda da tela
        if limit_display(Snake_Position[0]):
            print('\033[1;31mGAME OVER\033[m')
            GameOver_Song()
            Over = True

        # Movimentação para CIMA
        if Snake_Direction == pygame.K_UP:
            Snake_Position[0] = (Snake_Position[0][0],Snake_Position[0][1] - 10)

        # Movimentação para BAIXO
        elif Snake_Direction == pygame.K_DOWN:
            Snake_Position[0] = (Snake_Position[0][0],Snake_Position[0][1] + 10)

        # Movimentação para ESQUERDA
        elif Snake_Direction == pygame.K_LEFT:
            Snake_Position[0] = (Snake_Position[0][0] - 10,Snake_Position[0][1])
        
        # Movimentação para DIREITA
        elif Snake_Direction == pygame.K_RIGHT:
            Snake_Position[0] = (Snake_Position[0][0] + 10,Snake_Position[0][1])

    # Game Over
    if Over:
        GameOver = GameOver_Image(GameOver_Group)
        GameOver_Group.draw(display)
        GameOver_Group.update()


    pygame.display.update()
    


    




    
    





    
    
    


    

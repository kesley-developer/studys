'''JOGO BREAKING SPACE'''

import pygame ; pygame.mixer.init()
from time import sleep
import colorama ; colorama.init()
from Archives import *

# INSTRUÇÕES
def intro():
    print('\n\033[1;33mMANUAL\033[m\n')
    keys = ['\033[1;32mW\033[m','\033[1;32mS\033[m','\033[1;32mJ\033[m']
    print(f'{keys[0]} - Movement UP(Movimentar para cima)')
    print(f'{keys[1]} - Movement DOWN(Movimentar para baixo)')
    print(f'{keys[2]} - Shot(Atirar)')     
    load = ['.','.','.']
    print()
    print('\033[1;34mLOADING\033[m',end='')
    for p in load:
        print(f'\033[1;33m{p}\033[m',end='')
        sleep(1)
    print()
    print('\033[1;32mPLAY ►\033[m')    
intro()

# DISPLAY
display = pygame.display.set_mode([500,500])
pygame.display.set_caption('BREAKING SPACE V1.0')

# VARIAVEIS A SEREM USADAS DURANTE A EXECUÇÃO
Game = True
Over = False
timer = 0
Fps = pygame.time.Clock()
AutomaticPoint = 0

# SPRITES
ImagesGroup = pygame.sprite.Group()
ShotGroup = pygame.sprite.Group()
EnemyGroup = pygame.sprite.Group()
AsteroidGroup = pygame.sprite.Group()

Fundo = Background(ImagesGroup)
Jogador = Player(ImagesGroup)

# TEXTO NA TELA (Pontuação)
pygame.font.init()
pontos = 0
font = pygame.font.Font('freesansbold.ttf',12)
text = font.render("Points " + str(pontos),True,(255,255,255))
textRect = text.get_rect()
textRect.center = (30,10)

while Game:
    Fps.tick(60)
    for event in pygame.event.get():
        
        if event.type == pygame.QUIT:
            Game = False
        
        elif event.type == pygame.KEYDOWN:
            
            if event.key ==  pygame.K_j and not Over:
                NewShot = Shot(ImagesGroup,ShotGroup)
                NewShot.rect.center = Jogador.rect.center         # Posicionando TIRO com o JOGADOR
                pygame.mixer.music.load('PYTHON/MYPROJECTS/PYGAME/break-space/sound/ShotSound.mp3')
                pygame.mixer.music.play(1)

    if not Over:               
        timer += 3

        if timer > 30:
            timer = 0

            if random.random() < 00.20:
                NewEnemy  = Cpu0(ImagesGroup,EnemyGroup)
            
            if random.random() < 01.00:
                NewAsteroid = Cpu1(ImagesGroup,AsteroidGroup)

        # Colisão com OBJETOS 
        Collision_Enemy = pygame.sprite.spritecollide(Jogador,EnemyGroup,False,pygame.sprite.collide_mask)
        Collision_Asteroid = pygame.sprite.spritecollide(Jogador,AsteroidGroup,False,pygame.sprite.collide_mask)

        if Collision_Enemy or Collision_Asteroid:
            print('\033[1;31mGAME OVER\033[m')
            Over = True

        # Colisão do TIRO com OBJETOS
        Shot_Enemy = pygame.sprite.groupcollide(ShotGroup,EnemyGroup,True,True,pygame.sprite.collide_mask)
        Shot_Asteroid = pygame.sprite.groupcollide(ShotGroup,AsteroidGroup,True,True,pygame.sprite.collide_mask)

        # Atualizando PONTUAÇÃO
        if Shot_Enemy or Shot_Asteroid:
            pontos += 2
            text = font.render("Points " + str(pontos),True,(255,255,255))
            pygame.mixer.music.load('PYTHON/MYPROJECTS/PYGAME/break-space/sound/CollisionSound.mp3')
            pygame.mixer.music.play(1)
        
        AutomaticPoint += 1
        if AutomaticPoint > 30:
            AutomaticPoint = 0
            pontos += 1
            text = font.render("Points " + str(pontos),True,(255,255,255))

        
        ImagesGroup.update()
        ImagesGroup.draw(display)
        display.blit(text,textRect)        

        # GAME OVER
        if Over:
            
            # Forma GEOMÉTRICA para GAME OVER
            form = pygame.Rect(150,150,200,200)
            pygame.draw.rect(display,[0,0,0],form)
            
            # Texto de PONTUAÇÃO
            font = pygame.font.Font('freesansbold.ttf',12)
            text_0 = font.render("Points " + str(pontos),True,(255,255,255))
            text0_Rect = text_0.get_rect()
            text0_Rect.center = (250,250)
            display.blit(text_0,text0_Rect)

            # Texto de GAME OVER
            font = pygame.font.Font('freesansbold.ttf',15)
            text_1 = font.render("GAME OVER",True,(255,255,255))
            text1_Rect = text_1.get_rect()
            text1_Rect.center = (250,230)
            display.blit(text_1,text1_Rect)
            pygame.mixer.music.load('PYTHON/MYPROJECTS/PYGAME/break-space/sound/GameoverSound.mp3')
            pygame.mixer.music.play(1)


        pygame.display.update()
        


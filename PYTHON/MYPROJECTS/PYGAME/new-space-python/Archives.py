'''MÓDULO PARA O PROGRAMA 4'''

import pygame
from time import sleep
import random

# Papel de parede do JOGO
class Wallpaper(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(*groups)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/new-space-python/images/Wallpaper.png')
        self.image = pygame.transform.scale(self.image,[500,500])
        self.rect = pygame.Rect(0,0,100,100)


# Funcionalidades do JOGADOR
class Player(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(*groups)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/new-space-python/images/Ship.png')
        self.image = pygame.transform.scale(self.image,[50,50])
        self.rect = pygame.Rect(250,450,50,50)
    
        # Velocidade e aceleração a ser incluida na movimentação        
        self.speed_x = 0
        self.acceleration_x = 0.1

    def update(self,*args):
        
        keys = pygame.key.get_pressed()

        if keys[pygame.K_LEFT]:     # ESQUERDA
                self.speed_x -= self.acceleration_x 
            
        if keys[pygame.K_RIGHT]:    # DIREITA
                self.speed_x += self.acceleration_x

        self.rect.x += self.speed_x

        # Limitando a movimentação nos eixos X e Y
       
        # X
        if self.rect.x < 0:
            self.rect.x = 0
            self.speed_x = 0
        
        if self.rect.x > 450:
            self.rect.x = 450
            self.speed_x = 0


# Funcionalidades do COMPUTADOR 1
class Cpu0(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(*groups)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/new-space-python/images/Meteor.png')
        self.image = pygame.transform.scale(self.image,[100,100])
        self.rect = pygame.Rect(250,0,100,100)
    
    def update(self,*args):     
        cpu0_movement = True
        
        if cpu0_movement:
            self.rect.y += 3
        
        if self.rect.y > 500:
            
            # Definindo uma posição X aleatória para o objeto
            position = []
            for c in range(0,450):
                position.append(c)
            
            self.rect.x = random.choice(position)
            self.rect.y = 0


# Funcionalidades do COMPUTADOR 2
class Cpu1(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(*groups)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/new-space-python/images/Meteor.png')
        self.image = pygame.transform.scale(self.image,[60,60])
        self.rect = pygame.Rect(350,0,100,100)
    
    def update(self,*args):
        cpu1_movement = True

        if cpu1_movement:
            self.rect.y += 4
        
        if self.rect.y == 500:
            position = []
            for c in range(0,450):
                position.append(c)
            
            self.rect.x = random.choice(position)
            self.rect.y = 0


# Funcionalidades do COMPUTADOR 3
class Cpu2(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(*groups)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/new-space-python/images/Meteor.png')
        self.image = pygame.transform.scale(self.image,[30,30])
        self.rect = pygame.Rect(150,0,100,100)
    
    def update(self,*args):
    
        cpu2_movement = True

        if cpu2_movement:
            self.rect.y += 5
        
        if self.rect.y > 500:
            position = []
            for c in range(0,450):
                position.append(c)
            
            self.rect.x = random.choice(position)
            self.rect.y = 0

# Funcionalidades do COMPUTADOR 4
class Cpu3(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(*groups)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/new-space-python/images/SuperMeteor.png')
        self.image = pygame.transform.scale(self.image,[125,125])
        self.rect = pygame.Rect(225,0,100,100)

    def update(self,*args):

        cpu3_movement = True

        if cpu3_movement:
            self.rect.y += 1

        if self.rect.y > 1000:
            position = []
            for c in  range(0,450):
                position.append(c)
            
            self.rect.x = random.choice(position)
            self.rect.y = 0


# Funcionalidades do COMPUTADOR 5
class Cpu4(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(*groups)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/new-space-python/images/Rocket.png')
        self.image = pygame.transform.scale(self.image,[64,64])
        self.rect = pygame.Rect(220,0,100,100)
    
    def update(self,*args):

        cpu4_movement = True

        if cpu4_movement:
            self.rect.y += 1
        
        if self.rect.y >= 100:
            self.rect.y += 2
        
        if self.rect.y >= 200:
            self.rect.y += 3
        
        if self.rect.y >= 400:
            self.rect.y += 4

        if self.rect.y > 10000:
            position = []
            for c in range(0,450):
                position.append(c)
            
            self.rect.y = 0
            self.rect.x = random.choice(position)


# Trilha sonora do JOGO
def SoundTrack():
    pygame.mixer.init()
    pygame.mixer.music.load('PYTHON/MYPROJECTS/PYGAME/new-space-python/sound/SoundTrack.mp3')
    pygame.mixer.music.play(-1)


# Som de GAME OVER
def GameOver_Song():
    pygame.mixer.init()
    pygame.mixer.music.load('PYTHON/MYPROJECTS/PYGAME/new-space-python/sound/OverSong.mp3')
    pygame.mixer.music.play(1)


'''MÓDULO PARA O PROGRAMA 1'''

import pygame
import random

# Papel de parede do JOGO
class Background(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(groups)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/break-space/images/Background.png')
        self.image = pygame.transform.scale(self.image,[500,500])
        self.rect = pygame.Rect(0,0,0,0)


# Funcionalidades do JOGADOR
class Player(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(*groups)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/break-space/images/Player.png')
        self.image = pygame.transform.scale(self.image,[40,40])
        self.rect = pygame.Rect(0,250,50,50)
    
    def update(self,*args):
        
        keys = pygame.key.get_pressed()

        if keys[pygame.K_w]:
            if self.rect.y > 10:
                self.rect.y -= 3 
        
        if keys[pygame.K_s]:
            if self.rect.y < 450:
                self.rect.y += 3


# Tiro do JOGADOR
class Shot(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(groups)    

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/break-space/images/Shot.png')
        self.image = pygame.transform.scale(self.image,[10,10])
        self.rect = pygame.Rect(0,250,25,25)

        self.speed = 6
    
    def update(self,*args):

        self.rect.x += self.speed

        if self.rect.left > 500:
            self.kill()
            

# Funcionalidades do COMPUTADOR 1
class Cpu0(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(groups)    

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/break-space/images/Enemy_0.png')
        self.image = pygame.transform.scale(self.image,[30,30])
        self.rect = pygame.Rect(0,0,0,0)

        self.rect.x = 500 + random.randint(1,400)
        self.rect.y = random.randint(1,480)

        self.speed = 1 + random.random() * 2

    def update(self,*args):

        self.rect.x -= self.speed

        if self.rect.right < 0:
            self.kill()


# Funcionalidades do COMPUTADOR 2
class Cpu1(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(groups)    

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/break-space/images/Asteroid.png')
        self.image = pygame.transform.scale(self.image,[20,20])
        self.rect = pygame.Rect(0,0,0,0)

        self.rect.x = 500 + random.randint(1,400)
        self.rect.y = random.randint(1,480)

        self.speed = random.randint(4,8) + random.random() * 2

    def update(self,*args):

        self.rect.x -= self.speed

        if self.rect.right < 0:
            self.kill()




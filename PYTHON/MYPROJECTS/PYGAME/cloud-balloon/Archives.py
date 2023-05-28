'''MÓDULO PARA O PROGRAMA 5'''

import pygame
import random

# Papel de parede do JOGO
class Wallpaper(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(*groups)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/cloud-balloon/images/Wallpaper.png')
        self.image = pygame.transform.scale(self.image,[500,500])
        self.rect = pygame.Rect(0,0,100,100)


# Funcionalidades do JOGADOR
class Player(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(*groups)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/cloud-balloon/images/Ballon.png')
        self.image = pygame.transform.scale(self.image,[80,80])
        self.rect = pygame.Rect(0,10,0,0)

        self.speed_y = 0
        self.acceleration_y = 0.1    
        

    def update(self,*args):

        keys = pygame.key.get_pressed()

        if keys[pygame.K_SPACE]:
            self.speed_y += self.acceleration_y
            self.speed_y *= 0.99
        else:
            self.speed_y -= self.acceleration_y
            self.speed_y *= 0.97

        self.rect.y -= self.speed_y

        # Limitando movimentação no eixos X e Y

        # Y
        if self.rect.y <= 0:
            self.rect.y = 0

        if self.rect.y >= 450:
            self.rect.y = 450

# Funcionalidades do COMPUTADOR 1
class Cpu0(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(*groups)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/cloud-balloon/images/Cloud.png')
        self.image = pygame.transform.scale(self.image,[120,120])
        self.rect = pygame.Rect(500,0,100,100)

        # Criando movimentações para o objeto e defindo posição aleatória
        self.rect.x = 500 + random.randint(1,400)
        self.rect.y = random.randint(1,480)
        
        # Velocidade aleatória
        self.speed = random.randint(2,5) + random.random() * 2
    
    def update(self,*args):
        
        self.rect.x -= self.speed

        # Quando o objeto sair da tela pelo lado esquerdo ←
        if self.rect.right < 0:
            self.kill()                                         # Eliminar objeto
            

# Funcionalidades do COMPUTADOR 2
class Cpu1(pygame.sprite.Sprite):
    def __init__(self,*group):
        super().__init__(*group)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/cloud-balloon/images/CloudEnemy.png')
        self.image = pygame.transform.scale(self.image,[120,120])
        self.rect = pygame.Rect(500,0,100,100)

        self.rect.x = 500 + random.randint(1,400)
        self.rect.y = random.randint(1,480)

        self.speed = random.randint(2,5) + random.random() * 2
    
    def update(self,*args):

        self.rect.x -= self.speed

        if self.rect.right < 0:
            self.kill()


# Funcionalidades do COMPUTADOR 3 (Ponto)
class Cpu2(pygame.sprite.Sprite):
    def __init__(self,*groups):
        super().__init__(*groups)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/cloud-balloon/images/Point.png')
        self.image = pygame.transform.scale(self.image,[50,50])
        self.rect = pygame.Rect(500,0,100,100)

        self.rect.x = 500 + random.randint(1,400)
        self.rect.y = random.randint(1,480)

        self.speed = random.randint(1,4) + random.random() * 2
    
    def update(self,*args):
        
        self.rect.x -= self.speed + 00.25

        if self.rect.right < 0:
            self.kill()
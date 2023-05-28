'''MÓDULO PARA O PROGRAMA 3'''

import pygame

# Background do GAME
class Background(pygame.sprite.Sprite):
    def __init__(self,*group):
        super().__init__(*group)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/snake-python/images/Background.png')
        self.image = pygame.transform.scale(self.image,[400,400])
        self.rect = pygame.Rect(0,0,0,0)


# Background de GAME OVER
class GameOver_Image(pygame.sprite.Sprite):
    def __init__(self,*group):
        super().__init__(*group)

        self.image = pygame.image.load('PYTHON/MYPROJECTS/PYGAME/snake-python/images/GameOver.png')
        self.image = pygame.transform.scale(self.image,[400,400])
        self.rect = pygame.Rect(0,0,0,0)
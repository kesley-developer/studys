'''Crie um programa onde 4 jogadores joguem um dado e tenham resultados aleatórios. Guarde
    esses resultados em um dicionário. No final, coloque esse dicionário em ordem, sabendo
    que o vencedor tirou o maior número no dado'''

import random
import time
import operator
jogadores = {'1º Jogador': random.randint(1,6),'2º Jogador': random.randint(1,6),
        '3º Jogador': random.randint(1,6),'4º Jogador': random.randint(1,6)}       # Sorteando jogadas
for key,val in jogadores.items():
    print(f'O {key:^10} tirou o número {val:-^5} do dado')
    print()
    time.sleep(1)
print()
ordem = {}
ordem = sorted(jogadores.items(),key = operator.itemgetter(1), reverse = True)  # Transformando o dicionario em lista e colocando em ordem
print('-' * 40)
print(f'{" CLASSIFICAÇÃO" :^10}')
print()                                 
c = 1
for posic in ordem:
    print(f'{c:^5}º Posição: {posic[0]:^5} --- {posic[1]:^5}')
    c += 1
    time.sleep(1)
print('-' * 40)
   
    
    


    
            
     
    

    
    
    
 






    
    
     
        







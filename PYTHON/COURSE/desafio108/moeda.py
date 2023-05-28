# Resolução para o desafio 108

def aumentar(preco = 0,taxa = 0):
    tot = preco + (preco * taxa/100)
    return tot


def diminuir(preco = 0,taxa = 0):
    tot = preco - (preco * taxa/100)
    return tot

def dobro(preco = 0):
    tot = preco * 2
    return tot

def metade(preco = 0):
    tot = preco / 2
    return tot

def moeda(preco = 0,moeda = 'R$'):
    return f'{moeda}{preco:.2f}'.replace('.',',')
    
    
    
    
    



    
    


    


    

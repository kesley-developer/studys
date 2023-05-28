# Resolução para o desafio 107

def aumentar(preco,taxa):
    global tot
    tot = preco + (preco * taxa/100)
    return tot


def diminuir(preco,taxa):
    tot = preco - (preco * taxa/100)
    return tot

def dobro(preco):
    tot = preco * 2
    return tot

def metade(preco):
    tot = preco / 2
    return tot
    
    
    
    



    
    


    


    

# Resolução para o desafio 109

def ajuda():
    '''      Manual
    
    parametro preco: calcula o valor
    parametro taxa: calcula a taxa de aumento ou desconto
    funcao moeda: formata as funcoes presentes
    parametro formatar: parametro opcional caso True formata as funcoes
    '''

def aumentar(preco = 0,taxa = 0,formatar = False):
    tot = preco + (preco * taxa/100)
    return tot if formatar is False else moeda(tot)


def diminuir(preco = 0,taxa = 0,formatar = False):
    tot = preco - (preco * taxa/100)
    return tot if formatar is False else moeda(tot)

def dobro(preco = 0,formatar = False):
    tot = preco * 2
    return tot if formatar is False else moeda(tot)

def metade(preco = 0,formatar = False):
    tot = preco / 2
    return tot if formatar is False else moeda(tot)

def moeda(preco = 0,moeda = 'R$'):
    return f'{moeda}{preco:.2f}'.replace('.',',')
    
    
    
    
    



    
    


    


    

# Resolução para o desafio 111

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

def resumo(preco = 0,aum = 15,dim = 10):
    print('-' * 40)
    print('RESUMO'.center(30))
    print('-' * 40)
    print(f'Preço digitado: R${preco:.2f}')
    print('-' * 40)
    print(f'Com {aum}% de aumento: \t{aumentar(preco,aum,True)}')
    print(f'Com {dim}% de desconto: \t{diminuir(preco,dim,True)}')
    print(f'Dobro: \t\t\t{dobro(preco,True)}')
    print(f'Metade: \t\t{metade(preco,True)}')
    print('-' * 40)
    return

    
    
    
    



    
    


    


    

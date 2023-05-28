'''Faça um programa que tenha uma função chamada escreva(), que receba um texto qualquer como
    parâmetro e mostre uma mensagem com tamanho adaptável (Tamanho das linhas de acordo com o texto digitado)'''

'''def escreva():
    text = str(input('Digite uma palavra a ser adaptada: '))
    print(f'-' * len(text))
    print(text)
    print(f'-' * len(text))
escreva()'''

# 2º MÉTODO
def escreva(msg):
    print('-' * len(msg))  
    print(msg)
    print('-' * len(msg))
escreva('HELLO WORLD! THIS IS EXERCISE RESOLUTION')
escreva('OLÁ MUNDO! ESSA É A MINHA RESOLUÇÃO DO EXERCICIO')
escreva('OBRIGADO')






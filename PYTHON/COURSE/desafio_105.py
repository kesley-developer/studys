'''Faça um programa que tenha uma função notas() que pode receber várias notas de alunos e vai
    retornar um dicionário com as seguintes informações: Quantidade de notas, a maior nota,
    a menor nota, a média da turma e a situação(opcional). Adicione também as docstrings da função'''


def notas(*n,sit = 0):
   
    '''
        FUNÇÃO PARA ANALISAR NOTAS E SITUAÇÃO DA TURMA

    :parametro n: uma ou mais notas do aluno(aceita várias)
    :parametro sit: parametro opcional que mostra a situação
    :return: dicionario com informações da turma\033[m
    
    '''
    r = {}
    r['TOTAL'] = len(n)
    r['MAIOR'] = max(n)                         # Montando o dicionario
    r['MENOR'] = min(n)
    r['MEDIA'] = sum(n) / len(n)
    if sit == True:                             # Montando a situação caso for verdadeira
        if r['MEDIA'] >= 7:                     
            r['SITUAÇÃO'] = 'BOA'
        if r['MEDIA'] <= 6.9:
            r['SITUAÇÃO'] = 'RAZOAVEL'
        if r['MEDIA'] <= 5:
            r['SITUAÇÃO'] = 'RUIM'
    return r
    

resp = notas(4.5,8.9,10,1,6,8,7,2,sit = True)             # Notas escolhidas e instruções da função
print(resp)
help(notas)










    



    



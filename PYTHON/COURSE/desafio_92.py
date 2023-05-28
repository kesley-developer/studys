'''Crie um programa que leia nome, ano de nascimento e carteira de trabalho e cadastre - os(com idade) em um dicionário se por acaso a CTPS
    for diferente de zero, o dicionário receberá também o ano de contratação e o salário. calcule e acrescente, além
    da idade, com quantos anos a pessoa vai se aposentar considerando 35 anos o minimo de validação'''

from datetime import datetime
dados = {}
anoatual = datetime.now().year
dados['NOME'] = str(input('Nome: ')).capitalize()
dados['NASCIMENTO'] = int(input('Ano de nascimento: '))
idade = anoatual - dados['NASCIMENTO']
dados['IDADE'] = idade
ctps = int(input('Carteira de trabalho(0 se não tiver): '))
if ctps > 0:
    dados['CTPS'] = ctps
    dados['CONTRATO'] = int(input('Ano de contratação: '))  # Analise de CTPS
    dados['SALARIO'] = float(input('Salário: '))
    aposent = dados["CONTRATO"] - dados["NASCIMENTO"]
    print('-' * 40)
    print(f'DADOS GERAIS: {dados}')
    print()
    for key,val in dados.items():
        print(f'{key}:',end = ' ')
        print(f'{val}')                                                           
    if aposent <= 34:
        print(f'{dados["NOME"]} podera se aposentar aos {aposent + 35} anos')    # Montando os dados e aposentadoria
    if aposent >= 35:
        print(f'{dados["NOME"]} ja passou do prazo de aposentadoria que era com {aposent + 35} anos') 
else:
    print('-' * 40)
    for key, val in dados.items():
        print(f'{key}: ',end = ' ')
        print(f'{val}')
    print(f'{dados["NOME"]} ainda não possui carteira de trabalho')
    
        

    
    

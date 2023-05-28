'''Crie um programa que tenha uma função chamada voto() que vai receber como parâmetro o ano de
    nascimento de uma pessoa, retornando um valor literal indicando se uma pessoa tem voto NEGADO,
    OPCIONAL ou OBRIGATÓRIO nas eleições'''



                                            
def voto(n):
    from datetime import date                  
    ida = date.today().year - n          # Calculando idade
    if ida < 16:
        return f'COM {ida} ANOS SEU VOTO É NEGADO'           
    if 16 <= ida < 18 or ida >= 65:
        return f'COM {ida} ANOS SEU VOTO É OPCIONAL'             # Retornando o voto de acordo com a idade
    if ida >= 18:
        return f'COM {ida} ANOS SEU VOTO É OBRIGATÓRIO'

nas = int(input('Ano de nascimento: '))
print('-' * 40)
print(voto(nas))               # Inserção da idade
print('-' * 40)




    



    

    

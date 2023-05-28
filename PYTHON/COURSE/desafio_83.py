'''Crie um programa onde o usuário digite uma expressão qualquer que use
    parênteses. Seu aplicativo deverá analisar se a expressão passada está
    com os parênteses abertos e fechados na ordem correta'''

print('{:^50}'.format('VALIDAÇÃO DE EXPRESSÃO MATEMATICA'))
exp = str(input('Digite uma expressão: '))
parenteses = []
for simb in exp:
    if simb == '(':
        parenteses.append('(')
    elif simb == ')':
        if len(parenteses) > 0:
            parenteses.pop()
        else:
            parenteses.append(')')
            break
if len(parenteses) == 0:
    print('Expressão válida!')
else:
    print('Sua expressão está inválida!')

    

    

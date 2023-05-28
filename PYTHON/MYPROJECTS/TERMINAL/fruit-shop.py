'''MERCADO DE FRUTAS'''

import time
import random
import colorama
colorama.init()

fruta = legume = ''
preço = 0
print('{:^50}'.format('\033[1;33mSUPERHORTIFRUTI\033[m'))
time.sleep(1)
print('- Produtos frescos e de qualidade')
time.sleep(1)
print('- Preço acessiveis e decontos imperdiveis')
time.sleep(0.5)
nom = str(input('Nome: ')).capitalize().split()[0]
time.sleep(0.5)
print(f'- Bem vindo \033[1;33m{nom}\033[m!')
time.sleep(0.5)
cupom = str(input('Deseja cupom para desconto?[S/N]: ')).upper().strip()[0]
num = random.randint(15897, 58741)
while cupom not in 'SN':
    print('\033[31mDigito inválido! Tente novamente!\033[m')
    cupom = str(input('Deseja cupom para desconto?[S/N]: ')).upper().strip()[0]
if cupom == 'S':
    print(f'- Seu cupom de desconto é \033[1;33m{num}\033[m')
time.sleep(0.5)
frutas = ('BANANA', 5.00, 'MAÇA', 3.50, 'LARANJA', 4.25, 'MANGA', 5.75, 'ABACATE', 8.75, 'LIMÃO', 5.25, 'ABACAXI', 5.00,
          'UVA', 6.00, 'TANGERINA', 5.25, 'MAMÃO', 6.00, 'COCO', 7.50)
legumes = (
'ALFACE', 3.25, 'TOMATE', 3.00, 'PEPINO', 3.00, 'CENOURA', 4.50, 'CEBOLA', 5.25, 'BETERRABA', 5.00, 'ERVILHA', 2.25,
'ABOBÓRA', 6.50,
'COUVE', 5.25, 'BRÓCOLIS', 6.00, 'INHAME', 5.50, 'MILHO', 3.75, 'PIMENTA', 4.50, 'PIMENTÃO', 3.00)
print('- Nossas opções são \033[1;31mFrutas\033[m e \033[1;32mLegumes\033[m')
time.sleep(0.5)
user = str(input('Oque você deseja?: ')).upper()
while user != 'FRUTAS' and user != 'LEGUMES':
    print('\033[31mOpção inválida! Tente novamente!\033[m')
    user = str(input('Oque você deseja?: ')).upper()
time.sleep(1)
# Montagem de legumes
if user == 'LEGUMES':
    print('- Nossas opções de \033[1;32mLegumes\033[m são: ')
    while True:
        print('-' * 40)
        print('\033[1;32m{:<10}\033[m \033[1;34m{:>15}\033[m'.format('LEGUME', 'PREÇO'))
        for prod in range(0, len(legumes), 2):
            print(f'{legumes[prod]:<20} R${legumes[prod + 1]:>.2f}')
        print('-' * 40)
        user = str(input('Produto: ')).upper()
        while user != 'ALFACE' and user != 'TOMATE' and user != 'PEPINO' and user != 'CENOURA' and user != 'CEBOLA' and user != 'BETERRABA' and user != 'ERVILHA' and user != 'ABOBÓRA' and user != 'ABOBORA' and user != 'COUVE' and user != 'BROCOLIS' and user != 'BRÓCOLIS' and user != 'INHAME' and user != 'MILHO' and user != 'PIMENTA' and user != 'PIMENTÃO' and user != 'PIMENTAO':
            print('\033[31mEsse legume não esta em nosso catalogo! Tente novamente!\033[m')
            user = str(input('Produto: ')).upper()
        time.sleep(1)
        if user == 'ALFACE':
            print('\033[33m- Alface foi adicionado ao carrinho\033[m')
            legume += 'Alface\n'
            preço += 3.25
        if user == 'TOMATE':
            print('\033[33m- Tomate foi adicionado ao carrinho\033[m')
            legume += 'Tomate\n'
            preço += 3.00
        if user == 'PEPINO':
            print('\033[33m- Pepino foi adicionado ao carrinho\033[m')
            legume += 'Pepino\n'
            preço += 3.00
        if user == 'CENOURA':
            print('\033[33m- Cenoura foi adicionado ao carrinho\033[m')
            legume += 'Cenoura\n'
            preço += 4.50
        if user == 'CEBOLA':
            print('\033[33m- Cebola foi adicionado ao carrinho\033[m')
            legume += 'Cebola\n'
            preço += 5.25
        if user == 'BETERRABA':
            print('\033[33m- Beterraba foi adicionado ao carrinho\033[m')
            legume += 'Beterraba\n'
            preço += 5.00
        if user == 'ERVILHA':
            print('\033[33m- Ervilha foi adicionado ao carrinho\033[m')
            legume += 'Ervilha\n'
            preço += 2.25
        if user == 'ABOBORA' or user == 'ABOBÓRA':
            print('\033[33m- Abobóra foi adicionado ao carrinho\033[m')
            legume += 'Abobóra\n'
            preço += 6.50
        if user == 'COUVE':
            print('\033[33m- Couve foi adicionado ao carrinho\033[m')
            legume += 'Couve\n'
            preço += 5.25
        if user == 'BROCOLIS' or user == 'BRÓCOLIS':
            print('\033[33m- Brócolis foi adicionado ao carrinho\033[m')
            legume += 'Brócolis\n '
            preço += 6.00
        if user == 'INHAME':
            print('\033[33m- Inhame foi adicionado ao carrinho\033[m')
            legume += 'Inhame\n'
            preço += 5.50
        if user == 'MILHO':
            print('\033[33m- Milho foi adicionado ao carrinho\033[m')
            legume += 'Milho\n'
            preço += 3.75
        if user == 'PIMENTA':
            print('\033[33m- Pimenta foi adicionado ao carrinho\033[m')
            legume += 'Pimenta\n'
            preço += 4.50
        if user == 'PIMENTAO' or user == 'PIMENTÃO':
            print('\033[33m- Pimentão foi adicionado ao carrinho\033[m')
            legume += 'Pimentão\n'
            preço += 3.00
        user = str(input('Deseja algo a mais?[S/N]: ')).upper().strip()[0]
        while user not in 'SN':
            print('\033[31mDigito inválido! Tente novamente!\033[m')
            user = str(input('Deseja algo a mais?[S/N]: ')).upper().strip()[0]
        if user == 'N':
            print('-' * 40)
            print('- Você comprou os seguintes produtos:')
            print(f'\033[1;33m{legume}\033[m')
            time.sleep(1)
            print(f'Total a pagar: \033[1;4;33mR$ {preço:.2f}\033[m')
            user = str(input('Deseja desconto?[S/N]: ')).upper().strip()[0]
            while user not in 'SN':
                print('\033[31mDigito inválido! Tente novamente!\033[m')
                user = str(input('Deseja desconto?[S/N]: ')).upper().strip()[0]
            if user == 'S':
                if cupom == 'S':
                    time.sleep(1)
                    meucupom = int(input('Cupom: '))
                    while meucupom != num:
                        print('\033[31mCupom inválido! Tente novamente!\033[m')
                        meucupom = int(input('Cupom: '))
                    if meucupom == num:
                        time.sleep(0.5)
                        print('- Nós estamos lhe ofertando 15% de desconto')
                        time.sleep(0.5)
                        print(f'- Sua compra que custava R$ \033[1;33m{preço}\033[m')
                        desconto = preço * 15 / 100
                        time.sleep(0.5)
                        print(f'- Passará a custar R$ \033[1;33m{preço - desconto:.2f}')
                        time.sleep(1)
                        print(f'- Obrigado pela preferencia \033[1;33m{nom}\033[m!')
                        time.sleep(0.5)
                        print('- Você sera redirecionado para a central de pagamento')
                        time.sleep(1)
                        break
                else:
                    print('\033[31m- Você não possui um cupom para desconto!\033[m')
                    time.sleep(1)
                    print(f'- Obrigado pela preferencia \033[1;33m{nom}\033[m!')
                    time.sleep(0.5)
                    print('- Você sera redirecionado para a central de pagamento')
                    break
            if user == 'N':
                time.sleep(1)
                print(f'- Obrigado pela preferencia \033[1;33m{nom}\033[m!')
                time.sleep(0.5)
                print('- Você sera redirecionado para a central de pagamento')
                break

# Montagem de frutas
if user == 'FRUTAS':
    print('- Nossas opções de \033[1;31mFrutas\033[m são: ')
    while True:
        print('-' * 40)
        print('\033[1;31m{:<10}\033[m \033[1;34m{:>15}\033[m'.format('FRUTA', 'PREÇO'))
        for prod in range(0, len(frutas), 2):
            print(f'{frutas[prod]:<20} R${frutas[prod + 1]:>.2f}')
        print('-' * 40)
        user = str(input('Produto: ')).upper()
        while user != 'BANANA' and user != 'MAÇA' and user != 'MACA' and user != 'LARANJA' and user != 'MANGA' and user != 'ABACATE' and user != 'LIMÃO' and user != 'LIMAO' and user != 'ABACAXI' and user != 'UVA' and user != 'TANGERINA' and user != 'MAMÃO' and user != 'MAMAO' and user != 'COCO':
            print('\033[31mEssa fruta não esta em nosso catalogo! Tente novamente!\033[m')
            user = str(input('Produto: ')).upper()
        time.sleep(1)
        if user == 'BANANA':
            print('\033[33m- Banana foi adicionado ao carrinho\033[m')
            fruta += 'Banana\n'
            preço += 5.00
        if user == 'MAÇA' or user == 'MACA':
            print('\033[33m- Maça foi adicionado ao carrinho\033[m')
            fruta += 'Maça\n'
            preço += 3.50
        if user == 'LARANJA':
            print('\033[33m- Laranja foi adicionado ao carrinho\033[m')
            fruta += 'Laranja\n'
            preço += 4.25
        if user == 'MANGA':
            print('\033[33m- Manga foi adicionado ao carrinho\033[m')
            fruta += 'Manga\n'
            preço += 5.75
        if user == 'ABACATE':
            print('\033[33m- Abacate foi adicionado ao carrinho\033[m')
            fruta += 'Abacate\n'
            preço += 8.75
        if user == 'LIMÃO' or user == 'LIMAO':
            print('\033[33m- Limão foi adicionado ao carrinho\033[m')
            fruta += 'Limão\n'
            preço += 5.25
        if user == 'ABACAXI':
            print('\033[33m- Abacaxi foi adicionado ao carrinho\033[m')
            fruta += 'Abacaxi\n'
            preço += 5.00
        if user == 'UVA':
            print('\033[33m- Uva foi adicionado ao carrinho\033[m')
            fruta += 'Uva\n'
            preço += 6.00
        if user == 'MAMAO' or user == 'MAMÃO':
            print('\033[33m- Mamão foi adicionado ao carrinho\033[m')
            fruta += 'Mamão\n'
            preço += 6.00
        if user == 'TANGERINA':
            print('\033[33m- Tangerina foi adicionado ao carrinho\033[m')
            fruta += 'Tangerina\n'
            preço += 5.25
        if user == 'COCO':
            print('\033[33m- Coco foi adicionado ao carrinho\033[m')
            fruta += 'Coco\n'
            preço += 7.50
        user = str(input('Deseja algo a mais?[S/N]: ')).upper().strip()[0]
        while user not in 'SN':
            print('\033[31mDigito inválido! Tente novamente!\033[m')
            user = str(input('Deseja algo a mais?[S/N]: ')).upper().strip()[0]
        if user == 'N':
            print('-' * 40)
            print('- Você comprou os seguintes produtos: ')
            print(f'\033[1;33m{fruta}\033[m')
            time.sleep(1)
            print(f'Total a pagar: \033[1;4;33mR$ {preço:.2f}\033[m')
            user = str(input('Deseja desconto?[S/N]: ')).upper().strip()[0]
            while user not in 'SN':
                print('\033[31mDigito inválido! Tente novamente!\033[m')
                user = str(input('Deseja desconto?[S/N]: ')).upper().strip()[0]
            if user == 'S':
                if cupom == 'S':
                    time.sleep(1)
                    meucupom = int(input('Cupom: '))
                    while meucupom != num:
                        print('\033[31mCupom inválido! Tente novamente!\033[m')
                        meucupom = int(input('Cupom: '))
                    if meucupom == num:
                        time.sleep(0.5)
                        print(f'- Nós estamos lhe ofertando 15% de desconto')
                        time.sleep(0.5)
                        print(f'- Sua compra que custava R$ \033[1;33m{preço:.2f}\033[m')
                        time.sleep(0.5)
                        desconto = (preço * 15) / 100
                        print(f'- Passara a custar R$ \033[1;33m{preço - desconto:.2f}\033[m')
                        time.sleep(1)
                        print(f'- Obrigado pela preferencia \033[1;33m{nom}\033[m!')
                        time.sleep(0.5)
                        print('- Você sera redirecionado para a central de pagamentos')
                        time.sleep(1)
                        break
                else:
                    print('\033[31mVocê não possui um cupom para desconto!\033[m')
                    time.sleep(1)
                    print(f'- Obrigado pela preferencia \033[1;33m{nom}\033[m!')
                    time.sleep(0.5)
                    print('- Você sera redirecionado para a central de pagamentos')
                    break
            if user == 'N':
                time.sleep(1)
                print(f'- Obrigado pela preferencia \033[1;33m{nom}\033[m!')
                time.sleep(0.5)
                print('- Você sera redirecionado para a central de pagamentos')
                time.sleep(1)
            break

# Pagamento fora da estrutura
if user == 'N':
    preço = preço
if user == 'S':
    if cupom == 'S':
        desconto = preço * 15 / 100
        preço = preço - desconto
    else:
        preço = preço
print('-' * 40)
time.sleep(2)
lista = ['', '.', '.', '.']
print('\033[1;31mAGUARDE\033[m', end='')
for posic in range(0, len(lista)):
    print(f'\033[1;31m{lista[posic]}\033[m', end='')
    time.sleep(1)
print('')
print('\033[1;32mCENTRAL DE PAGAMENTOS\033[m')
time.sleep(0.5)
print(f'Total a pagar: R$ \033[1;4;33m{preço:.2f}\033[m')
time.sleep(0.5)
print('Aceitamos:\n\033[33mBoleto\nCartão\033[m')
pag = str(input('Escolha uma forma de pagamento: ')).upper().split()[0]
while pag != 'BOLETO' and pag != 'CARTAO' and pag != 'CARTÃO':
    print('\033[31mDigito inválido! Escolha uma forma válida!\033[m')
    pag = str(input('Escolha uma forma de pagamento: ')).upper().split()[0]
time.sleep(0.5)
# Boleto
if pag == 'BOLETO':
    print('\n\033[1;34mBoleto\033[m')
    # Numero do boleto
    num = str(random.randint(1000, 9000))
    letra = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
             'V', 'W', 'X', 'Y', 'Z']
    print(
        f'Código do seu boleto: \033[1;4;33m{num}{random.choice(letra) + random.choice(letra) + random.choice(letra) + random.choice(letra)}\033[m')
    time.sleep(1)
    print('Efetue o pagamento na lotérica mais próxima')
# Cartão
if pag == 'CARTAO' or pag == 'CARTÃO':
    print('\n\033[1;34mCartão\033[m')
    conf = 'N'
    while conf == 'N':
        cart = int(input('Número do cartão: '))
        cart = str(cart).strip()
        valid = len(cart)
        if valid != 16:
            print('\033[1;31mNúmero do cartão inválido! Por favor tente novamente!\033[m')
        if valid == 16:
            print(f'\033[1;34m{cart[0:4]} - {cart[4:8]} - {cart[8:12]} - {cart[12:16 + 1]}\033[m')
            conf = str(input('Confirmar?[S/N]: ')).upper().strip()[0]
            while conf not in 'SN':
                print('\033[31mDigito inválido! Tente novamente!\033[m')
                conf = str(input('Confirmar?[S/N]: ')).upper().strip()[0]
            if conf == 'S':
                conf = 'S'
                while True:
                    print('Aceitamos pagamentos em até \033[33m12 Vezes\033[m')
                    parc = int(input('Parcelas: '))
                    while parc < 1 or parc > 12:
                        print('\033[31mDigito inválido! Escolha uma parcela entre 1 e 12!\033[m')
                        parc = int(input('Parcelas: '))
                    if parc == 1:
                        print(f'Você efetuara o pagamento á vista no valor de R$ \033[1;4;33m{preço:.2f}\033[m')
                    else:
                        print(
                            f'''Você efetuara o pagamento parcelado em \033[1;4;33m{parc}X\033[m Vezes e pagará mensalmente o valor de R$ \033[1;4;33m{preço / parc:.2f}\033[m''')
                    conf = str(input('Confirmar?[S/N]: ')).upper().strip()[0]
                    while conf not in 'SN':
                        print('\033[31mDigito inválido! Tente novamente!\033[m')
                        conf = str(input('Confirmar?[S/N]: ')).upper().strip()[0]
                    if conf == 'S':
                        time.sleep(0.5)
                        print('\033[33mPagamento efetuado com sucesso\033[m')
                        break

# Confirmação de pagamento fora da estrutura
time.sleep(1)
print('-' * 40)
lista = ['O', 'B', 'R', 'I', 'G', 'A', 'D', 'O', '\n', 'P', 'E', 'L', 'A', '\n', 'P', 'R', 'E', 'F', 'E', 'R', 'Ê', 'N',
         'C', 'I', 'A']
for num in range(0, len(lista)):
    print(f'\033[1;34m{lista[num]}\033[m', end='')
    time.sleep(00.20)







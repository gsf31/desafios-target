# 4) Descubra a lógica e complete o próximo elemento:
 
# A)

# n = 5

# valor = []
# i = 1

# while len(valor) < n:
#     if i % 2 != 0:
#         valor.append(i)
#     i += 1

# print(valor)

#RESPOSTA: a sequência apresenta somente valores ímpares e o próximo valor é 9

# B)

# ou

# valor = [2, 4, 8, 16, 32, 64]

# proximo_valor = valor[-1] * 2

# valor.append(proximo_valor)
# print(valor)

# O próximo  valor é o dobro do valor anterior valor[-1] * 2

# ou
# n = 7 

# valor = [2 * (2**i) for i in range(n)]

# print(valor)

#RESPOSTA:valor = [2 * 2**0 = 2 -> 2 *2**1 = 4 -> 2 * 2**2 = 8 ...], onde o último termo é igual a 128

#C)

# valor = [0, 1, 4, 9, 16, 25, 36]

# n = len(valor)
# proximo_valor = (n)**2

# valor.append(proximo_valor)
# print(valor)

#RESPOSTA: O quadrado dos valores n**2 [0, 1, 2, 3, 4, 5, 6, 7], onde o último termo é igual a 49

#ou

# valor = [0, 1]

# n = 8  

# while len(valor) < n:
#     diferenca = valor[-1] - valor[-2]
#     proximo_valor = diferenca + 2
#     novo_termo = valor[-1] + proximo_valor
#     valor.append(novo_termo)

# print(valor)

#D)

# n = 5

# valor = [(2 +2*i)**2 for i in range(n)]

# print(valor)

#RESPOSTA: É uma progressão aritmética dos valores das raízes quadradas dos termos da lista e o próximo valor é 100

#E)

# n = 7

# valor = [1, 1]

# while len(valor) < n:
#     proximo_termo = valor[-1] + valor[-2]
#     valor.append(proximo_termo)

# print(valor)

#RESPOSTA: É uma sequência de Fibonacci que começa em [1, 1] onde o proximo termo é a soma do último com o penúltimo e o último termo dessa sequência é 13

#F)

#valor = [2, 10, 12, 16, 17, 18, 19]

#RESPOSTA: Todos os números começam com a letra D, dois, dez, doze (...) o próximo termo com a letra D é 200








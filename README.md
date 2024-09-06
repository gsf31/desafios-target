QUESTÃO 4
Na Questão 4 achei interessante entender a lógica e compreender os resultados e depois gerar os códigos para as sequências, caso queiram testar cada um dos casos.
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

QUESTÃO 5

Interruptor 1, 2 e 3
Salas 1, 2 e 3
Ligando o interruptor 1 e esperando a lâmpada aquecer eu desligo o interruptor 1 e liga o interruptor 2 e vou na sala 1, e ai teria as seguintes situações:
1-A sala 1 poderia estar com a lâmpada apagada e fria e ai seria o interruptor 3
2-A sala 1 poderia estar com a lâmpada apagada e quente e seria o interruptor 1
3-A sala 1 poderia estar com a lâmpada acesa e seria o interruptor 2.
Voltando e indo a sala 2:
1-Como eu sei que a sala 1 está apagada e fria e já sei que ela é o interruptor 3, se a sala 2 estivesse apagada e quente ela seria o interruptor 1 e por consequência a sala 3 seria o interruptor  2 e estaria acesa.
2-Como eu sei que a sala 1 está apagada e quente eu sei que ela é o interruptor 1, se a sala 2 estiver apagada e frio o interruptor dela é o 3 e a sala 3 seria o interruptor 2 e estaria acesa.
3-Como eu sei que a sala 1 é o interruptor 2, caso a sala 2 estivesse apagada e quente o interruptor dela seria o 1 e a sala 3 por consequência seria o interruptor com a lâmpada apagada e fria, ou o contrário caso a sala 2 estivesse com a lâmpada apagada e fria.



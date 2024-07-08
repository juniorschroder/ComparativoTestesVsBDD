Funcionalidade: Calculadora de Honorários Advocatícios
Para evitar cobranças erradas
Como um advogado
Eu quero poder calcular os honorários corretamente

    Cenário: Calcular honorários com valores válidos
        Dado que o valor da causa é 10000
        E o percentual dos honorários é 10
        Quando eu calcular os honorários
        Então o valor dos honorários deve ser 1000

    Cenário: Calcular honorários com percentual inválido
        Dado que o valor da causa é 10000
        E o percentual dos honorários é -5
        Quando eu calcular os honorários
        Então deve ser lançada uma exceção
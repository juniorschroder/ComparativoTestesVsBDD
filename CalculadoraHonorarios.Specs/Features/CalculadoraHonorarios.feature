Funcionalidade: Calculadora de Honorários Advocatícios
Para evitar cobranças erradas
Como um advogado
Eu quero poder calcular os honorários corretamente

    Cenário: Calcular honorários com valores válidos
        Dado que o valor da causa é <valor da causa>
        E o percentual dos honorários é <percentual de honorarios>
        Quando eu calcular os honorários
        Então o valor dos honorários deve ser <valor honorarios>
        Exemplos:
        | valor da causa | percentual de honorarios | valor honorarios |
        | 10000          | 10                       | 1000             |
        | 35000          | 17,75                    | 6212,5           |
        | 200000         | 5                        | 10000            |

    Cenário: Calcular honorários com percentual inválido
        Dado que o valor da causa é 10000
        E o percentual dos honorários é -5
        Quando eu calcular os honorários
        Então deve ser lançada uma exceção
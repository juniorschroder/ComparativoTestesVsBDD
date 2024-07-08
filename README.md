# Projeto para comparativo entre utilização de testes unitários e BDD (Behavior Driven Development)

## Stack:
 - [.Net 8](https://dotnet.microsoft.com/pt-br/)
 - [xUnit](https://xunit.net/)
 - [Specflow](https://specflow.org/)

## Estrutura da solução:
 - **CalculadoraHonorarios**: Aplicação principal com fins didáticos, possui classe com funcionalidade de realizar o cálculo de valores de honorários advocatícios
 - **CalculadoraHonorarios.Tests**: Projeto de testes unitários com xUnit
 - **CalculadoraHonorarios.Specs**: Projeto de testes relacionados ao BDD com xUnit + Specflow
   - **/Features**: Diretário contendo os arquivos que descrevem as funcionalidades e cenários de testes utilizando a linguagem [Gherkin](https://specflow.org/learn/gherkin/)
   - **/Steps**: Diretório com a implementação dos testes utilizando o arquivo da feature

---
### Vantagens do uso de BDD com SpecFlow
1. **Clareza e Comunicação**: Os cenários de teste são escritos em linguagem natural (Gherkin), facilitando a comunicação entre desenvolvedores, testadores e partes interessadas não técnicas.
2. **Documentação Viva**: Os arquivos .feature servem como documentação viva do comportamento do sistema, mantendo os requisitos e testes sincronizados.
3. **Reutilização de Passos**: Passos definidos em SpecFlow podem ser reutilizados em múltiplos cenários, promovendo DRY (Don't Repeat Yourself).
4. **Foco no Comportamento**: BDD encoraja um foco no comportamento esperado do sistema, alinhando os testes com os objetivos de negócios.

### Considerações Finais
 - **xUnit**: Ideal para testes unitários rápidos e diretos. A sintaxe é simples e direta, mas a comunicação com partes interessadas não técnicas pode ser limitada. Outro ponto é a dependencia da maturidade do desenvolvedor para garantir que todos os cenários de regras de negócio estão sendo cobertos com testes realmente eficazes.
 - **SpecFlow (BDD)**: Facilita a comunicação e colaboração entre diferentes partes interessadas através de testes escritos em linguagem natural. A documentação viva e a reutilização de passos são vantagens significativas, especialmente em projetos complexos e colaborativos.
# Classificador de Nível de Herói

Este projeto em C# é um aplicativo de console que classifica o nível de um herói com base na sua quantidade de experiência (XP). O programa solicita o nome e a quantidade de XP de um herói e, em seguida, exibe uma mensagem indicando o nível do herói com base nas faixas de XP fornecidas.

## Funcionalidades

- Solicita o nome do herói e a quantidade de experiência (XP).
- Classifica o nível do herói de acordo com as seguintes faixas de XP:
  - XP < 1000: **Ferro**
  - XP entre 1001 e 2000: **Bronze**
  - XP entre 2001 e 5000: **Prata**
  - XP entre 5001 e 7000: **Ouro**
  - XP entre 7001 e 8000: **Platina**
  - XP entre 8001 e 9000: **Ascendente**
  - XP entre 9001 e 10000: **Imortal**
  - XP >= 10001: **Radiante**

## Requisitos

- [.NET SDK] 6.0 ou superior

## Como executar

1. **Clone o repositório**:

   ```bash
   git clone https://github.com/pradojuliana91/Desafio-Classificador-Heroi.git

2. **Entre na pasta do projeto:**:

   ```bash
   cd classificador-heroi

3. **Execute o programa:**:
   
   ````bash
   dotnet run

## Exemplo de uso:

  Digite o nome do herói: Thor
  Digite a quantidade de XP do herói: 4500
  O Herói de nome Thor está no nível de Prata.

## Estrutura do Código

- **Classificação**: A XP do herói é comparada com diferentes faixas para determinar o nível correto.
- **switch com switch expressions**: O programa usa `switch` para simplificar a escolha do nível do herói com base na faixa de XP.

## Tecnologias Utilizadas

- C#
- .NET 8.0
   

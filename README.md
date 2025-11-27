# 🧪 Estudo de Testes Unitários com xUnit e .NET 8

Este repositório contém um projeto prático desenvolvido para estudar e aplicar os fundamentos de **Testes Unitários** utilizando o framework **xUnit** no ecossistema **.NET 8**.

O objetivo foi criar uma calculadora simples, mas cobrindo diferentes cenários de testes para garantir a qualidade e a robustez do código.

## 🚀 Tecnologias Utilizadas
* **C#**
* **.NET 8**
* **xUnit** (Framework de Testes)

## 🧠 Conceitos e Padrões Aprendidos
Durante o desenvolvimento deste projeto, foram explorados os seguintes conceitos:

* **Padrão AAA (Arrange, Act, Assert):** Estruturação clara dos testes dividindo-os em preparação, ação e verificação.
* **Isolamento de Testes:** Criação de projetos separados para código de produção (`Calculadora`) e código de teste (`Calculadora.Testes`).
* **Fact vs Theory:**
    * `[Fact]`: Testes únicos e diretos.
    * `[Theory]` & `[InlineData]`: Testes parametrizados para validar múltiplos cenários de dados com o mesmo código.
* **Asserções Diversas:**
    * `Assert.Equal`: Validação de igualdade simples.
    * `Assert.True` / `Assert.False`: Validação de resultados booleanos.
    * `Assert.Contains` / `Assert.StartsWith`: Validação de conteúdo de strings.
* **Testes de Exceção:** Uso de `Assert.Throws<T>` para garantir que o sistema falha corretamente (ex: divisão por zero).

## 📂 Estrutura do Projeto

A solução está dividida em:
* `Calculadora/`: Class Library contendo a lógica de negócios.
* `Calculadora.Testes/`: Projeto xUnit contendo os testes automatizados.

## ▶️ Como Rodar os Testes

Para clonar o repositorio use:
```bash
git clone https://github.com/Ca22io/Estudo_xUnit
```
```bash
cd Estudo_xUnit
```

Para executar a bateria de testes, na pasta raiz do projeto via terminal execute:

```bash
dotnet test
```

Se desejar ver o detalhamento de cada teste executado (quais passaram e quais falharam), utilize:

```bash
dotnet test --logger "console;verbosity=detailed"
```

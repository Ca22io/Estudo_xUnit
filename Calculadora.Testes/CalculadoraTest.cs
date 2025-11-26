using Xunit;

namespace Calculadora.Testes;

public class CalculadoraTests
{
    // [Fact]
    // public void Somar_DeveRetornarResultadoCorreto()
    // {
    //     // 1. ARRANGE (Preparar)
    //     // Instancie a classe Calculadora aqui
    //     // Defina dois números para somar (ex: 2 e 3)
    //     var calculadora = new Calculadora();
    //     int num1 = 10;
    //     int num2 = 25;

    //     // 2. ACT (Agir)
    //     // Chame o método .Somar() passando os números e guarde o resultado numa variável
    //     int resultado = calculadora.Somar(num1, num2);

    //     // 3. ASSERT (Verificar)
    //     // Use Assert.Equal(esperado, obtido) para validar se a conta fechou
    //     Assert.Equal(35, resultado);
    // }

    [Theory] // Mudou de Fact para Theory
    [InlineData(10, 25, 35)] // Caso 1: 10 + 25 = 35
    [InlineData(1, 1, 2)]    // Caso 2: 1 + 1 = 2
    // Você pode adicionar quantas linhas quiser aqui...
    [InlineData(-1, -2, -3)] // Caso 3: -1 + -2 = -3
    public void Somar_DeveRetornarResultadoCorreto(int num1, int num2, int resultadoEsperado)
    {
        var calculadora = new Calculadora();

        // O Act agora usa os parâmetros que vêm do InlineData
        var resultado = calculadora.Somar(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void Dividir_PorZero_DeveLancarExcecao()
    {
        // Arrange
        var calculadora = new Calculadora();
        double dividendo = 10;
        double divisor = 0;

        //Act e Assert
        Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(dividendo, divisor));
    }

    [Theory]
    [InlineData(-5, 2, -2.5)] // Adicionando um caso que não deve lançar exceção
    [InlineData(10, 2, 5.0)] // Adicionando um caso que não deve lançar exceção
    public void Dividir_NumerosValidos_DeveRetornarResultado(int dividendo, int divisor, double resultadoEsperado)
    {
        // Arrange
        var calculadora = new Calculadora();

        //Act
        double resultado = calculadora.Dividir(dividendo, divisor);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void ObterTextoDeHistorico_Somar_DeveRetornarTextoCorreto()
    {
        // Arrange
        var calculadora = new Calculadora();
        int num1 = 3;
        int num2 = 7;
        string operacao = "somar";

        // Act
        string resultado = calculadora.ObterTextoDeHistorico(num1, num2, operacao);

        // Assert
        Assert.Contains("soma", resultado);
    }
}
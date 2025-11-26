using Xunit;
using Calculadora; // Importando o projeto que vamos testar

namespace Calculadora.Testes;

public class CalculadoraTests
{
    [Fact]
    public void Somar_DeveRetornarResultadoCorreto()
    {
        // 1. ARRANGE (Preparar)
        // Instancie a classe Calculadora aqui
        // Defina dois números para somar (ex: 2 e 3)
        var calculadora = new Calculadora();
        int num1 = 10;
        int num2 = 25;

        // 2. ACT (Agir)
        // Chame o método .Somar() passando os números e guarde o resultado numa variável
        int resultado = calculadora.Somar(num1, num2);

        // 3. ASSERT (Verificar)
        // Use Assert.Equal(esperado, obtido) para validar se a conta fechou
        Assert.Equal(35, resultado);
    }
}
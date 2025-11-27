namespace Calculadora;

    
public class Calculadora
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public double Dividir(double dividendo, double divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException("O divisor não pode ser zero.");
        }
        return dividendo / divisor;
    }

    public string ObterTextoDeHistorico(int num1, int num2, string operacao)
    {
        if (operacao == "somar")
        {
            int soma =  Somar(num1, num2);

            return $"A soma de {num1} e {num2} resultando em {soma}";
        }

        double resultado = Dividir(num1, num2);
        
        return $"A divisão de {num1} por {num2} resultando em {resultado}";
    }

    public bool EPar(int numero)
    {
        return numero % 2 == 0;
    }
}
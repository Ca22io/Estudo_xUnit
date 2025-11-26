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
}
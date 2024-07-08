namespace CalculadoraHonorarios;

public class CalculadoraHonorarios
{
    public decimal CalcularHonorarios(decimal valorCausa, decimal percentual)
    {
        if (valorCausa < 0 || percentual < 0 || percentual > 100)
        {
            throw new ArgumentException("Valores inválidos para cálculo de honorários.");
        }

        return valorCausa * (percentual / 100);
    }
}
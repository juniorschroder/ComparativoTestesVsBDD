namespace CalculadoraHonorarios.Tests;

public class CalculadoraHonorariosTests
{
    private const decimal ValorCausa = 10000m;
    
    [Fact]
    public void CalcularHonorarios_ValoresValidos_CalculaCorretamente()
    {
        // Arrange
        var calculadoraHonorarios = new CalculadoraHonorarios();
        var percentual = 10m;

        // Act
        decimal resultado = calculadoraHonorarios.CalcularHonorarios(ValorCausa, percentual);

        // Assert
        Assert.Equal(1000m, resultado);
    }

    [Fact]
    public void CalcularHonorarios_PercentualInvalido_LancaExcecao()
    {
        // Arrange
        var calculadoraHonorarios = new CalculadoraHonorarios();
        var percentual = -5m;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => calculadoraHonorarios.CalcularHonorarios(ValorCausa, percentual));
    }
}
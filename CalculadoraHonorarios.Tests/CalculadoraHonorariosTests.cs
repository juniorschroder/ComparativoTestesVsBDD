namespace CalculadoraHonorarios.Tests;

public class CalculadoraHonorariosTests
{
    [Theory]
    [InlineData(10000, 10, 1000)]
    [InlineData(200000, 5, 10000)]
    [InlineData(35000, 17.75, 6212.5)]
    public void CalcularHonorarios_ValoresValidos_CalculaCorretamente(decimal valorCausa, decimal percentualHonorarios, 
        decimal valorHonorarios)
    {
        // Arrange
        var calculadoraHonorarios = new CalculadoraHonorarios();
        
        // Act
        var resultado = calculadoraHonorarios.CalcularHonorarios(valorCausa, percentualHonorarios);

        // Assert
        Assert.Equal(valorHonorarios, resultado);
    }

    [Fact]
    public void CalcularHonorarios_PercentualInvalido_LancaExcecao()
    {
        // Arrange
        var calculadoraHonorarios = new CalculadoraHonorarios();
        var percentual = -5m;
        const decimal valorCausa = 10000m;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => calculadoraHonorarios.CalcularHonorarios(valorCausa, percentual));
    }
}
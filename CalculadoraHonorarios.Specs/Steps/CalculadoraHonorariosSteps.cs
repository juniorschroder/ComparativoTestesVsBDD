using TechTalk.SpecFlow;

namespace CalculadoraHonorarios.Specs.Steps;

[Binding]
public class CalculadoraHonorariosSteps
{
    private readonly CalculadoraHonorarios _calculadoraHonorarios;
    private decimal _valorCausa;
    private decimal _percentual;
    private decimal _resultado;
    private Exception? _excecao;

    public CalculadoraHonorariosSteps()
    {
        _calculadoraHonorarios = new CalculadoraHonorarios();
    }

    [Given("que o valor da causa é (.*)")]
    public void DadoQueOValorDaCausaE(decimal valorCausa)
    {
        _valorCausa = valorCausa;
    }

    [Given("o percentual dos honorários é (.*)")]
    public void DadoOPercentualDosHonorariosE(decimal percentual)
    {
        _percentual = percentual;
    }

    [When("eu calcular os honorários")]
    public void QuandoEuCalcularOsHonorarios()
    {
        try
        {
            _resultado = _calculadoraHonorarios.CalcularHonorarios(_valorCausa, _percentual);
        }
        catch (Exception ex)
        {
            _excecao = ex;
        }
    }

    [Then("o valor dos honorários deve ser (.*)")]
    public void EntaoOValorDosHonorariosDeveSer(decimal valorEsperado)
    {
        Assert.Equal(valorEsperado, _resultado);
    }

    [Then("deve ser lançada uma exceção")]
    public void EntaoDeveSerLancadaUmaExcecao()
    {
        Assert.NotNull(_excecao);
        Assert.IsType<ArgumentException>(_excecao);
    }
}
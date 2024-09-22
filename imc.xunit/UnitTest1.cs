namespace imc.xunit;

public class UnitTest1
{
    [Fact]
    public void Teste_Calculo_IMC()
    {
       double imc_previsto= 31.25;
       IMC i = new IMC();

       i.pesp = 80;
       i.altura = 1.60;

       i.Calcular_IMC();

       Assert.Equal(i.imc, imc_previsto);
    }

    [Thory]
    [InlineData("Abaixo do peso")]
    [InlineData("Peso normal")]
    [InlineData("Sobrepeso")]
    [InlineData("Obesidade Grau I")]
    [InlineData("Obesidade Grau II")]
    [InlineData("Obesidade Grau III")]

    public void Teste_Calculo_IMC(String cat) {
         IMC i = new IMC();

       i.pesp = 80;
       i.altura = 1.60;

       i.Calcular_IMC();
       i.Classificar_IMC();

       Assert.Equal(i.categoria, cat );
    }
}
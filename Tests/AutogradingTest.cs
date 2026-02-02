namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Declare_A_Method_Named_Square_That_Takes_One_Number_And_Returns_That_Number_Multiplied_By_Itself(){
        var calculator = new Calculator();
        var result = calculator.Square(7);
        Assert.Equal(49, result);
    }
}
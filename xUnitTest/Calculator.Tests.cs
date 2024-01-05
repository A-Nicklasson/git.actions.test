public class CalculatorTest { 
    [Fact]
    public void TestAddition() {

        // given
        Calculator calc = new();
        int a = 5;
        int b = 2;
        int expectedResult = 7;

        //when
        int result = calc.Addition(a,b);

        //then
        Assert.Equal(expectedResult, result);
    }

     [Fact]
    public void TestSubtract() {

        // given
        Calculator calc = new();
        float a = 5;
        float b = 2;
        int expectedResult = 5;

        //when
        float result = calc.Subtract(a,b);

        //then
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestMultiply() {

        // given
        Calculator calc = new();
        int a = 5;
        int b = 2;
        int expectedResult = 10;

        //when
        int result = calc.Multiply(a,b);

        //then
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestDivision() {

        // given
        Calculator calc = new();
        decimal a = 5;
        decimal b = 2;
        int expectedResult = 2;

        //when
        decimal result = calc.Division(a,b);

        //then
        Assert.Equal(expectedResult, result);
    } 
}
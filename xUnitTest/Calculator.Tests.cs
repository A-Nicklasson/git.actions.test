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
        float expectedResult = 3;

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
        double a = 5;
        double b = 2;
        double expectedResult = 2.5;

        //when
        double result = calc.Division(a,b);

        //then
        Assert.Equal(expectedResult, result);
    } 
}
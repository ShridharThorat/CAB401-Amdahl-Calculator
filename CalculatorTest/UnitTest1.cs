using Calculator;

namespace CalculatorTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMultiply()
    {
        double x = 4;
        double y = 3;
        double expected = 12;
        double result = Amdahl.Multiply(x, y);

        Assert.AreEqual(expected, result,"Multiply method failed to output correctly");
    }

    [TestMethod]
    public void TestMultiply2()
    {
        double x = 4;
        double y = 3;
        double expected = 12;
        double result = Amdahl.Multiply(x, y);

        Assert.AreEqual(expected, result,"Multiply method failed to output correctly");
    }

    [TestMethod]
    public void TestMultiply3()
    {
        double x = 4;
        double y = 3;
        double expected = 12;
        double result = Amdahl.Multiply(x, y);

        Assert.AreEqual(expected, result,"Multiply method failed to output correctly");
    }

}
using System;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

public class CalculatorTests
{
    [Test]
    public void Multiply_ReturnsCorrectResult()
    {
        Calculator calculator = new Calculator();
        int a = 2;
        int b = 3;

        int result = calculator.Multiply(a, b);

        Assert.AreEqual(6, result);
    }

    [Test]
    public void Divide_ReturnsCorrectResult()
    {
        Calculator calculator = new Calculator();
        int a = 10;
        int b = 2;

        int result = calculator.Divide(a, b);

        Assert.AreEqual(5, result);
    }

    [Test]
    public void Divide_ByZero_ThrowsException()
    {
        Calculator calculator = new Calculator();
        int a = 10;
        int b = 0;

        Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
    }
}
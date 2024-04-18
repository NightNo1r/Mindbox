namespace ShapeLib.Tests;

[TestFixture]
public class ShapeLibTests
{
    [Test]
    public void CalculateAreaForCircleShouldReturnCorrectValue_Test()
    {
        var circle = new Circle(5);
        Assert.That(circle.CalculateArea(), Is.EqualTo(78.53981633974483).Within(0.0001));
    }

    [Test]
    public void CalculateAreaForTriangleShouldReturnCorrectValue_Test()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.CalculateArea(), Is.EqualTo(6).Within(0.0001));
    }

    [Test]
    public void IsRightTriangleShouldReturnTrueForRightTriangle_Test()
    {
        var rightTriangle = new Triangle(3, 4, 5);

        Assert.That(rightTriangle.IsRightTriangle(), Is.True);
    }

    [Test] public void IsRightTriangleShouldReturnFalseForNonRightTriangle_Test()
    {
        var notRightTriangle = new Triangle(3, 4, 6);

        Assert.That(notRightTriangle.IsRightTriangle(), Is.False);
    }
}
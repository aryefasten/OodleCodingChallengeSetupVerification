using Xunit;
using Moq;

namespace SetupVerification;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new[] { 1, 2, 3, 4, 5 };

        foreach (var number in numbers)
        {
            var squared = number * number;
            Console.WriteLine($"{number} squared = {squared}");
        }

        Console.WriteLine("Setup verification complete!");
    }
}

public interface IGreeter
{
    string Greet(string name);
}

public class SetupVerificationTest
{
    [Fact]
    public void DotNet_IsWorking()
    {
        Assert.Equal(4, 2 + 2);
    }

    [Fact]
    public void Moq_IsWorking()
    {
        var mock = new Mock<IGreeter>();
        mock.Setup(g => g.Greet("World")).Returns("Hello, World!");

        Assert.Equal("Hello, World!", mock.Object.Greet("World"));
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(10, 20, 30)]
    public void XUnit_TheoryIsWorking(int a, int b, int expected)
    {
        Assert.Equal(expected, a + b);
    }
}

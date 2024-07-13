using Xunit;

public class OldPhonePadTests
{
    [Theory]
    [InlineData("33#", "E")]
    [InlineData("227*#", "B")]
    [InlineData("4433555 555666#", "HELLO")]
    [InlineData("8 88777444666*664#", "TURING")]
    [InlineData("669994440448 88 80999929#", "NYI HTUT ZAW")]
    public void ConvertInput_ValidInput_ReturnsExpectedOutput(string input, string expected)
    {
        // Arrange & Act
        var result = OldPhonePad.ConvertInput(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
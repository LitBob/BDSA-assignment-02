namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void UriIsSecureTest_Given_https_returns_true()
    {
        //Arrange
        var url = new Uri("https://github.com/itu-bdsa/assignment-02/blob/main/README.md");
        
        //Act
        var actual = url.IsSecure();
        var expected = true;

        //Assert
        Assert.Equal(expected,actual);

    }

    [Fact]
    public void UriIsSecureTest_Given_http_returns_false()
    {
        //Arrange
        var url = new Uri("http://github.com/itu-bdsa/assignment-02/blob/main/README.md");
        
        //Act
        var actual = url.IsSecure();
        var expected = false;

        //Assert
        Assert.Equal(expected,actual);

    }

    [Fact]
    public void WordCount_counts_words()
    {
        //Arrange
        var longText = "I am here, and count me please";

        //Act
        var actual = longText.WordCount();
        var expected = 7;

        //Assert
        Assert.Equal(expected, actual);

    }
}

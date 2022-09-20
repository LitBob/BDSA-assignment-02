namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void PrintReverse()
    {
        //Arrange
        string input = "Hello World";
        var lambda = (string s) => String.Concat(s.Reverse());

        //Act
        string actual = lambda(input);
        string expected = "dlroW olleH";
        //Assert
        Assert.Equal(expected, actual);
 
    }

    [Fact]
    public void ReturnProduct()
    {
        //Arrange
        decimal input1 = 7.2m;
        decimal input2 = 6.4m;
        
        var lambda = (decimal x, decimal y) => x * y;

        //Act
        decimal actual = lambda(input1, input2);
        decimal expected = 46.08m;
        //Assert
        Assert.Equal(expected, actual);
 
    }

    [Fact]
    public void StringAndNumberEqualIsTrue()
    {
        //Arrange
        string inputString = " 0048";
        int inputInt = 48;
        
        var lambda = (string x, int y) => int.Parse(inputString) == inputInt;
        //Act
        var actual = lambda(inputString, inputInt);
        var expected = true;
        //Assert
        Assert.Equal(expected, actual);
 
    }

    [Fact]
    public void StringAndNumberEqualIsFalse()
    {
        //Arrange
        string inputString = " 0127";
        int inputInt = 48;
        
        var lambda = (string x, int y) => int.Parse(inputString) == inputInt;
        //Act
        var actual = lambda(inputString, inputInt);
        var expected = false;
        //Assert
        Assert.Equal(expected, actual);
 
    }

    
}

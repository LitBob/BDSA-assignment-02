namespace Assignment2.Tests;


public class QueriesTests
{
    [Fact]
    public void Rowling_query_returns_Daniel3() 
    {
        //Arrange
        var wizards = WizardCollection.Create();

        //Act
        var output = wizards.GetRowlingWizards();
        var outputLINQ = wizards.GetRowlingWizardsLINQ();
        var expected = new[] {new Wizard("Daniel3", "Rocket League guden", 2004, "Rowling")};
        
        //Assert
        Assert.Equal(expected, output);
        Assert.Equal(output, outputLINQ);

    }

    [Fact]
    public void GetYearOfFirstSithLord_returns_1927(){
        //Arrange 
        var wizards = WizardCollection.Create();        

        //Act
        var output = wizards.GetYearOfFirstSithLord();
        var outputLINQ = wizards.GetYearOfFirstSithLordLINQ();

        //Assert
        Assert.Equal(1927,output);
        Assert.Equal(output, outputLINQ);
        
    }

    [Fact]
    public void Harry_Potter_Books_query_returns_three_instances(){
        //Arrange
        var wizards = WizardCollection.Create();

        //Act
        var output = wizards.GetHarryPotterNameAndYear();
        var outputLINQ = wizards.GetHarryPotterNameAndYearLINQ();
        var expected = new[] {("Daniel", 2001), ("Emy cea mai mare", 2022), ("Magnus", 2022)};

        //Assert
        Assert.Equal(expected, output);
        Assert.Equal(output, outputLINQ);

    }

    [Fact]
    public void Wizard_Names_In_Creator_Order_Then_By_Name(){
        //Arrange
        var wizards = WizardCollection.Create();

        //Act
        var output = wizards.GetWizardNamesGroupedByCreator();
        var outputLINQ = wizards.GetWizardNamesGroupedByCreatorLINQ();
        var expected = new [] {"Emy cea mai mare", "Daniel3", "The Very Best", "Gandalf", "Sauron", "Magnus", "Darth Cool", "Darth NotCool", "Darth Vader", "Daniel", "Daniel2", "Emilia den besvaerlige"};

        //Assert
        Assert.Equal(expected, output);
        Assert.Equal(output, outputLINQ);

    }


}

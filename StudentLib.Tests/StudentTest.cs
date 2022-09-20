namespace StudentLib.Tests;

public class StudentTest
{
    [Fact]
    public void StudentStatusTest()
    {
        //Arrange
        Student input = new Student{Id = 1, GivenName = "Daniel", Surname = "Danielsen", StartDate = new DateTime(2022, 1, 1), EndDate = new DateTime(2022, 12, 12), GraduationDate = new DateTime(2022, 12, 12)};
        
        //Act
        Status actual = input.Status;
        Status expected = Status.Active;

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void StudentStatusTest2()
    {
        //Arrange
        Student input = new Student{Id = 1, GivenName = "Daniel", Surname = "Danielsen", StartDate = new DateTime(2022, 11, 11), EndDate = new DateTime(2022, 12, 12), GraduationDate = new DateTime(2022, 12, 12)};
        
        //Act
        Status actual = input.Status;
        Status expected = Status.New;

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void StudentStatusTest3()
    {
        //Arrange
        Student input = new Student{Id = 1, GivenName = "Daniel", Surname = "Danielsen", StartDate = new DateTime(2022, 1, 1), EndDate = new DateTime(2022, 2, 2), GraduationDate = new DateTime(2022, 12, 12)};
        
        //Act
        Status actual = input.Status;
        Status expected = Status.Dropout;

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void StudentStatusTest4()
    {
        //Arrange
        Student input = new Student{Id = 1, GivenName = "Daniel", Surname = "Danielsen", StartDate = new DateTime(2022, 1, 1), EndDate = new DateTime(2022, 2, 2), GraduationDate = new DateTime(2022, 2, 2)};
        
        //Act
        Status actual = input.Status;
        Status expected = Status.Graduated;

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ImmutableStudent_compare1()
    {
        //Arrange
        ImmutableStudent student1  = new ImmutableStudent(1, "Daniel", "Danielsen", new DateTime(2022,1,1), new DateTime(2022,1,1), new DateTime(2022,1,1));
        ImmutableStudent student2  = new ImmutableStudent(1, "Daniel", "Danielsen", new DateTime(2022,1,1), new DateTime(2022,1,1), new DateTime(2022,1,1));

        //Act
        
        //Assert
        Assert.Equal(student1, student2);
        
    }

    [Fact]
    public void ImmutableStudent_compare2()
    {
        //Arrange
        ImmutableStudent student1  = new ImmutableStudent(1, "Daniel", "Danielsen", new DateTime(2022,1,1), new DateTime(2022,1,1), new DateTime(2022,1,1));
    
        //Act
        string expected = "ImmutableStudent { Id = 1, Name = Daniel, Surname = Danielsen, StartDate = 01-01-2022 00:00:00, EndDate = 01-01-2022 00:00:00, GraduationDate = 01-01-2022 00:00:00, Status = Graduated }";

        //Assert
        Assert.Equal(expected, student1.ToString());
    }

}
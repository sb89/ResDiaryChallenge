using ResDiaryChallenge.Extensions;

namespace ResDiaryChallenge.Tests.Extensions;

public class Tests
{
    [Test]
    public void GroupElements_NoRemainder_Success()
    {
        // Arrange
        int[] sut = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
        int numberOfGroups = 4;
        
        //Act
        int[][] result = sut.GroupElements(numberOfGroups);
        
        //Assert
        Assert.That(numberOfGroups, Is.EqualTo(result.Length));
        Assert.That(result[0], Is.EqualTo(new[] {1, 2, 3}));
        Assert.That(result[1], Is.EqualTo(new[] {4, 5, 6}));
        Assert.That(result[2], Is.EqualTo(new[] {7, 8, 9}));
        Assert.That(result[3], Is.EqualTo(new[] {10, 11, 12}));
    }
    
    [Test]
    public void GroupElements_Remainder_Success()
    {
        //Arrange
        int[] sut = {1, 2, 3, 4, 5};
        int numberOfGroups = 3;

        //Act
        int[][] result = sut.GroupElements(numberOfGroups);
        
        //Assert
        Assert.That(numberOfGroups, Is.EqualTo(result.Length));
        Assert.That(result[0], Is.EqualTo(new[] {1, 2}));
        Assert.That(result[1], Is.EqualTo(new[] {3, 4}));
        Assert.That(result[2], Is.EqualTo(new[] {5}));
    }
    
    [Test]
    public void GroupElements_SingleElement_Success()
    {
        //Arrange
        int[] sut = {1};
        int numberOfGroups = 1;

        //Act
        int[][] result = sut.GroupElements(numberOfGroups);
        
        //Assert
        Assert.That(numberOfGroups, Is.EqualTo(result.Length));
        Assert.That(result[0], Is.EqualTo(new[] {1}));
    }
    
    [Test]
    public void GroupElements_NumberOfGroupsIsZero_Exception()
    {
        //Arrange
        int[] sut = { 1, 2, 3 };
        int numberOfGroups = 0;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => sut.GroupElements(numberOfGroups));
    }
    
    [Test]
    public void GroupElements_SourceIsNUll_Exception()
    {
        //Arrange
        int[]? sut = null;
        int numberOfGroups = 5;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => sut.GroupElements(numberOfGroups));
    }
    
    [Test]
    public void GroupElements_SourceIsNUll_Exception2()
    {
        //Arrange
        int[] sut = { };
        int numberOfGroups = 3;
        
        //Act
        int[][] result = sut.GroupElements(numberOfGroups);
        
        Assert.That(numberOfGroups, Is.EqualTo(result.Length));
        Assert.That(result[0], Is.EqualTo(new int[] {}));
        Assert.That(result[1], Is.EqualTo(new int[] {}));
        Assert.That(result[2], Is.EqualTo(new int[] {}));
    }
    
}
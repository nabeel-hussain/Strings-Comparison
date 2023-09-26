using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class StringDifferenceTests
{
    [TestMethod]
    public void TestCountDifferentCharacters()
    {
        // Arrange
        string str1 = "abcdef";
        string str2 = "bcdegh";

        // Act
        int result = Program.CountDifferentCharacters(str1, str2);

        // Assert
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void TestCountDifferentCharactersWithEmptyStrings()
    {
        // Arrange
        string str1 = "";
        string str2 = "";

        // Act
        int result = Program.CountDifferentCharacters(str1, str2);

        // Assert
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestCountDifferentCharactersWithDifferentLengths()
    {
        // Arrange
        string str1 = "abc";
        string str2 = "abcd";

        // Act
        int result = Program.CountDifferentCharacters(str1, str2);

        // Assert
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void TestCountDifferentCharactersWithSpecialCharactersAndNumbers()
    {
        // Arrange
        string str1 = "abc$%^12";
        string str2 = "!@#$abc";

        // Act
        int result = Program.CountDifferentCharacters(str1, str2);

        // Assert
        Assert.AreEqual(6, result);
    }
    [TestMethod]
    public void TestCountDifferentCharactersWithDuplicatesCharacters()
    {
        // Arrange
        string str1 = "hello";
        string str2 = "hhelllo";

        // Act
        int result = Program.CountDifferentCharacters(str1, str2);

        // Assert
        Assert.AreEqual(0, result);
    }
}

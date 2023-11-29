using Hands_On_Solution;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Testss
{
    public class UnitTest1
    {
        [Fact]
        public void Testing_Unique_Numbers()
        {
            // Arrange
            var inputList = new List<int> { 1, 2, 2, 3, 3, 4, 5, 5 };

            // Act
            var result = Arrange_List.UniNumbers(inputList);

            // Assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, result);
        }



        [Fact]
        public void Testing_Empty_list()
        {
            // Arrange
            var inputList = new List<int> { };

            // Act
            var result = Arrange_List.UniNumbers(inputList);

            // Assert
            Assert.Equal(new List<int> { }, result);
        }



        [Fact]
        public void List_with_No_Dublicates()
        {
            // Arrange
            var inputList = new List<int> { 1, 2, 3, 4, 5 };

            // Act
            var result = Arrange_List.UniNumbers(inputList);

            // Assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, result);
        }
    }
}
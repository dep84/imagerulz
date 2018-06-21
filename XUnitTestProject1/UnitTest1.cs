using System.IO;
using DomainLayer.Services;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Should_Save_Image_TO_Dish_Given_Valid_Image_Data_As_Byte_Array()
        {
            //Arrange
            //Add a sample image to this project
            var image = File.ReadAllBytes("");
            //set a path e.g. "C:\\users\\pittan\\desktop\\imagesffs
            var path = "";

            var imageService = new ImageService();
            //Act
            imageService.SaveImageToFile(path, image);

            //Arrange

            //Assert.True();
        }
    }
}

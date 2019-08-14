using AzurePipelineTestWebApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace SampleUnitTest
{
   public class UnitTest1
   {
      [Fact]
      public void Index()
      {
         // Arrange
         HomeController controller = new HomeController();
         // Act
         ViewResult result = controller.Index() as ViewResult;
         // Assert
         Assert.NotNull(result);
      }
      [Fact]
      public void Privacy()
      {
         // Arrange
         HomeController controller = new HomeController();
         // Act
         ViewResult result = controller.Privacy() as ViewResult;

         // Assert
         Assert.NotNull(result);
         Assert.Equal("Privacy", result.ViewName);
      }
   }
}

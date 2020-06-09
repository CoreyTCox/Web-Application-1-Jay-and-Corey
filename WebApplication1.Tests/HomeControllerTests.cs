using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}

using Xunit;
using Shopping.Controllers;
using Moq;
using Shopping.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingManagement.Test
{
    public class ProductsControllerTest
    {
        private readonly ProductsController _productsController;
        private Mock<ShoppingContext> _context;

        public ProductsControllerTest()
        {
            _context = new Mock<ShoppingContext>();
            _productsController = new ProductsController(_context.Object);
        }

        [Fact]
        public async Task IndexTestAsync()
        {
            var result = await _productsController.Index();
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.IsAssignableFrom<Products>(viewResult.ViewData.Model); 
        }

        [Fact]
        public async Task DetailsTestAsync()
        {
            var result = await _productsController.Details(1);
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.True(viewResult.ViewData.Model != null);
            Assert.IsAssignableFrom<Products>(viewResult.ViewData.Model);
        }

        [Fact]
        public async Task CreateTestAsync()
        {
            var result = await _productsController.Details(1);
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.IsAssignableFrom<Products>(viewResult.ViewData.Model);
        }

        [Fact]
        public async Task EditTestAsync()
        {
            var result = await _productsController.Edit(1);
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.True(viewResult.ViewData.Model != null);
            Assert.IsAssignableFrom<Products>(viewResult.ViewData.Model);
        }

        [Fact]
        public async Task UpdateTestAsync()
        {
            var editResult = await _productsController.Edit(1);
            var editViewResult = Assert.IsType<ViewResult>(editResult);

            var result = await _productsController.Edit(1, (Products)editViewResult.ViewData.Model);
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.True(viewResult.ViewData.Model != null);
            Assert.IsAssignableFrom<Products>(viewResult.ViewData.Model);
        }
    }
}

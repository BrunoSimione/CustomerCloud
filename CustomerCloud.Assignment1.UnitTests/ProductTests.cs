using CustomerCloud.Assignment1.UnitTests.ProductServiceReference;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCloud.Assignment1.UnitTests
{
    [TestClass]
    public class ProductTests
    {
        ProductDTO _dto;

        [TestInitialize]
        public void Init()
        {
            _dto = new ProductDTO()
            {
                Id = Guid.NewGuid(),
                Description = "Product1",
                Price = 200.01M
            };
        }
        [TestMethod]
        public void Create_Product()
        {
            ProductServiceReference.ProductClient product = new ProductClient("BasicHttpBinding_IProduct");
            product.Open();
            product.Create(_dto);

            ProductDTO result = product.Read(_dto.Id);
            Assert.IsNotNull(result);
        }
    }
}

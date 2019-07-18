using System;
using Xunit;
using api.Repositories;
using api.Models;
using api.Service;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mock = new Mock<IShoppingCartRepository>();
            var a = new List<Item>(){
                new Item{
                Id = 1,
                Name = "asdas",
                }
            };
            IEnumerable<Item> b = a;
            mock.Setup(m => m.GetAllItems()).Returns(b);
            var svc = new ShoppingCartService(mock.Object);
            // var data = svc.GetAllItems();
            // Assert.Equal(5, data.Count());
        }
    }
}

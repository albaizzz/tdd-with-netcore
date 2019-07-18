using System;
using Xunit;
using System.Collections.Generic;

namespace unitest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var list = new List<int>();
			list.Add(4);
			list.Add(3);
			list.Add(2);
			list.Add(1);
            Assert.Equal("a","a");

            Assert.Equal("a","a");

            Assert.Equal("a","a");
            Assert.Equal("a","a");
            Assert.Equal("a","a");
            Assert.Equal("a","a");
            Assert.Equal("a","a");
            Assert.Equal("a","a");
        }
        [Fact]
        public void Test2(){
            Assert.Equal("a","a");
        }

        [Fact]
        public void TestName()
        {
        //Given

        //When

        //Then
        }
        
    }
}

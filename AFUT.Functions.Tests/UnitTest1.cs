using System;
using Xunit;
using AFUT.Functions;

namespace AFUT.Functions.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void EnsureNamePassedWorks()
        {
            string name = "XUnit";
            string response = Helpers.GetResponseMessage(name);
            Assert.Equal($"Hello {name}", response);
        }

        [Fact]
        public void EnsureNullPassedWorks()
        {
            string name = null;
            string response = Helpers.GetResponseMessage(name);
            Assert.Equal($"Please provide a name", response);
        }
        
        [Fact]
        public void EnsureEmptyStringPassedWorks()
        {
            string name = string.Empty;
            string response = Helpers.GetResponseMessage(name);
            Assert.Equal($"Please provide a name", response);
        }
    }
}

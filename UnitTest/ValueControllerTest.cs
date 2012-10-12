using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CITest.Controllers;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class ValueControllerTest
    {
        [Test]
        public void Get_Success()
        {
            var controller = new ValuesController();
            var result = controller.Get().ToArray();
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result[0]);
            Assert.AreEqual("value2", result[1]);
        }
    }
}

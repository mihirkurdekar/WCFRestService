using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using WCFService;

namespace UnitTestWCFService
{
	[TestFixture]
	public class UnitTest
	{
        private static RestService _service;

        public UnitTest()
        {
            _service = new RestService();
        }
		
		[Test(Description="For additing 2 valid numbers")]
        public void getAddition()
        {
			
            string result=_service.getAddition("10", "12");
            Assert.AreEqual("22", result);

        }

        [Test(Description="Addition Of 2 empty Strings")]
        public void getAdditionEmptyInput()
        {

            string result = _service.getAddition("", "");
            Assert.AreEqual("Some error occured", result);

        }

	}
}
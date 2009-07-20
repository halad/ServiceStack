﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace ServiceStack.Examples.ServiceInterface.Tests
{
	[TestFixture]
	public class GetFactorialTests : TestBase
	{
		[Test]
		public void GetFactorial_Test()
		{
			var request = new GetFactorial { ForNumber = 4 };

			var handler = new GetFactorialHandler();
			
			var response = (GetFactorialResponse)handler.Execute(CreateOperationContext(request));

			Assert.That(response.Result, Is.EqualTo(4 * 3 * 2 * 1));
		}
	}

}
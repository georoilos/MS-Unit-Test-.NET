using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Calculator.Tests
{	[TestClass]
	public class CalculatorOpTest
	{	[TestMethod]
		public void InputValues1()
		{	//Arrange
			CalculatorOp calc = new CalculatorOp();
			//Act
			int act = calc.Add(5, 4);
			//Assert
			Assert.AreEqual(9, act);
		}
		[TestMethod]
		public void InputValues2()
		{	//Arrange
			CalculatorOp calc = new CalculatorOp();
			//Act
			int act = calc.Mul(5, 4);
			//Assert
			Assert.AreEqual(20, act);
		}
	}
}
